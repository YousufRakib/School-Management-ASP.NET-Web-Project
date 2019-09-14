using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentInfo.aspx");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("Location.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactUs.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeacherInfo.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AboutUs.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Management.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Result.aspx");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("Gallery.aspx");
    }
}
