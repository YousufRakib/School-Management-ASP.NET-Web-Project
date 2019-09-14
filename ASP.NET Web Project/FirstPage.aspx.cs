using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FirstPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUpLogIn.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}