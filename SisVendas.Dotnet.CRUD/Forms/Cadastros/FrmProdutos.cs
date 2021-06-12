using System;
using System.Drawing;
using System.Windows.Forms;
using UI.Infraestrutura;
using UI.Models.Interfaces;
using UI.Models.Repository;
using UI.Models.ViewModel;

namespace UI.Forms.Cadastros
{
    public partial class FrmProdutos : Form
    {
        EstruturaGridView criaHG;
        TextBoxCustomValues tcv;
        IProdutos produtosRepository;
        IGlobal globalRepository;
        private int codigoProduto = 0;
        public FrmProdutos()
        {
            criaHG=new EstruturaGridView();
            tcv=new TextBoxCustomValues();
            produtosRepository =new ProdutosRepository();
            globalRepository=new GlobalRepository();
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();
            dgvProdutos.Columns.Clear();
            limpaCampos();
            criaHG.criaHeadersGrid(dgvProdutos, "Codigo", "Codigo", true, 45);
            criaHG.criaHeadersGrid(dgvProdutos, "Ean", "Ean", true, 50);
            criaHG.criaHeadersGrid(dgvProdutos, "Nome Produto", "NomeProduto", true, 200);
            criaHG.criaHeadersGrid(dgvProdutos, "Preço Custo", "PrecoCusto", true, 100);
            criaHG.criaHeadersGrid(dgvProdutos, "Preço Venda", "PrecoVenda", true, 101);
            criaHG.criaHeadersGridImagemButton(dgvProdutos, "Editar", "Editar", UI.Properties.Resources.EditarPropriedade20px);
            criaHG.criaHeadersGridImagemButton(dgvProdutos, "Excluir", "Excluir", UI.Properties.Resources.Excluir20px);
            dgvProdutos.DataSource=produtosRepository.GetALLProdutos();
        }

        private void txbPrecoCusto_KeyUp(object sender, KeyEventArgs e)
        {
        }
        public static void ConvertDecimal(object sender, EventArgs e, TextBox t)
        {
            if(t.Text.Trim().TrimEnd().Length!=0)
                t.Text=Convert.ToDecimal(t.Text).ToString("N2");
        }

        private void txbPrecoCusto_Leave(object sender, EventArgs e)
        {
            ConvertDecimal(sender, e, txbPrecoCusto);
        }

        private void txbPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            tcv.PermiteDecimal(sender, e, ',');
        }

        private void txbPrecoVenda_Leave(object sender, EventArgs e)
        {
            ConvertDecimal(sender, e, txbPrecoVenda);
        }

        private void txbPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            tcv.PermiteDecimal(sender, e, ',');
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = int.Parse(e.RowIndex.ToString());
            if(linha<0)
                return;

            if(dgvProdutos.Columns[e.ColumnIndex].Name=="Editar")
            {
                btnAtualizar.Visible=true;
                btnCadastrar.Visible=false;
                btnDeletar.Visible=true;
                codigoProduto=Convert.ToInt32(dgvProdutos.Rows[linha].Cells["Codigo"].Value);
                txbEan.Text=dgvProdutos.Rows[linha].Cells["Ean"].Value.ToString();
                txbNomeProd.Text=dgvProdutos.Rows[linha].Cells["NomeProduto"].Value.ToString();
                txbPrecoCusto.Text=dgvProdutos.Rows[linha].Cells["PrecoCusto"].Value.ToString();
                txbPrecoVenda.Text=dgvProdutos.Rows[linha].Cells["PrecoVenda"].Value.ToString();
            }
            else if(dgvProdutos.Columns[e.ColumnIndex].Name=="Excluir")
            {
                excluirProduto((int)dgvProdutos.Rows[linha].Cells["Codigo"].Value);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            salvaProduto();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            salvaProduto(1);
        }
        #region METODOS
        void limpaCampos()
        {
            txbNomeProd.Clear();
            txbEan.Clear();
            txbPrecoCusto.Text="0,00";
            txbPrecoVenda.Text="0,00";
            codigoProduto=0;
            btnDeletar.Visible=false;
            btnAtualizar.Visible=false;
            btnCadastrar.Visible=true;
        }
        private void salvaProduto(int operacao = 0)
        {
            try
            {
                ProdutosViewModel _prod = new ProdutosViewModel();
                _prod.NomeProduto=txbNomeProd.Text.Trim();
                _prod.Ean=txbEan.Text.Replace(" ", "");
                _prod.PrecoCusto=Convert.ToDecimal(txbPrecoCusto.Text);
                _prod.PrecoVenda=Convert.ToDecimal(txbPrecoVenda.Text);

                var erros = globalRepository.getValidationErros(_prod);
                foreach(var error in erros)
                {
                    MessageBox.Show(error.ErrorMessage, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(operacao==0)
                {
                    if(produtosRepository.Create(_prod)==true)
                        MessageBox.Show("Produto Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Oops!\n Ocorreu um erro ao realizar o cadastro, verifique as informações e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _prod.Codigo=codigoProduto;
                    if(produtosRepository.Update(_prod)==true)
                        MessageBox.Show("Produto Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Oops!\n Ocorreu um erro ao Atualizar, verifique as informações e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpaCampos();
                btnCadastrar.Visible=true;
                dgvProdutos.DataSource=produtosRepository.GetALLProdutos();
            }
            catch
            {
                MessageBox.Show("Oops!\n Ocorreu um erro ao realizar a operação, verifique as informações e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void excluirProduto(int id)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir?", "excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(produtosRepository.Delete(id)==true)
                    MessageBox.Show("Produto excluido com sucesso");
                limpaCampos();
                btnAtualizar.Visible=false;
                dgvProdutos.DataSource=produtosRepository.GetALLProdutos();
            }
        }
        #endregion

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            excluirProduto(codigoProduto);
        }
    }
}
