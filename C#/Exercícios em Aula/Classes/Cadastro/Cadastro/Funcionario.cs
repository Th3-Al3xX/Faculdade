using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro
{
    class Funcionario
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private Endereco endereco;

        internal Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public Funcionario()
        {
            this.Codigo = 0;
            this.Nome = "<em branco>";
        }

    }
}
