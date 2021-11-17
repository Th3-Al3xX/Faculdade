using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace WebApplication3
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Nome"] = "";
            Application["DtNascimento"] = "";
            Application["QteTotalUsuario"] = 0;
            Application["UsuariosOnLine"] = 0;
            Application["AppStart"] = DateTime.Now;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["QteTotalUsuario"] = Convert.ToInt64(Application["QteTotalUsuario"]) + 1;
            Application["UsuariosOnLine"] = Convert.ToInt64(Application["UsuariosOnLine"]) + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["UsuariosOnLine"] = Convert.ToInt64(Application["UsuariosOnLine"]) - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}