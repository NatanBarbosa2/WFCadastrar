
namespace WFCadastrarCliente
{
    partial class FormCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.lblSobreNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblEscolaridade = new System.Windows.Forms.Label();
            this.cbxEscolaridade = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Location = new System.Drawing.Point(279, 32);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(175, 23);
            this.txtSobreNome.TabIndex = 3;
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoSize = true;
            this.lblSobreNome.Location = new System.Drawing.Point(279, 13);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.Size = new System.Drawing.Size(71, 15);
            this.lblSobreNome.TabIndex = 2;
            this.lblSobreNome.Text = "Sobrenome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 81);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(13, 171);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(224, 23);
            this.txtTelefone.TabIndex = 7;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 152);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(54, 15);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rdbFeminino);
            this.gbxSexo.Controls.Add(this.rdbMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(299, 142);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(155, 105);
            this.gbxSexo.TabIndex = 8;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo:";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(16, 68);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(75, 19);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(16, 29);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblEscolaridade
            // 
            this.lblEscolaridade.AutoSize = true;
            this.lblEscolaridade.Location = new System.Drawing.Point(13, 220);
            this.lblEscolaridade.Name = "lblEscolaridade";
            this.lblEscolaridade.Size = new System.Drawing.Size(76, 15);
            this.lblEscolaridade.TabIndex = 9;
            this.lblEscolaridade.Text = "Escolaridade:";
            // 
            // cbxEscolaridade
            // 
            this.cbxEscolaridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEscolaridade.FormattingEnabled = true;
            this.cbxEscolaridade.Items.AddRange(new object[] {
            "Ensino Fundamental ",
            "Ensino Médio ",
            "Ensino Técnico",
            "Ensino Superior Incompleto",
            "Ensino Superior",
            "Pós-Graduação"});
            this.cbxEscolaridade.Location = new System.Drawing.Point(13, 238);
            this.cbxEscolaridade.Name = "cbxEscolaridade";
            this.cbxEscolaridade.Size = new System.Drawing.Size(224, 23);
            this.cbxEscolaridade.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(364, 351);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 33);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(279, 81);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(117, 15);
            this.lblDataNascimento.TabIndex = 12;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(279, 99);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDataNascimento.Size = new System.Drawing.Size(175, 23);
            this.dtpDataNascimento.TabIndex = 13;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 410);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbxEscolaridade);
            this.Controls.Add(this.lblEscolaridade);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.lblSobreNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.Label lblSobreNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblEscolaridade;
        private System.Windows.Forms.ComboBox cbxEscolaridade;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
    }
}