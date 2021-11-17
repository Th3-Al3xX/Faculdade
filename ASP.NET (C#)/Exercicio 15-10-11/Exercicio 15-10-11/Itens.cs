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

namespace Exercicio_15_10_11
{
    [Serializable]
    public class Itens
    {
        public string ItemID { get; set; }
        public decimal Valor { get; set; }
    }
}
