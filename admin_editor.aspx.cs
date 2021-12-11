using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

public partial class admin_editor : System.Web.UI.Page
{
    public SqlConnection con;
    public SqlCommand cmd, cmd1;
    public SqlDataReader dr;

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
        cmd = new SqlCommand("select * from  editor_details", con);
        return cmd.ExecuteReader();

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

    public int UpdateEditorDetails(string fname, string lname,  string contact, string category, string aadhar, string email)
    {
        Connect();
        cmd = new SqlCommand("update editor_details set fname='" + fname + "',lname='" + lname + "',contact='" + long.Parse(contact) + "',category='"+ category +"',aadhar='"+ long.Parse(aadhar) +"' where email='" + email + "'", con);
        return (cmd.ExecuteNonQuery());
    }

    public int DeleteUserDetails(string id)
    {
        //cmd1 = new SqlCommand("delete from comment where id='" + id + "'", con);
        //cmd1.ExecuteNonQuery();
        cmd = new SqlCommand("delete from editor_details  where id='" + id + "'", con);
        return cmd.ExecuteNonQuery();
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

    protected void DeleteUserLinkButton_Click(object sender, EventArgs e)
    {
        int Index = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
        TextBox id = (TextBox)GridView1.Rows[Index].FindControl("id");
        id.ReadOnly = true;

        Connect();

        int x = DeleteUserDetails(id.Text);
        if (x > 0)
        {
            Response.Write("<script>alert('Deleted successfully')</script>");
            Getalldetails();
        }
        else
        {
            Response.Write("<script>alert('can not Delete successfully')</script>");
        }

    }


    protected void btnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Editor.aspx");
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        btndelnow.Visible = true;
        txtdel.Visible = true;
        DropDownList1.Visible = true;
        GridView1.Visible = true;

    }
    protected void txtdelnow_Click(object sender, EventArgs e)
    {
        //string s = DropDownList1.SelectedItem.Text;
        //string qr1 = "delete from comment where " + s + "=" + Convert.ToInt32(txtdel.Text) + "";
        //Response.Write("<script>alert('" + s + "')</script>");
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        con.Open();
        //cmd1 = new SqlCommand(qr1, con);
        //cmd1.ExecuteNonQuery();
        string qr = "delete from editor_details where " + DropDownList1.SelectedItem.Text + "=" + Convert.ToInt32(txtdel.Text) + "";
        Response.Write("" + txtdel.Text);

        cmd = new SqlCommand(qr, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('Record Deleted')</script>");
        DropDownList1.SelectedItem.Text = "Select";
        DropDownList1.Visible = false;
        txtdel.Visible = false;
        btndelnow.Visible = false;

    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {

        DropDownList1.Visible = false;
        txtdel.Visible = false;
        btndelnow.Visible = false;
        GridView1.Visible = true;

    }
    protected void btnblock_Click(object sender, EventArgs e)
    {
        txtdel.Visible = true;
        DropDownList1.Visible = true;
        btneditblock.Visible = true;
        btndelnow.Visible = false;
        //btnupdatenow.Visible = false;
    }
    protected void btneditblock_Click(object sender, EventArgs e)
    {
        string qr = "";
        if (DropDownList1.Text == "id")
        {
            qr = "update editor_details set expestatus=2 where " + DropDownList1.SelectedItem.Text + "=" + Convert.ToInt32(txtdel.Text) + "";
        }
        else if (DropDownList1.Text == "email" || DropDownList1.Text == "aadhar")
        {
            qr = "update editor_details set expestatus=2 where " + DropDownList1.SelectedItem.Text + "='" + txtdel.Text + "'";
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand(qr, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('Editor Blocked')</script>");
        Response.Redirect("~/admin_editor.aspx");
    }
}