using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

public partial class Editor_Update1 : System.Web.UI.Page
{
    public SqlConnection con;
    public SqlCommand cmd, cmd1;
    public SqlDataReader dr;
    string umail;
    int uidd;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Getalldetails();
        }
    }
    public void Connect()
    {
        //string ConnectionString = "ConfigurationManager.ConnectionStrings["con"].ConnectionString";
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        con.Open();
    }

    public SqlDataReader GetUserDetails()
    {
        if ((Session["username"] != null))
        {
            umail = Session["username"].ToString();
            Response.Write("<script>alert('" + umail + "');</script>");
        }
        Response.Write("<script>alert('" + umail + "');</script>");
        //con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        //con.Open();
        string se = "select id from editor_details where email='" + umail + "'";
        SqlDataReader dr;
        cmd = new SqlCommand(se, con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            uidd = int.Parse(dr["id"].ToString());



        }
        dr.Close();


        cmd1 = new SqlCommand("select * from  editor_details where id=" + uidd + "", con);
        return cmd1.ExecuteReader();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Getalldetails()
    {

        Connect();
        GridView1.DataSource = GetUserDetails();
        GridView1.DataBind();

    }

    public int UpdateEditorDetails(string fname, string lname, string contact, string category, string aadhar, string email)
    {
        Connect();
        cmd = new SqlCommand("update editor_details set fname='" + fname + "',lname='" + lname + "',contact='" + long.Parse(contact) + "',category='" + category + "',aadhar='" + long.Parse(aadhar) + "' where email='" + email + "'", con);
        return (cmd.ExecuteNonQuery());
    }

    protected void EditLinkButton_Click(object sender, EventArgs e)
    {
        int Index = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
        LinkButton EditlinkButton = (LinkButton)GridView1.Rows[Index].FindControl("EditLinkButton");
        EditlinkButton.Visible = false;
        LinkButton UpdatelinkButton = (LinkButton)GridView1.Rows[Index].FindControl("UpdateLinkButton");
        UpdatelinkButton.Visible = true;
        LinkButton CancellinkButton = (LinkButton)GridView1.Rows[Index].FindControl("CancelLinkButton");
        CancellinkButton.Visible = true;

        TextBox fname = (TextBox)GridView1.Rows[Index].FindControl("fname");
        fname.ReadOnly = false;
        TextBox lname = (TextBox)GridView1.Rows[Index].FindControl("lname");
        lname.ReadOnly = false;
        TextBox contact = (TextBox)GridView1.Rows[Index].FindControl("contact");
        contact.ReadOnly = false;
        TextBox category = (TextBox)GridView1.Rows[Index].FindControl("category");
        category.ReadOnly = false;
        TextBox aadhar = (TextBox)GridView1.Rows[Index].FindControl("aadhar");
        aadhar.ReadOnly = false;
        //TextBox pin = (TextBox)GridView1.Rows[Index].FindControl("pin");
        //pin.ReadOnly = true;
        //TextBox email = (TextBox)GridView1.Rows[Index].FindControl("email");
        //email.ReadOnly = false;
        //TextBox country = (TextBox)GridView1.Rows[Index].FindControl("country");
        //country.ReadOnly = false;
        //TextBox state = (TextBox)GridView1.Rows[Index].FindControl("state");
        //state.ReadOnly = false;
        //TextBox pin = (TextBox)GridView1.Rows[Index].FindControl("pin");
        //pin.ReadOnly = false;

    }

    protected void UpdateLinkButton_Click(object sender, EventArgs e)
    {
        //Label label1 = (Label)GridView1.Rows[Index].FindControl("Label1");

        int Index = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
        LinkButton EditlinkButton = (LinkButton)GridView1.Rows[Index].FindControl("EditLinkButton");
        EditlinkButton.Visible = true;
        LinkButton UpdatelinkButton = (LinkButton)GridView1.Rows[Index].FindControl("UpdateLinkButton");
        UpdatelinkButton.Visible = false;
        LinkButton CancellinkButton = (LinkButton)GridView1.Rows[Index].FindControl("CancelLinkButton");
        CancellinkButton.Visible = false;

        TextBox fname = (TextBox)GridView1.Rows[Index].FindControl("fname");
        fname.ReadOnly = true;
        TextBox lname = (TextBox)GridView1.Rows[Index].FindControl("lname");
        lname.ReadOnly = true;
        TextBox contact = (TextBox)GridView1.Rows[Index].FindControl("contact");
        contact.ReadOnly = true;
        TextBox category = (TextBox)GridView1.Rows[Index].FindControl("category");
        category.ReadOnly = true;
        TextBox aadhar = (TextBox)GridView1.Rows[Index].FindControl("aadhar");
        aadhar.ReadOnly = true;
        //TextBox pin = (TextBox)GridView1.Rows[Index].FindControl("pin");
        //pin.ReadOnly = true;
        TextBox email = (TextBox)GridView1.Rows[Index].FindControl("email");
        email.ReadOnly = true;

        Connect();
        //int count = 0;
        //count = db.CountAdminDetails(EditUsernameTextBox.Text);

        int x = 0;
        x = UpdateEditorDetails(fname.Text, lname.Text, contact.Text, category.Text, aadhar.Text, email.Text);

        if (x > 0)
        {
            Response.Write("<script>alert('Updated successfully')</script>");
            Getalldetails();
        }
        else
        {
            Response.Write("<script>alert('can not Updated successfully')</script>");
        }


    }

    protected void CancelLinkButton_Click(object sender, EventArgs e)
    {
        int Index = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
        LinkButton EditlinkButton = (LinkButton)GridView1.Rows[Index].FindControl("EditLinkButton");
        EditlinkButton.Visible = true;
        LinkButton UpdatelinkButton = (LinkButton)GridView1.Rows[Index].FindControl("UpdateLinkButton");
        UpdatelinkButton.Visible = false;
        LinkButton CancellinkButton = (LinkButton)GridView1.Rows[Index].FindControl("CancelLinkButton");
        CancellinkButton.Visible = false;


        TextBox fname = (TextBox)GridView1.Rows[Index].FindControl("fname");
        fname.ReadOnly = true;
        TextBox lname = (TextBox)GridView1.Rows[Index].FindControl("lname");
        lname.ReadOnly = true;
        TextBox contact = (TextBox)GridView1.Rows[Index].FindControl("contact");
        contact.ReadOnly = true;
        TextBox category = (TextBox)GridView1.Rows[Index].FindControl("category");
        category.ReadOnly = true;
        TextBox aadhar = (TextBox)GridView1.Rows[Index].FindControl("aadhar");
        aadhar.ReadOnly = true;
        //TextBox pin = (TextBox)GridView1.Rows[Index].FindControl("pin");
        //pin.ReadOnly = true;
        TextBox email = (TextBox)GridView1.Rows[Index].FindControl("email");
        email.ReadOnly = true;
    }
}