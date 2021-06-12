
namespace UI.Forms.Vendas
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrecoVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaProdutos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorTotalTexto = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpVendas = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDtVenda = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbCodVenda = new System.Windows.Forms.TextBox();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.panelProdutosAdd = new System.Windows.Forms.Panel();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.tpVendasRealizadas = new System.Windows.Forms.TabPage();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPesqCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVendasRealizadas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpVendas.SuspendLayout();
            this.panelProdutosAdd.SuspendLayout();
            this.tpVendasRealizadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // cbxProduto
            // 
            this.cbxProduto.DisplayMember = "NomeProduto";
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(9, 15);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(216, 21);
            this.cbxProduto.TabIndex = 2;
            this.cbxProduto.ValueMember = "Codigo";
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // numQtd
            // 
            this.numQtd.Location = new System.Drawing.Point(231, 16);
            this.numQtd.Name = "numQtd";
            this.numQtd.ReadOnly = true;
            this.numQtd.Size = new System.Drawing.Size(62, 20);
            this.numQtd.TabIndex = 5;
            this.numQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade:";
            // 
            // txbPrecoVenda
            // 
            this.txbPrecoVenda.Location = new System.Drawing.Point(299, 16);
            this.txbPrecoVenda.MaxLength = 10;
            this.txbPrecoVenda.Name = "txbPrecoVenda";
            this.txbPrecoVenda.Size = new System.Drawing.Size(83, 20);
            this.txbPrecoVenda.TabIndex = 7;
            this.txbPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecoVenda_KeyPress);
            this.txbPrecoVenda.Leave += new System.EventHandler(this.txbPrecoVenda_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço de venda:";
            // 
            // dgvListaProdutos
            // 
            this.dgvListaProdutos.AllowUserToAddRows = false;
            this.dgvListaProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(235)))), ((int)(((byte)(228)))));
            this.dgvListaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutos.Location = new System.Drawing.Point(19, 107);
            this.dgvListaProdutos.Name = "dgvListaProdutos";
            this.dgvListaProdutos.ReadOnly = true;
            this.dgvListaProdutos.Size = new System.Drawing.Size(446, 192);
            this.dgvListaProdutos.TabIndex = 10;
            this.dgvListaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProdutos_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lista de Produtos";
            // 
            // lblValorTotalTexto
            // 
            this.lblValorTotalTexto.AutoSize = true;
            this.lblValorTotalTexto.Location = new System.Drawing.Point(12, 313);
            this.lblValorTotalTexto.Name = "lblValorTotalTexto";
            this.lblValorTotalTexto.Size = new System.Drawing.Size(97, 13);
            this.lblValorTotalTexto.TabIndex = 12;
            this.lblValorTotalTexto.Text = "Valor total à Pagar:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblValorTotal.Location = new System.Drawing.Point(115, 313);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(35, 15);
            this.lblValorTotal.TabIndex = 13;
            this.lblValorTotal.Text = "0,00";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpVendas);
            this.tabControl1.Controls.Add(this.tpVendasRealizadas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 371);
            this.tabControl1.TabIndex = 15;
            // 
            // tpVendas
            // 
            this.tpVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpVendas.Controls.Add(this.label7);
            this.tpVendas.Controls.Add(this.txbDtVenda);
            this.tpVendas.Controls.Add(this.lblEmailCliente);
            this.tpVendas.Controls.Add(this.label6);
            this.tpVendas.Controls.Add(this.btnCancelar);
            this.tpVendas.Controls.Add(this.txbCodVenda);
            this.tpVendas.Controls.Add(this.label2);
            this.tpVendas.Controls.Add(this.lblValorTotal);
            this.tpVendas.Controls.Add(this.lblValorTotalTexto);
            this.tpVendas.Controls.Add(this.cbxClientes);
            this.tpVendas.Controls.Add(this.label5);
            this.tpVendas.Controls.Add(this.dgvListaProdutos);
            this.tpVendas.Controls.Add(this.panelProdutosAdd);
            this.tpVendas.Controls.Add(this.btnFinalizarVenda);
            this.tpVendas.Controls.Add(this.btnEnviarEmail);
            this.tpVendas.Location = new System.Drawing.Point(4, 22);
            this.tpVendas.Name = "tpVendas";
            this.tpVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tpVendas.Size = new System.Drawing.Size(491, 345);
            this.tpVendas.TabIndex = 0;
            this.tpVendas.Text = "Vender";
            this.tpVendas.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Data da Venda:";
            // 
            // txbDtVenda
            // 
            this.txbDtVenda.Enabled = false;
            this.txbDtVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDtVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDtVenda.Location = new System.Drawing.Point(355, 21);
            this.txbDtVenda.Name = "txbDtVenda";
            this.txbDtVenda.Size = new System.Drawing.Size(128, 20);
            this.txbDtVenda.TabIndex = 20;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(58, 5);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(126, 13);
            this.lblEmailCliente.TabIndex = 19;
            this.lblEmailCliente.Text = "envioteste51@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo da Venda:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::UI.Properties.Resources.Cancelar20px;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(226, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 29);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar venda";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbCodVenda
            // 
            this.txbCodVenda.Enabled = false;
            this.txbCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCodVenda.Location = new System.Drawing.Point(260, 21);
            this.txbCodVenda.Name = "txbCodVenda";
            this.txbCodVenda.Size = new System.Drawing.Size(89, 22);
            this.txbCodVenda.TabIndex = 10;
            this.txbCodVenda.Text = "0";
            // 
            // cbxClientes
            // 
            this.cbxClientes.DisplayMember = "Nome";
            this.cbxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(11, 21);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(245, 21);
            this.cbxClientes.TabIndex = 3;
            this.cbxClientes.ValueMember = "Codigo";
            this.cbxClientes.SelectedIndexChanged += new System.EventHandler(this.cbxClientes_SelectedIndexChanged);
            // 
            // panelProdutosAdd
            // 
            this.panelProdutosAdd.Controls.Add(this.label1);
            this.panelProdutosAdd.Controls.Add(this.label4);
            this.panelProdutosAdd.Controls.Add(this.txbPrecoVenda);
            this.panelProdutosAdd.Controls.Add(this.btnAddProduto);
            this.panelProdutosAdd.Controls.Add(this.label3);
            this.panelProdutosAdd.Controls.Add(this.cbxProduto);
            this.panelProdutosAdd.Controls.Add(this.numQtd);
            this.panelProdutosAdd.Location = new System.Drawing.Point(3, 49);
            this.panelProdutosAdd.Name = "panelProdutosAdd";
            this.panelProdutosAdd.Size = new System.Drawing.Size(487, 39);
            this.panelProdutosAdd.TabIndex = 16;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Image = global::UI.Properties.Resources.AdicionarCarrinho20px;
            this.btnAddProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduto.Location = new System.Drawing.Point(388, 14);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(75, 24);
            this.btnAddProduto.TabIndex = 9;
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Image = global::UI.Properties.Resources.Pago20px;
            this.btnFinalizarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(340, 305);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(125, 29);
            this.btnFinalizarVenda.TabIndex = 14;
            this.btnFinalizarVenda.Text = "Finalizar a venda";
            this.btnFinalizarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Image = global::UI.Properties.Resources.EnviarEmail;
            this.btnEnviarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarEmail.Location = new System.Drawing.Point(340, 305);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(125, 29);
            this.btnEnviarEmail.TabIndex = 17;
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Visible = false;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // tpVendasRealizadas
            // 
            this.tpVendasRealizadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpVendasRealizadas.Controls.Add(this.BtnNovaVenda);
            this.tpVendasRealizadas.Controls.Add(this.btnPesquisar);
            this.tpVendasRealizadas.Controls.Add(this.label11);
            this.tpVendasRealizadas.Controls.Add(this.dtpFim);
            this.tpVendasRealizadas.Controls.Add(this.label10);
            this.tpVendasRealizadas.Controls.Add(this.dtpInicio);
            this.tpVendasRealizadas.Controls.Add(this.label9);
            this.tpVendasRealizadas.Controls.Add(this.txbPesqCliente);
            this.tpVendasRealizadas.Controls.Add(this.label8);
            this.tpVendasRealizadas.Controls.Add(this.dgvVendasRealizadas);
            this.tpVendasRealizadas.Location = new System.Drawing.Point(4, 22);
            this.tpVendasRealizadas.Name = "tpVendasRealizadas";
            this.tpVendasRealizadas.Padding = new System.Windows.Forms.Padding(3);
            this.tpVendasRealizadas.Size = new System.Drawing.Size(491, 345);
            this.tpVendasRealizadas.TabIndex = 1;
            this.tpVendasRealizadas.Text = "Vendas Realizadas";
            this.tpVendasRealizadas.UseVisualStyleBackColor = true;
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovaVenda.Image = global::UI.Properties.Resources.FinalizarVenda20px;
            this.BtnNovaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovaVenda.Location = new System.Drawing.Point(7, 28);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(106, 23);
            this.BtnNovaVenda.TabIndex = 9;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            this.BtnNovaVenda.Click += new System.EventHandler(this.BtnNovaVenda_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::UI.Properties.Resources.Pesquisar20px;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(400, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(82, 25);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Até o dia:";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(295, 70);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(99, 20);
            this.dtpFim.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Do dia:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(190, 70);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(99, 20);
            this.dtpInicio.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome do Cliente:";
            // 
            // txbPesqCliente
            // 
            this.txbPesqCliente.Location = new System.Drawing.Point(6, 70);
            this.txbPesqCliente.MaxLength = 30;
            this.txbPesqCliente.Name = "txbPesqCliente";
            this.txbPesqCliente.Size = new System.Drawing.Size(178, 20);
            this.txbPesqCliente.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(483, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Vendas Realizadas";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvVendasRealizadas
            // 
            this.dgvVendasRealizadas.AllowUserToAddRows = false;
            this.dgvVendasRealizadas.AllowUserToDeleteRows = false;
            this.dgvVendasRealizadas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVendasRealizadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVendasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendasRealizadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVendasRealizadas.Location = new System.Drawing.Point(3, 98);
            this.dgvVendasRealizadas.Name = "dgvVendasRealizadas";
            this.dgvVendasRealizadas.ReadOnly = true;
            this.dgvVendasRealizadas.Size = new System.Drawing.Size(483, 242);
            this.dgvVendasRealizadas.TabIndex = 0;
            this.dgvVendasRealizadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendasRealizadas_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::UI.Properties.Resources.fundo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 21);
            this.panel1.TabIndex = 16;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 410);
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída de Estoque";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpVendas.ResumeLayout(false);
            this.tpVendas.PerformLayout();
            this.panelProdutosAdd.ResumeLayout(false);
            this.panelProdutosAdd.PerformLayout();
            this.tpVendasRealizadas.ResumeLayout(false);
            this.tpVendasRealizadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasRealizadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPrecoVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.DataGridView dgvListaProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValorTotalTexto;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpVendas;
        private System.Windows.Forms.TabPage tpVendasRealizadas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbPesqCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvVendasRealizadas;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Panel panelProdutosAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbCodVenda;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDtVenda;
    }
}