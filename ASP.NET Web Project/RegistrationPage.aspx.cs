using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class RegistrationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["DatabaseCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        using (conn)
        {
            string Fname = TxtFName.Text;
            string Lname = TxtLName .Text;
            int Sid = Convert.ToInt32(TxtSId.Text);
            int Classname = Convert.ToInt32(TxtCName.Text);
            string Uname = TxtUName.Text;
            string Email = TxtEmail.Text;
            string Password = TxtPassword.Text;
            int Mobile = Convert.ToInt32(TxtMobile.Text);
            int Age = Convert.ToInt32(TxtAge.Text);
            string Address = TxtAddress.Text;

            SqlCommand cmd = new SqlCommand("Insert into RegPage(firstName, lastName, studentId, className,userName,email,password,mobile,age,presentAddress) values(@Fname,@Lname,@Sid,@Classname,@Uname,@Email,@Password,@Mobile,@Age,@Address)", conn);
            cmd.Parameters.Add(new SqlParameter("@Fname",Fname));
            cmd.Parameters.Add(new SqlParameter("@Lname", Lname));
            cmd.Parameters.Add(new SqlParameter("@Sid", Sid));
            cmd.Parameters.Add(new SqlParameter("@Classname", Classname));
            cmd.Parameters.Add(new SqlParameter("@Uname", Uname));
            cmd.Parameters.Add(new SqlParameter("@Email", Email));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Parameters.Add(new SqlParameter("@Mobile", Mobile));
            cmd.Parameters.Add(new SqlParameter("@Age", Age));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.ExecuteNonQuery(); 

        }
        Response.Redirect("LogInPage.aspx");

         
    }
}