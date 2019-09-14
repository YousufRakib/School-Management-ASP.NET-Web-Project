using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class StudentInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {       
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select firstName,lastName,studentId,email,mobile,age,presentAddress from RegPage where className = 1", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select firstName,lastName,studentId,email,mobile,age,presentAddress from RegPage where className = 2", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select firstName,lastName,studentId,email,mobile,age,presentAddress from RegPage where className = 3", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select firstName,lastName,studentId,email,mobile,age,presentAddress from RegPage where className = 4", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select firstName,lastName,studentId,email,mobile,age,presentAddress from RegPage where className = 5", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Response.Redirect("SDeleteUpdate.aspx");
    }
}