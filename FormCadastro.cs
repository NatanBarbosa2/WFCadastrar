using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastrarCliente
{
    public partial class FormCadastro : Form
    {
        public static List<Cliente> Clientes = new List<Cliente>();

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Id = 0;
            cli.Nome = txtNome.Text;
            cli.Sobrenome = txtSobreNome.Text;
            cli.Ddd = txtTelefone.Text.Substring(0, 2);
            cli.Telefone = txtTelefone.Text.Substring(2);
            cli.DataNascimento = dtpDataNascimento.Value;
            cli.Escolaridade
                = cbxEscolaridade.SelectedItem.ToString();

            if (rdbMasculino.Checked == true)
            {
                cli.Sexo = rdbMasculino.Text;
            }
            else if (rdbFeminino.Checked == true)
            {
                cli.Sexo = rdbFeminino.Text;
            }
            bool cadastrou = cli.Cadastrar(ref Clientes);
            DialogResult resp = DialogResult.Yes;
            if (cadastrou == true)
            {
                resp = MessageBox.Show("Cadastro efetuado com sucesso",
                    "OK", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                resp = MessageBox.Show("Cadastro não efetuado!",
                   "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            if (resp == DialogResult.OK)
            {
                FormLista form = new FormLista();
                FormLista.Clientes = FormCadastro.Clientes;
                form.ShowDialog();
            }


        }
    }
}
