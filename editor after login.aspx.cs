using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


public partial class editor_after_login : System.Web.UI.Page
{
   
    SqlConnection con;
    SqlCommand cmd,cmd2;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["edusername"] != null)
        {
            Label5.Text =Convert.ToString(Session["edusername"]);
        }
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        con.Open();
        string query = "select * from editor_details where email ='" + Label5.Text + "'";
        //where email='" + txtemail.Text  + "' and password='" + txtpassword.Text  + "'";
        SqlDataReader dr1,dr2;
        cmd = new SqlCommand(query, con);
        dr1 = cmd.ExecuteReader();
        GridView1.DataSource = dr1;
        GridView1.DataBind();
        dr1.Close();
        cmd2 = new SqlCommand(query, con);
        dr2 = cmd2.ExecuteReader();
        GridView2.DataSource = dr2;
        GridView2.DataBind();
        dr2.Close();
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
        DropDownList1.Visible = true;
        if (TextBox3.Text == "Sport")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select Sub Category");
            DropDownList1.Items.Add("Cricket");
            DropDownList1.Items.Add("Football");
            DropDownList1.Items.Add("Hockey");
            DropDownList1.Items.Add("Others");
        }
        if (TextBox3.Text == "Sci-Tech")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select Sub Category");
            DropDownList1.Items.Add("Science");
            DropDownList1.Items.Add("Technogy");
            DropDownList1.Items.Add("Agriculture");
            DropDownList1.Items.Add("Others");
        }
        if (TextBox3.Text == "Life Style")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select Sub Category");
            DropDownList1.Items.Add("Fashion");
            DropDownList1.Items.Add("Fitness");
            DropDownList1.Items.Add("Food");
            DropDownList1.Items.Add("Others");
        }
        if (TextBox3.Text == "Entertainment")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select Sub Category");
            DropDownList1.Items.Add("Bollywood");
            DropDownList1.Items.Add("Hollwoood");
            DropDownList1.Items.Add("Movie Review");
            DropDownList1.Items.Add("Others");
        }
        if (TextBox3.Text == "Business")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select Sub Category");
            DropDownList1.Items.Add("India Business");
            DropDownList1.Items.Add("Stock Market");
            DropDownList1.Items.Add("International");
            DropDownList1.Items.Add("Others");
        }
        if (TextBox3.Text == "Others")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select Sub Category");
            DropDownList1.Items.Add("Books");
            DropDownList1.Items.Add("Culture");
            DropDownList1.Items.Add("Classified");
            DropDownList1.Items.Add("Others");
        }
        sub.Visible = true;
        title.Visible = true;
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
        string str = "";
        string str1 = TextBox3.Text;



        string query = "insert into tbl_news(photo,news,description,comment,category,subcategory) values ('" + strname + "','" + title.Text + "','" + txtnews.Text + "','" + str + "','" + str1 + "','" + DropDownList1.SelectedItem + "')";

        cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();

        con.Close();
        Response.Write("<script>alert('Data inserted successfully')</script>");
    }
    //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (TextBox3.Text == "Sport")
    //    {
    //        DropDownList1.Items.Clear();
    //        DropDownList1.Items.Add("Select Sub Category");
    //        DropDownList1.Items.Add("Cricket");
    //        DropDownList1.Items.Add("Football");
    //        DropDownList1.Items.Add("Hockey");
    //        DropDownList1.Items.Add("Others");
    //    }
    //    if (TextBox3.Text == "Sci-Tech")
    //    {
    //        DropDownList1.Items.Clear();
    //        DropDownList1.Items.Add("Select Sub Category");
    //        DropDownList1.Items.Add("Science");
    //        DropDownList1.Items.Add("Technogy");
    //        DropDownList1.Items.Add("Agriculture");
    //        DropDownList1.Items.Add("Others");
    //    }
    //    if (TextBox3.Text == "Life Style")
    //    {
    //        DropDownList1.Items.Clear();
    //        DropDownList1.Items.Add("Select Sub Category");
    //        DropDownList1.Items.Add("Fashion");
    //        DropDownList1.Items.Add("Fitness");
    //        DropDownList1.Items.Add("Food");
    //        DropDownList1.Items.Add("Others");
    //    }
    //    if (TextBox3.Text == "Entertainment")
    //    {
    //        DropDownList1.Items.Clear();
    //        DropDownList1.Items.Add("Select Sub Category");
    //        DropDownList1.Items.Add("Bollywood");
    //        DropDownList1.Items.Add("Hollwoood");
    //        DropDownList1.Items.Add("Movie Review");
    //        DropDownList1.Items.Add("Others");
    //    }
    //    if (TextBox3.Text == "Business")
    //    {
    //        DropDownList1.Items.Clear();
    //        DropDownList1.Items.Add("Select Sub Category");
    //        DropDownList1.Items.Add("India Business");
    //        DropDownList1.Items.Add("Stock Market");
    //        DropDownList1.Items.Add("International");
    //        DropDownList1.Items.Add("Others");
    //    }
    //    if (TextBox3.Text == "Others")
    //    {
    //        DropDownList1.Items.Clear();
    //        DropDownList1.Items.Add("Select Sub Category");
    //        DropDownList1.Items.Add("Books");
    //        DropDownList1.Items.Add("Culture");
    //        DropDownList1.Items.Add("Classified");
    //        DropDownList1.Items.Add("Others");
    //    }
    //}
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("Editor_Update.aspx");
    }
}