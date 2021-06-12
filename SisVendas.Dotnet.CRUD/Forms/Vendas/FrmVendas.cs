using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Infraestrutura;
using UI.Models.Entities;
using UI.Models.Interfaces;
using UI.Models.Repository;
using UI.Models.ViewModel;

namespace UI.Forms.Vendas
{
    public partial class FrmVendas : Form
    {
        EstruturaGridView criaHG;
        private int codigoVenda = 0;
        TextBoxCustomValues tcv;
        IVendas vendasRepository;
        public FrmVendas()
        {
            tcv=new TextBoxCustomValues();
            vendasRepository=new VendasRepository();
            criaHG=new EstruturaGridView();
            InitializeComponent();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab=tpVendasRealizadas;
            dgvListaProdutos.Rows.Clear();
            dgvListaProdutos.Columns.Clear();
            btnEnviarEmail.Visible=false;
            btnFinalizarVenda.Visible=true;
            btnCancelar.Visible=true;
            criaHG.criaHeadersGrid(dgvListaProdutos, "Codigo", "Cod", true, 50, 50);
            criaHG.criaHeadersGrid(dgvListaProdutos, "Nome", "NomeProduto", true, 120);
            criaHG.criaHeadersGrid(dgvListaProdutos, "Qtd", "qtdvendido", true, 30, 30);
            criaHG.criaHeadersGrid(dgvListaProdutos, "Preço", "ValorVendido", true, 50, 50);
            criaHG.criaHeadersGrid(dgvListaProdutos, "Total", "Total", true, 50, 50);
            criaHG.criaHeadersGridImagemButton(dgvListaProdutos, "Remover", "Remover", UI.Properties.Resources.Remover20px);


            criaHG.criaHeadersGrid(dgvVendasRealizadas, "Cod. Venda", "Codigo", true, 30, 60);
            criaHG.criaHeadersGrid(dgvVendasRealizadas, "Cliente", "NomeCliente", true, 150);
            criaHG.criaHeadersGrid(dgvVendasRealizadas, "Valor Vendido", "ValorVendido", true, 50, 80);
            criaHG.criaHeadersGrid(dgvVendasRealizadas, "Data da Venda", "DtVenda", true, 50, 100);
            criaHG.criaHeadersGridImagemButton(dgvVendasRealizadas, "Ver", "Ver", UI.Properties.Resources.Pesquisar20px);

            cbxClientes.DataSource=vendasRepository.carregaCbxClientes();
            cbxProduto.DataSource=vendasRepository.carregaCbxProdutos();
            dtpInicio.Value=DateTime.Now.AddDays(-30);
            listaVendas();

        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            cbxClientes.Enabled=true;
            if(dgvListaProdutos.RowCount>0)
                dgvListaProdutos.Rows.Clear();
            limpaCampos();
            tabControl1.SelectedTab=tpVendas;
            cbxClientes.Select();
            dgvListaProdutos.Columns["Remover"].Visible=true;
            panelProdutosAdd.Visible=true;
            btnEnviarEmail.Visible=false;
            btnFinalizarVenda.Visible=true;
            btnCancelar.Visible=true;



        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listaVendas();
        }

