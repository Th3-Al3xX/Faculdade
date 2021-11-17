using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_01_02.Lista_01
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        private decimal _altura;
        public decimal Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
    }
}
