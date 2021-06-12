
namespace UI.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMenuCliente = new System.Windows.Forms.Button();
            this.btnMenuProduto = new System.Windows.Forms.Button();
            this.btnMenuVendas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuCliente
            // 
            this.btnMenuCliente.FlatAppearance.BorderSize = 0;
            this.btnMenuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCliente.Image = global::UI.Properties.Resources.AdicionarCliente;
            this.btnMenuCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuCliente.Location = new System.Drawing.Point(113, 13);
            this.btnMenuCliente.Name = "btnMenuCliente";
            this.btnMenuCliente.Size = new System.Drawing.Size(179, 77);
            this.btnMenuCliente.TabIndex = 0;
            this.btnMenuCliente.Text = "Cadastro Clientes";
            this.btnMenuCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuCliente.UseVisualStyleBackColor = true;
            this.btnMenuCliente.Click += new System.EventHandler(this.btnMenuCliente_Click);
            // 
            // btnMenuProduto
            // 
            this.btnMenuProduto.FlatAppearance.BorderSize = 0;
            this.btnMenuProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuProduto.Image")));
            this.btnMenuProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuProduto.Location = new System.Drawing.Point(298, 13);
            this.btnMenuProduto.Name = "btnMenuProduto";
            this.btnMenuProduto.Size = new System.Drawing.Size(182, 77);
            this.btnMenuProduto.TabIndex = 1;
            this.btnMenuProduto.Text = "Cadastro Produtos";
            this.btnMenuProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuProduto.UseVisualStyleBackColor = true;
            this.btnMenuProduto.Click += new System.EventHandler(this.btnMenuProduto_Click);
            // 
            // btnMenuVendas
            // 
            this.btnMenuVendas.FlatAppearance.BorderSize = 0;
            this.btnMenuVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuVendas.Image")));
            this.btnMenuVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuVendas.Location = new System.Drawing.Point(486, 13);
            this.btnMenuVendas.Name = "btnMenuVendas";
            this.btnMenuVendas.Size = new System.Drawing.Size(186, 77);
            this.btnMenuVendas.TabIndex = 2;
            this.btnMenuVendas.Text = "Saidas de Estoque";
            this.btnMenuVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuVendas.UseVisualStyleBackColor = true;
            this.btnMenuVendas.Click += new System.EventHandler(this.btnMenuVendas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnMenuVendas);
            this.panel1.Controls.Add(this.btnMenuProduto);
            this.panel1.Controls.Add(this.btnMenuCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 105);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UI.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuCliente;
        private System.Windows.Forms.Button btnMenuProduto;
        private System.Windows.Forms.Button btnMenuVendas;
        private System.Windows.Forms.Panel panel1;
    }
}