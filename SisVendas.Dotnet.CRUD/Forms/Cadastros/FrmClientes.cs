using System;
using System.Drawing;
using System.Windows.Forms;
using UI.Componentes;
using UI.Models.Interfaces;
using UI.Models.Repository;
using UI.Models.ViewModel;
using UI.Infraestrutura;

namespace UI.Forms.Cadastros
{
    public partial class FrmClientes : Form
    {
        IClientes clientesRepository;
        IGlobal globalRepository;
        private int CodigoCliente = 0;
        EstruturaGridView criaHG;
        public FrmClientes()
        {
            criaHG=new EstruturaGridView();
            clientesRepository=new ClientesRepository();
            globalRepository=new GlobalRepository();
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            salvaCliente();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Columns.Clear();
            limpaCampos();
            criaHG.criaHeadersGrid(dgvClientes, "Codigo", "Codigo", true, 50);
            criaHG.criaHeadersGrid(dgvClientes, "Nome", "Nome", true, 100);
            criaHG.criaHeadersGrid(dgvClientes, "Telefone", "Telefone", true, 130);
            criaHG.criaHeadersGrid(dgvClientes, "Email", "Email", true, 150);
            criaHG.criaHeadersGridImagemButton(dgvClientes, "Editar", "Editar", UI.Properties.Resources.EditarPropriedade20px);
            criaHG.criaHeadersGridImagemButton(dgvClientes, "Excluir", "Excluir", UI.Properties.Resources.Excluir20px);
            dgvClientes.DataSource=clientesRepository.GetALLClientes();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            salvaCliente(1);
        }
       
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = int.Parse(e.RowIndex.ToString());
            if(linha<0)
                return;

            if(dgvClientes.Columns[e.ColumnIndex].Name=="Editar")
            {
                btnAtualizar.Visible=true;
                btnCadastrar.Visible=false;
                btnDeletar.Visible=true;
                CodigoCliente=Convert.ToInt32(dgvClientes.Rows[linha].Cells["Codigo"].Value);
                txbNome.Text=dgvClientes.Rows[linha].Cells["Nome"].Value.ToString();
                txbTelefone.Text=dgvClientes.Rows[linha].Cells["Telefone"].Value.ToString();
                txbEmail.Text=dgvClientes.Rows[linha].Cells["Email"].Value.ToString();
            }
            else if(dgvClientes.Columns[e.ColumnIndex].Name=="Excluir")
            {
                excluirCliente((int)dgvClientes.Rows[linha].Cells["Codigo"].Value);
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            excluirCliente(CodigoCliente);
        }

        #region METODOS
        private void limpaCampos()
        {
            txbEmail.Clear();
            txbNome.Clear();
            txbTelefone.Clear();
            CodigoCliente=0;
            btnDeletar.Visible=false;
            btnAtualizar.Visible=false;
            btnCadastrar.Visible=true;
        }
        private void salvaCliente(int operacao = 0)
        {
            try
            {

                ClienteViewModel _cliVM = new ClienteViewModel();
                _cliVM.Nome=txbNome.Text.Trim();
                _cliVM.Telefone=txbTelefone.Text.Replace(" ", "");
                _cliVM.Email=txbEmail.Text;

                var erros = globalRepository.getValidationErros(_cliVM);
                foreach(var error in erros)
                {
                    MessageBox.Show(error.ErrorMessage, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if(operacao==0)
                {
                    if(clientesRepository.Create(_cliVM)==true)
                        MessageBox.Show("Cliente Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Oops!\n Ocorreu um erro ao realizar o cadastro, verifique as informações e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    _cliVM.Codigo=CodigoCliente;
                    if(clientesRepository.Update(_cliVM)==true)
                        MessageBox.Show("Cliente Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Oops!\n Ocorreu um erro ao Atualizar, verifique as informações e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpaCampos();


                btnCadastrar.Visible=true;

                dgvClientes.DataSource=clientesRepository.GetALLClientes("");
            }
            catch
            {
                MessageBox.Show("Oops!\n Ocorreu um erro ao realizar a operação, verifique as informações e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void excluirCliente(int id)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir?", "excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(clientesRepository.Delete(id)==true)
                    MessageBox.Show("Cliente excluido com sucesso");
                limpaCampos();
                btnAtualizar.Visible=false;
                dgvClientes.DataSource=clientesRepository.GetALLClientes();
            }
        }
        #endregion

    }
}
