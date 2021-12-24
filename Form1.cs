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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();
        }

        private void menuItemListar_Click(object sender, EventArgs e)
        {
            FormLista form = new FormLista();
            form.ShowDialog();
        }

        private void menuItemSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
