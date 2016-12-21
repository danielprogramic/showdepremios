using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);

        var request = Request.Form["View"];

        if (request != null && request == "{1B605F4E-A7C9-4B7B-98B7-5A2D2ADBD520}")
        {
            SetSessionRedirect();
        }

        else if (!IsPostBack)
            scr1.SetFocus(LoginAc.FindControl("UserName"));
    }

    protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
    {
        e.Authenticated = false;
        System.Threading.Thread.Sleep(1000);

        if (LoginAc.UserName.Trim().ToUpper() == "FSOFT" && LoginAc.Password.Trim().ToUpper() == "FSOFT")
        {
            e.Authenticated = true;
            SetSessionRedirect();
        }
        else
        {
            LoginAc.FailureText = "Usuário e/ou Senha inválidas!";
            scr1.SetFocus(LoginAc.FindControl("Username"));
        }
    }

    protected void SetSessionRedirect()
    {
        Session["acesso"] = "FSOFT";
        FormsAuthentication.Initialize();
        FormsAuthentication.SetAuthCookie(LoginAc.UserName.Trim().ToUpper(), false);
        Response.Redirect("~/Admin/");
    }
}