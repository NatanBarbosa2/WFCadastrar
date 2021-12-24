
namespace WFCadastrarCliente
{
    partial class FormLista
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
            if (disposing && (components != null))
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
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEscolaridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDddTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnSobrenome,
            this.clnSexo,
            this.clnEscolaridade,
            this.clnDataNascimento,
            this.clnDddTelefone});
            this.dgvListaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.RowTemplate.Height = 25;
            this.dgvListaClientes.Size = new System.Drawing.Size(715, 295);
            this.dgvListaClientes.TabIndex = 0;
            // 
            // clnId
            // 
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.Width = 50;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            // 
            // clnSobrenome
            // 
            this.clnSobrenome.HeaderText = "SobreNome";
            this.clnSobrenome.Name = "clnSobrenome";
            // 
            // clnSexo
            // 
            this.clnSexo.HeaderText = "Sexo";
            this.clnSexo.Name = "clnSexo";
            // 
            // clnEscolaridade
            // 
            this.clnEscolaridade.HeaderText = "Escolaridade";
            this.clnEscolaridade.Name = "clnEscolaridade";
            // 
            // clnDataNascimento
            // 
            this.clnDataNascimento.HeaderText = "Data Nascimento";
            this.clnDataNascimento.Name = "clnDataNascimento";
            this.clnDataNascimento.Width = 120;
            // 
            // clnDddTelefone
            // 
            this.clnDddTelefone.HeaderText = "DDD/Telefone";
            this.clnDddTelefone.Name = "clnDddTelefone";
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 295);
            this.Controls.Add(this.dgvListaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEscolaridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDddTelefone;
    }
}