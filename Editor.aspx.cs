using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

public partial class Editor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void txthow_TextChanged(object sender, EventArgs e)
    {

    }
    public void SignUp()
    {
        
        string query = "insert into editor_details () values ();";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd = new SqlCommand(query, con);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch(Exception e)
        {
            Response.Write(e.ToString());
        }
    }
    protected void btnregi_Click(object sender, EventArgs e)
    {
        string str;
        if (IsExperienced.SelectedIndex == 0)
        {
            str = PhotoUpload.FileName.ToString();
            PhotoUpload.PostedFile.SaveAs(Server.MapPath("~/img/") + str);
            string qr = "insert into editor_details values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtdob.Text + "','" + category.Text + "','" + subcategory.Text + "'," + txtc_no.Text + ",'" + txteid.Text + "'," + txtadhar.Text + ",0," + txthow.Text + ",'" + txtfrom.Text + "','" + txtpass.Text + "','" + str + "','" + SignUpload.PostedFile.FileName + "')";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            
            con.Open();
            
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Record Inserted 0')</script>");
           // Response.Redirect("~/SignUp.aspx");
        }
        else if (IsExperienced.SelectedIndex == 1)
        {
            string qr = "insert into editor_details (fname,lname,dob,category,subcategory,contact,email,aadhar,expestatus,password,photo,signature) values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtdob.Text + "','" + category.Text + "','"+subcategory.Text+"'," + txtc_no.Text + ",'" + txteid.Text + "'," + txtadhar.Text + ",1,'" + txtpass.Text + "','" + PhotoUpload.PostedFile.FileName + "','" + SignUpload.PostedFile.FileName + "')";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Record Inserted 1')</script>");
          //  Response.Redirect("~/SignUp.aspx");
        }
            
     }
    protected void IsExperienced_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(IsExperienced.SelectedIndex == 0)
        {            
            lblfrom.Visible=true;
            lblhow.Visible=true;
            txtfrom.Visible=true;
            txthow.Visible=true;
            CV_how.Visible = true;
            CV_from.Visible = true;
        }
        else if (IsExperienced.SelectedIndex == 1)
        {
            lblfrom.Visible = false;
            lblhow.Visible = false;
            txtfrom.Visible = false;
            txthow.Visible = false;
            CV_how.Visible = false;
            CV_from.Visible = false;
        }
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtfname.Text = "";
        txtlname.Text = "";
        txtdob.Text = "";
        category.Text = "Select Category";
        txtc_no.Text = "";
        txteid.Text = "";
        txtadhar.Text = "";
        txthow.Text = "";
        txtfrom.Text = "";
        txtpass.Text = "";
        txtcompass.Text = "";
    }
    protected void category_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (category.SelectedValue == "Sport")
        {
            subcategory.Items.Clear();
            subcategory.Items.Add("Select Sub Category");
            subcategory.Items.Add("Cricket");
            subcategory.Items.Add("Football");
            subcategory.Items.Add("Hockey");
            subcategory.Items.Add("Others");
        }
        if (category.SelectedValue == "Sci-Tech")
        {
            subcategory.Items.Clear();
            subcategory.Items.Add("Select Sub Category");
            subcategory.Items.Add("Science");
            subcategory.Items.Add("Technogy");
            subcategory.Items.Add("Agriculture");
            subcategory.Items.Add("Others");
        }
        if (category.SelectedValue == "Life Style")
        {
            subcategory.Items.Clear();
            subcategory.Items.Add("Select Sub Category");
            subcategory.Items.Add("Fashion");
            subcategory.Items.Add("Fitness");
            subcategory.Items.Add("Food");
            subcategory.Items.Add("Others");
        }
        if (category.SelectedValue == "Entertainment")
        {
            subcategory.Items.Clear();
            subcategory.Items.Add("Select Sub Category");
            subcategory.Items.Add("Bollywood");
            subcategory.Items.Add("Hollwoood");
            subcategory.Items.Add("Movie Review");
            subcategory.Items.Add("Others");
        }
        if (category.SelectedValue == "Business")
        {
            subcategory.Items.Clear();
            subcategory.Items.Add("Select Sub Category");
            subcategory.Items.Add("India Business");
            subcategory.Items.Add("Stock Market");
            subcategory.Items.Add("International");
            subcategory.Items.Add("Others");
        }
        if(category.SelectedValue=="Others")
        {
            subcategory.Items.Clear();
            subcategory.Items.Add("Select Sub Category");
            subcategory.Items.Add("Books");
            subcategory.Items.Add("Culture");
            subcategory.Items.Add("Classified");
            subcategory.Items.Add("Others");
        }
    }
    protected void subcategory_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}