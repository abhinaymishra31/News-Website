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

public partial class _Default : System.Web.UI.Page
{
    SqlCommand cmd;
    
    SqlConnection con;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //protected void btnsignup_Click(object sender, EventArgs e)
    //{
    //    connect();
    //    registration();


    //}

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

    public void registration()
    {


        string str1 = country.SelectedValue;
        string str2 = state.SelectedValue;
        string strname = PhotoUpload.FileName.ToString();
        PhotoUpload.PostedFile.SaveAs(Server.MapPath("~/img/") + strname);


        string query = "insert into tbl_user(fname,lname,dob,email,mob,photo,country,state,pin,password) values ('" + txtfname.Text + "','" + txtlname.Text + "','" + txtdob.Text + "','" + txtemail.Text + "','" + txtmob.Text + "','" + strname + "','" + country.SelectedValue + "','" + state.SelectedValue + "','" + txtpin.Text + "','" + txtpassword.Text + "')";

        cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();
       
        con.Close();
        Response.Write("<script>alert('Data inserted successfully')</script>");
    }
    protected void btnsignup_Click1(object sender, EventArgs e)
    {
        connect();
        registration();
    }
}