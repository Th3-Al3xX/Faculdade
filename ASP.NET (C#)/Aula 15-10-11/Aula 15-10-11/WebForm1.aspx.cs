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

namespace Aula_15_10_11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pessoa cls = new Pessoa();
            cls.Nome = this.txtNome.Text;
            cls.Endereco = this.txtEndereco.Text;
            cls.Idade = int.Parse(this.txtIdade.Text);
            cls.SexoID = int.Parse(this.ddlSexo.SelectedItem.Value);
            cls.Sexo = this.ddlSexo.SelectedItem.Text;

            Session.Add("Pessoa", cls);

            Pessoa cls2 = (Pessoa)Session["Pessoa"];

            Response.Write(cls2.Idade.ToString());

            /*Session.Add("Nome", this.txtNome.Text);
            Session.Add("Endereço", this.txtEndereco.Text);
            Session.Add("Idade", Convert.ToInt32(this.txtIdade.Text));
            Session.Add("Sexo", this.ddlSexo.SelectedItem.Text);

            Response.Write(Session["Nome"]);*/
        }
    }
}
