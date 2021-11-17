using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coleções
{
    public class Livro
    {
        #region Atributos.
        private string _titulo;
        private string _autor;
        #endregion

        #region Métodos.
        public string GetTitulo()
        {
            return this._titulo;
        }

        public void SetTitulo(string pTitulo)
        {
            this._titulo = pTitulo;
        }

        public string GetAutor()
        {
            return this._autor;
        }

        public void SetAutor(string pAutor)
        {
            this._autor = pAutor;
        }
        #endregion
    }
}
