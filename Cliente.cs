using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastrarCliente
{
    public class Cliente
    {
        public int Id;
        public string Nome;
        public string Sobrenome;
        public string Email;
        public string Ddd;
        public string Telefone;
        public string Sexo;
        public string Escolaridade;
        public DateTime DataNascimento;

        public bool Cadastrar(ref List<Cliente> lista)
        {
            int totalantes = lista.Count;

            lista.Add(this);

            int totaldepois = lista.Count;
            if (totaldepois > totalantes)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
