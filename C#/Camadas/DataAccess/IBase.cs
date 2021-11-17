using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    interface IBase
    {
        void Insert();
        void Update();
        void Delete();
        void GetEntity();
    }
}
