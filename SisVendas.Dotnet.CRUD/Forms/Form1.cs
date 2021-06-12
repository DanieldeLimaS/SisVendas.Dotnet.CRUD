using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.Cadastros;
using UI.Forms.Vendas;

namespace UI.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenuCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmcli = new FrmClientes();
            frmcli.Show();
        }

        private void btnMenuProduto_Click(object sender, EventArgs e)
        {
            FrmProdutos frmprod = new FrmProdutos();
            frmprod.Show();
        }

        private void btnMenuVendas_Click(object sender, EventArgs e)
        {
            FrmVendas frmvenda = new FrmVendas();
            frmvenda.Show();
        }
    }
}
