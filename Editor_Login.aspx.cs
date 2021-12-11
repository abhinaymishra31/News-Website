using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class Editor_Login : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["Name"]!=null)
        {
            Label5.Text = Request.QueryString["Name"];
        }
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        con.Open();
        string query = "select * from editor_details where email ='" + Label5.Text + "'";
        //where email='" + txtemail.Text  + "' and password='" + txtpassword.Text  + "'";
        SqlDataReader dr;
        cmd = new SqlCommand(query, con);
        dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
               
        con.Close();
        entry();

    }

    public void entry()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        con.Open();
        string query = "select * from editor_details where email ='" + Label5.Text + "'";
        SqlDataReader dr;
        cmd = new SqlCommand(query, con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox1.Text = dr["fname"].ToString();
            TextBox2.Text = dr["email"].ToString();
            TextBox3.Text = dr["category"].ToString();
            TextBox4.Text = dr["password"].ToString();
            dr.Close();
        }
        con.Close();
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        txtnews.Visible = true;
        newsphoto.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        connect();
        newsentry();
        
    }

    public int connect()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        con.Open();
        if (con != null && con.State == System.Data.ConnectionState.Closed)
        {
            return 0;
        }
        return 1;
    }

    public void newsentry()
    {


        
        string strname = newsphoto.FileName.ToString();
        newsphoto.PostedFile.SaveAs(Server.MapPath("~/img/") + strname);
        string str="good";


        string query = "insert into tbl_news(photo,news,comment) values ('" + strname + "','" + txtnews.Text + "','"+ str +"')";

        cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();

        con.Close();
        Response.Write("<script>alert('Data inserted successfully')</script>");
    }
}



//SqlConnection cn = new SqlConnection();
//            cn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\AMIT KUMAR MISHRA\Documents\CSS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
//            try
//            {
//                cn.Open();
//                SqlCommand cmd = new SqlCommand("select * from STUDENT_REG where EMAIL_ID_TB='" +USER_NAME_TB.Text  + "' and PASSWORD_TB ='" + PASSWORD_TB.Text + "'", cn);
//                SqlDataReader dr = cmd.ExecuteReader();
//                if (dr.Read() == true)
//                {
//                    MessageBox.Show("Successfull login");
//                    STUDENT_FORM s1 = new STUDENT_FORM();
//                    this.Hide();                   
//                    dr.Close();
//                    SqlCommand cmd1 = new SqlCommand("select * from STUDENT_REG where EMAIL_ID_TB='" + USER_NAME_TB.Text + "' and PASSWORD_TB ='" + PASSWORD_TB.Text + "'", cn);
//                    SqlDataReader dr1 = cmd1.ExecuteReader();
//                    if (dr1.HasRows == false)
//                    {
//                        MessageBox.Show("There is no information of this Customer Form Number", "Informatiom Not Found");

//                    }
//                    else
//                    {                        
//                        while (dr1.Read() == true)
//                        {
//                            MessageBox.Show("Successfull fetched");                     
//                            s1.WELCOME_NAME.Text = dr1.GetString(2).ToString();
//                            s1.EMAIL_ID_TB.Text = dr1.GetString(0).ToString();
//                            s1.PASSWORD_TB.Text = dr1.GetString(1).ToString();
//                            s1.NAME_TB.Text = dr1.GetString(2).ToString();
//                            s1.FATHER_NAME_TB.Text = dr1.GetString(3).ToString();
                            
//                           /* DateTime dt;
//                            dt = dr1.GetDateTime(4);
//                            s1.DOB_DTP.Text = dr1.GetDateTime(4).ToString(); */
//                            DateTime dt;
//                            dt = dr1.GetDateTime(4);
//                            string dat= dr1.GetDateTime(4).ToString();
//                            s1.DATE_TB.Text = dat.Substring(0, 11);
//                            s1.MOB_TB.Text = dr1.GetString(5).ToString();
//                            s1.COURSE_TB.Text = dr1.GetString(6).ToString();

                       
//                            s1.Show();


                            
//                        }
//                    }
                    
                   

//                    //end to auto fill data 

//                }
//                else
//                {
//                    MessageBox.Show("Invalid User Id or Password", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                }
//            }
//            catch (SqlException es)
//            {
//                MessageBox.Show(es.Message);
//            }
//            finally
//            {
//                cn.Close();
//            }