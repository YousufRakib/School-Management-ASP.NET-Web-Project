using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class Result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;

        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select * from result where PassingYear =2017", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;

        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select * from result where PassingYear =2016", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;

        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select * from result where PassingYear =2015", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;

        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select * from result where PassingYear =2014", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;

        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select * from result where PassingYear =2013", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }
}