using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Configuration;
using System.Net.Mail;
using System.Net;
public partial class Default4 : System.Web.UI.Page
{ 
     SqlConnection con;
    SqlCommand cmd;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    
   
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        //con.Open();
        try
        {

            con.Open();
            cmd = new SqlCommand("select * from editor_details where email='" + txtuser_name.Text + "' and password ='" + txtpassword.Text + "'and expestatus != 2", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                Response.Write("Login successful");
                dr.Close();
                SqlCommand cmd1 = new SqlCommand("select * from editor_details where email='" + txtuser_name.Text + "' and password ='" + txtpassword.Text + "'", con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.HasRows == false)
                {
                    Response.Write("There is no information of this Customer Form Number");

                }
                else
                {

                    //    Response.Cookies["auth"]["username"] = TextBox1.Text;
                    //    Response.Cookies["auth"]["password"] = TextBox2.Text;
                    //    Response.Cookies["auth"].Expires = DateTime.Now.AddDays(2);
                    //    Session["username"] = "admin";

                    //    Response.Write("Welcome" + Session["username"]);
                    //    Label1.Text = "admin";
                    //    Response.Redirect("~/Default.aspx");
                    Response.Write("Successfully logged in");
                    Session["edusername"] = txtuser_name.Text;
                    Response.Redirect("editor after login.aspx");
                    Label Label1 = (Label)Page.Master.FindControl("Label1");
                    Label1.Visible = true;
                    Label1.Text = "Welcome editor" + "     " + Convert.ToString(Session["edusername"]);
               

                }
            }
            else
            {
                Response.Write("Failedddd");
            }
        }
        catch (SqlException es)
        {
            Response.Write(es.Message);
        }
        finally
        {
            con.Close();
        }
    }


    protected void btnfp_Click(object sender, EventArgs e)
    {
         con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        con.Open();
        cmd = new SqlCommand("select * from editor_details where email='" + txtuser_name.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string msg = string.Empty;
            string pwd = dr["password"].ToString();
            try
            {
                MailAddress fromAddress = new MailAddress("newswebsiteips@gmail.com");
                message.From = fromAddress;
                message.To.Add(txtuser_name.Text);//check this mail id..here write that text box name.tex
                message.Subject = "Your  Password:";
                message.IsBodyHtml = true;
                message.Body = pwd;
                smtpClient.Host = "smtp.gmail.com";   // We use gmail as our smtp client
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("newswebsiteips@gmail.com", "9795246508");

                smtpClient.Send(message);
                msg = "Successful<BR>";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        con.Open();
        cmd = new SqlCommand("select * from editor_details where email='" + txtuser_name.Text + "' and password ='" + txtpassword.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            
            Response.Cookies["edauth"]["edusername"] = txtuser_name.Text;
            Response.Cookies["edauth"]["edpassword"] = txtpassword.Text;
            Response.Cookies["edauth"].Expires = DateTime.Now.AddDays(2);

        }
    }
}
