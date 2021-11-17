using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro
{
    class Endereco
    {
        private string rua;
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public Endereco()
        {
            this.Rua = "<em branco>";
            this.numero = 0;
        }
            

    }
}
