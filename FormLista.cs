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
    public partial class FormLista : Form
    {
        public static List<Cliente> Clientes = new List<Cliente>();

        public FormLista()
        {
            InitializeComponent();
        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            foreach (Cliente c in Clientes)
            {
                string[] dados = new string[7];
                dados[0] = c.Id.ToString();
                dados[1] = c.Nome;
                dados[2] = c.Sobrenome;
                dados[3] = c.Sexo;
                dados[4] = c.Escolaridade;
                dados[5] = c.DataNascimento.ToShortDateString();
                dados[6] = "(" + c.Ddd + ") " + c.Telefone;

                dgvListaClientes.Rows.Add(dados);

            }
        }
    }
}