        private void dgvVendasRealizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limpaCampos();
            btnEnviarEmail.Visible=true;
            btnFinalizarVenda.Visible=false;
            btnCancelar.Visible=true;
            panelProdutosAdd.Visible=false;
            if(e.RowIndex<0)
                return;
            if(dgvVendasRealizadas.Columns[e.ColumnIndex].Name=="Ver")
            {
                tabControl1.SelectedTab=tpVendas;
                txbDtVenda.Text=dgvVendasRealizadas.Rows[e.RowIndex].Cells["DtVenda"].Value.ToString();
                codigoVenda = Convert.ToInt32(dgvVendasRealizadas.Rows[e.RowIndex].Cells["Codigo"].Value);
                txbCodVenda.Text=codigoVenda.ToString();
                cbxClientes.SelectedValue=vendasRepository.codcliente(codigoVenda);
                cbxClientes.Enabled=false;
                
               dgvListaProdutos.DataSource=vendasRepository.getItensVendaPorCodigoVenda(codigoVenda);
                dgvListaProdutos.Columns["Remover"].Visible=false;


            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            int cod = (int)cbxProduto.SelectedValue;
            string nome = cbxProduto.Text;
            decimal valortotal = numQtd.Value*Convert.ToDecimal(txbPrecoVenda.Text);
            dgvListaProdutos.Rows.Add(cod, nome, numQtd.Value, txbPrecoVenda.Text, valortotal);
            lblValorTotal.Text=Convert.ToString(valortotal+Convert.ToDecimal(lblValorTotal.Text));
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if(dgvListaProdutos.Rows.Count<1)
            {
                MessageBox.Show("A Lista de produtos está vazia! \nAdicione os produtos na lista para finalizar a venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if(cbxClientes.SelectedValue==null) {
                MessageBox.Show("Selecione um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            int codCliente = Convert.ToInt32(cbxClientes.SelectedValue);
            decimal ValorTotalVenda = Convert.ToDecimal(lblValorTotal.Text);
            if(MessageBox.Show("Deseja finalizar a venda?","Finalizar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                VendaViewModel venda = new VendaViewModel();
                venda.ClienteCodigo=codCliente;
                venda.ValorVenda=ValorTotalVenda;
              
                var itens =new List<ItensVendas>();
                for(int i = 0; i<dgvListaProdutos.RowCount; i++)
                {
                    itens.Add(new ItensVendas
                    {
                        ProdutoCodigo=Convert.ToInt32(dgvListaProdutos.Rows[i].Cells["Cod"].Value),
                        QtdVendido=Convert.ToInt32(dgvListaProdutos.Rows[i].Cells["qtdvendido"].Value),
                        ValorVendido=Convert.ToDecimal(dgvListaProdutos.Rows[i].Cells["ValorVendido"].Value)
                    }) ;
                }
                int codVenda = vendasRepository.SalvaVenda(venda,itens);
                if(codVenda==0)
                {
                    MessageBox.Show("Oops!\nOcorreu um erro interno, não foi possivel finalizar a venda.\n o Erro ocorreu no momento de salvar os dados da venda no banco de dados, tente novamente mais tarde", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                    MessageBox.Show("Venda Finalizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(MessageBox.Show("Deseja Enviar um Email para "+lblEmailCliente.Text+" agradecendo o "+cbxClientes.Text+" pela compra?", "Enviar Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    btnEnviarEmail_Click(sender, e);
                }
                    limpaCampos();
                listaVendas();
                tabControl1.SelectedTab=tpVendasRealizadas;
                this.Controls.Clear();
                this.InitializeComponent();
                FrmVendas_Load(sender, e);
                
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                string nomecliente = cbxClientes.Text;
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From=new MailAddress("envioteste51@gmail.com");
                mail.To.Add(lblEmailCliente.Text.ToString());
                mail.Subject="Compra Realizada na XXXX";
                ResXResourceReader resx = new ResXResourceReader("Resources.resx");
                mail.IsBodyHtml=true;
                mail.Body="<p>Olá "+nomecliente+", Muito obrigado por comprar conosco</p> <br/><br/><img src=\"https://static.mundodasmensagens.com/upload/imagens/co/mp/compra002-cke.jpg\" />";
                SmtpServer.Port=587;
                SmtpServer.Credentials=new
                System.Net.NetworkCredential("envioteste51@gmail.com", "EnvioEmail123*");
                SmtpServer.EnableSsl=true;
                SmtpServer.Send(mail);
                MessageBox.Show("Email Enviado com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab=tpVendasRealizadas;
            dgvListaProdutos.Columns["Remover"].Visible=true;

        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(cbxProduto.SelectedValue)>0)
            {
                ProdutoPrecoViewModel preco = new ProdutoPrecoViewModel();
                preco=vendasRepository.getProdutoCodigo((int)cbxProduto.SelectedValue);
                txbPrecoVenda.Text=preco.PrecoVenda.ToString();
            }
        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(cbxClientes.SelectedValue)>0)
            {
                EmailClienteViewModel Email = new EmailClienteViewModel();
                Email=vendasRepository.getEmailCliente((int)cbxClientes.SelectedValue);
                lblEmailCliente.Text=Email.Email;
            }
        }

        private void dgvListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0)
                return;
            if(dgvListaProdutos.Columns[e.ColumnIndex].Name=="Remover")
            {
                decimal valoritem = Convert.ToDecimal(dgvListaProdutos.Rows[e.RowIndex].Cells["Total"].Value);
                decimal totalLabel = Convert.ToDecimal(lblValorTotal.Text);
                lblValorTotal.Text=Convert.ToString(totalLabel-valoritem);
                dgvListaProdutos.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void txbPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            tcv.PermiteDecimal(sender, e, ',');
        }

        private void txbPrecoVenda_Leave(object sender, EventArgs e)
        {
            if(txbPrecoVenda.Text.Trim().TrimEnd().Length!=0)
                txbPrecoVenda.Text=Convert.ToDecimal(txbPrecoVenda.Text).ToString("N2");
        }

        #region Medotos
        public void limpaCampos()
        {
               
            lblValorTotal.Text="0,00";
            cbxClientes.SelectedValue=0;
            cbxProduto.SelectedIndex=0;
            lblEmailCliente.Text="";
            numQtd.Value=1;
            txbDtVenda.Clear();

        }
        void listaVendas()
        {
           dgvVendasRealizadas.DataSource=vendasRepository.ListaVendasRealizadas(txbPesqCliente.Text, dtpInicio.Value, dtpFim.Value);

        }
        #endregion
    }
}
