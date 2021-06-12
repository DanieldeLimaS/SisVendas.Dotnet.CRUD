
namespace UI.Forms.Cadastros
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.label4 = new System.Windows.Forms.Label();
            this.txbPrecoVenda = new System.Windows.Forms.TextBox();
            this.txbEan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrecoCusto = new System.Windows.Forms.TextBox();
            this.txbNomeProd = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Preço de Venda:";
            // 
            // txbPrecoVenda
            // 
            this.txbPrecoVenda.Location = new System.Drawing.Point(302, 56);
            this.txbPrecoVenda.MaxLength = 10;
            this.txbPrecoVenda.Name = "txbPrecoVenda";
            this.txbPrecoVenda.Size = new System.Drawing.Size(92, 20);
            this.txbPrecoVenda.TabIndex = 3;
            this.txbPrecoVenda.Text = "0,00";
            this.txbPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecoVenda_KeyPress);
            this.txbPrecoVenda.Leave += new System.EventHandler(this.txbPrecoVenda_Leave);
            // 
            // txbEan
            // 
            this.txbEan.Location = new System.Drawing.Point(111, 5);
            this.txbEan.MaxLength = 13;
            this.txbEan.Name = "txbEan";
            this.txbEan.Size = new System.Drawing.Size(283, 20);
            this.txbEan.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Preço de Custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "EAN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome do Produto:";
            // 
            // txbPrecoCusto
            // 
            this.txbPrecoCusto.Location = new System.Drawing.Point(111, 56);
            this.txbPrecoCusto.MaxLength = 10;
            this.txbPrecoCusto.Name = "txbPrecoCusto";
            this.txbPrecoCusto.Size = new System.Drawing.Size(92, 20);
            this.txbPrecoCusto.TabIndex = 2;
            this.txbPrecoCusto.Text = "0,00";
            this.txbPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecoCusto_KeyPress);
            this.txbPrecoCusto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPrecoCusto_KeyUp);
            this.txbPrecoCusto.Leave += new System.EventHandler(this.txbPrecoCusto_Leave);
            // 
            // txbNomeProd
            // 
            this.txbNomeProd.Location = new System.Drawing.Point(111, 31);
            this.txbNomeProd.MaxLength = 150;
            this.txbNomeProd.Name = "txbNomeProd";
            this.txbNomeProd.Size = new System.Drawing.Size(283, 20);
            this.txbNomeProd.TabIndex = 1;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::UI.Properties.Resources.Excluir20px;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(400, 54);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(98, 24);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::UI.Properties.Resources.Atualizar20px;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(400, 28);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(98, 24);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::UI.Properties.Resources.Salvar20px;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(400, 28);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(98, 24);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 80);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(768, 241);
            this.dgvProdutos.TabIndex = 35;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 321);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPrecoVenda);
            this.Controls.Add(this.txbEan);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPrecoCusto);
            this.Controls.Add(this.txbNomeProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(784, 360);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPrecoVenda;
        private System.Windows.Forms.TextBox txbEan;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPrecoCusto;
        private System.Windows.Forms.TextBox txbNomeProd;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}