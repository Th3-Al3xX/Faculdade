using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Entidades
{
    public class Curso : IBase
    {
        private string _decricao;
        public string Decricao
        {
            get { return _decricao; }
            set { _decricao = value; }
        }
        
        private DateTime _dtAbertura;
        public DateTime DtAbertura
        {
            get { return _dtAbertura; }
            set { _dtAbertura = value; }
        }


        #region IBase Members
        private int _codigo;
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        private Linha _estado;
        public Linha Estado
        {
            get
            {
                return this._estado;
            }
            set
            {
                this._estado = value;
            }
        }
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
    }
}
