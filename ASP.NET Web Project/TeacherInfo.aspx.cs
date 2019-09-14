using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class TeacherInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;
         
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select * from TeacherInfo where EmployeeID =710001663", conn);
             
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;

        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select * from TeacherInfo where EmployeeID =710001677 ", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }
}