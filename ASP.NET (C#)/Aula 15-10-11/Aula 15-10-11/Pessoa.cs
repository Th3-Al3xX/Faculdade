using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Aula_15_10_11
{
    [Serializable]
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public int SexoID { get; set; }
        public string Sexo { get; set; }
    }
}
