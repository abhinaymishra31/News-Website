using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class latestnews : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Open();
            string query = "select * from tbl_news";
            SqlDataReader dr;
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        TextBox comment = GridView1.Rows[e.RowIndex].FindControl("txtcomment") as TextBox;
        Label id = GridView1.Rows[e.RowIndex].FindControl("ID") as Label;

        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
        {
            con.Open();


            //string str = "select * from cus_detail where E_MAIL_ID= @email";

          //  SqlCommand com = new SqlCommand("insert into tbl_news (comment) values ('" + txtcomment.Text + "')", con);
            SqlCommand com = new SqlCommand("update[tbl_news]  set comment=@comment where ID=@id", con);

            com.Parameters.AddWithValue("@comment", comment);
            com.Parameters.AddWithValue("@id", id);


            com.ExecuteNonQuery();

            GridView1.EditIndex = -1;


            con.Close();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        //Response.Write("<script> alert('successfull') </script>");
        int Index = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
        TextBox TxtComment = (TextBox)GridView1.Rows[Index].FindControl("txtcomment");
        Label ii = (Label)GridView1.Rows[Index].FindControl("ID");
        string s = ii.Text;
        int i = Int32.Parse(s);
        string str = TxtComment.Text;
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        con.Open();
        cmd = new SqlCommand("update tbl_news set comment='" + TxtComment.Text + "' where id='" + i + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script> alert('" + TxtComment.Text + "') </script>");
    }
}






        // string status ="Approved";
        ////TextBox status = GridView1.Rows[e.RowIndex].FindControl("TextBox10") as TextBox;
       
        //Label email1 = GridView2.Rows[e.RowIndex].FindControl("Label1") as Label;


        //using (SqlConnection con = new SqlConnection(cs))
        //{
        //    con.Open();


        //    //string str = "select * from cus_detail where E_MAIL_ID= @email";

        //    SqlCommand com = new SqlCommand("update[partner_web_detail]  set STATUS=@status where E_MAIL_ID=@e_id", con);

        //    com.Parameters.AddWithValue("@status", status);
        //    com.Parameters.AddWithValue("@e_id", email1.Text);
           
           
        //        com.ExecuteNonQuery();
                
        //        GridView2.EditIndex = -1;
            
            
        //     con.Close(); 
        //}
        