using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class LogInPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["IsLoggedIn"] = "No";
         
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = uname.Text;
        string Password = password.Text;
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select * from RegPage where userName=@username AND password=@Password", conn);
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            if (i == 1)
            {
                Session["IsLoggedIn"] = "yes";
                Session["AccountType"] = "admin";

                  
            }
        }
        Response.Redirect("HomePage.aspx");

    }
}