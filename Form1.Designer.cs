
namespace WFCadastrarCliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuItemCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFundoPrincipal = new System.Windows.Forms.Panel();
            this.mnsMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuPrincipal
            // 
            this.mnsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadastrar,
            this.menuItemListar,
            this.menuItemSair});
            this.mnsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuPrincipal.Name = "mnsMenuPrincipal";
            this.mnsMenuPrincipal.Size = new System.Drawing.Size(500, 24);
            this.mnsMenuPrincipal.TabIndex = 0;
            // 
            // menuItemCadastrar
            // 
            this.menuItemCadastrar.Name = "menuItemCadastrar";
            this.menuItemCadastrar.Size = new System.Drawing.Size(69, 20);
            this.menuItemCadastrar.Text = "Cadastrar";
            this.menuItemCadastrar.Click += new System.EventHandler(this.menuItemCadastrar_Click);
            // 
            // menuItemListar
            // 
            this.menuItemListar.Name = "menuItemListar";
            this.menuItemListar.Size = new System.Drawing.Size(47, 20);
            this.menuItemListar.Text = "Listar";
            this.menuItemListar.Click += new System.EventHandler(this.menuItemListar_Click);
            // 
            // menuItemSair
            // 
            this.menuItemSair.Name = "menuItemSair";
            this.menuItemSair.Size = new System.Drawing.Size(38, 20);
            this.menuItemSair.Text = "Sair";
            this.menuItemSair.Click += new System.EventHandler(this.menuItemSair_Click);
            // 
            // pnlFundoPrincipal
            // 
            this.pnlFundoPrincipal.BackgroundImage = global::WFCadastrarCliente.Properties.Resources.peixe_cardume_oceano_mar;
            this.pnlFundoPrincipal.Location = new System.Drawing.Point(0, 27);
            this.pnlFundoPrincipal.Name = "pnlFundoPrincipal";
            this.pnlFundoPrincipal.Size = new System.Drawing.Size(501, 265);
            this.pnlFundoPrincipal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 292);
            this.Controls.Add(this.pnlFundoPrincipal);
            this.Controls.Add(this.mnsMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsMenuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.mnsMenuPrincipal.ResumeLayout(false);
            this.mnsMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuItemListar;
        private System.Windows.Forms.ToolStripMenuItem menuItemSair;
        private System.Windows.Forms.Panel pnlFundoPrincipal;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
    }
}

