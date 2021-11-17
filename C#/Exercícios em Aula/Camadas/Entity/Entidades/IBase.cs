using System;

namespace Util
{
    interface IBase : ICloneable
    {
        int Codigo
        {
            get;
            set;
        }

        Linha Estado
        {
            get;
            set;
        }
    }
}