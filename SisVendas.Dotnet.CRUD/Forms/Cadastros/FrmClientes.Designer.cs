
namespace UI.Forms.Cadastros
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::UI.Properties.Resources.Excluir20px;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(395, 41);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(98, 24);
            this.btnDeletar.TabIndex = 26;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::UI.Properties.Resources.Atualizar20px;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(395, 15);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(98, 24);
            this.btnAtualizar.TabIndex = 24;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClientes.Location = new System.Drawing.Point(0, 71);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(768, 250);
            this.dgvClientes.TabIndex = 27;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::UI.Properties.Resources.Salvar20px;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(395, 15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(98, 24);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(290, 17);
            this.txbTelefone.Mask = "(00) 0 0000-9999";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(99, 20);
            this.txbTelefone.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(69, 43);
            this.txbEmail.MaxLength = 150;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(320, 20);
            this.txbEmail.TabIndex = 20;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(69, 17);
            this.txbNome.MaxLength = 45;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(161, 20);
            this.txbNome.TabIndex = 18;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 321);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNome;
    }
}