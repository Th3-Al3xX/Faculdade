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
using Microsoft.VisualBasic;

namespace WebApplication3
{
    public partial class resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblNome.Text = Application["Nome"].ToString();
            this.lblQteTotal.Text = Application["QteTotalUsuario"].ToString();
            this.lblUsarioOnLine.Text = Application["UsuariosOnLine"].ToString();
            this.lblStartApp.Text = Application["AppStart"].ToString();

            Int64 Diferenca = DateTime.Now.Subtract(Convert.ToDateTime(Application["DtNascimento"])).Ticks;
            if (new DateTime(Diferenca).Month != 0)
            {
                this.lblIdade.Text = (new DateTime(Diferenca).Year - 1).ToString();
            }
            else
            {
                this.lblIdade.Text = (new DateTime(Diferenca).Year).ToString();
            }
        }
    }
}
