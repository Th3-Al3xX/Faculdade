using System;
using System.Collections;
using System.Configuration;
using System.Data;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Itens cls = new Itens();
            cls.ItemID = int.Parse(this.txtItem.Text);
            cls.Valor = decimal.Parse(this.txtValor.Text);

            Session.Add("Item", cls);

            Itens cls2 = (Itens)Session["Item"];

        }
    }
}
