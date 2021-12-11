using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
public partial class admin_user : System.Web.UI.Page
{
    public SqlConnection con;
    public SqlCommand cmd,cmd1;
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
        cmd = new SqlCommand("select * from  tbl_user", con);
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

    public int UpdateUserDetails(string fname, string lname, int mob, string country, string state, string pin, string email)
    {
        cmd = new SqlCommand("update tbl_user set fname='" + fname + "',lname='" + lname + "',mob='" + mob + "',country='" + country + "',state='" + state + "',pin='" + pin + "' where email='" + email + "'", con);
        return cmd.ExecuteNonQuery();
    }

    public int DeleteUserDetails(string uid)
    {
        cmd1 = new SqlCommand("delete from comment where uid='"+uid+"'",con);
        cmd1.ExecuteNonQuery();
        cmd = new SqlCommand("delete from tbl_user  where uid='" + uid + "'", con);
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
        TextBox mob = (TextBox)GridView1.Rows[Index].FindControl("mob");
        mob.ReadOnly = false;
        TextBox country = (TextBox)GridView1.Rows[Index].FindControl("country");
        country.ReadOnly = false;
        TextBox state = (TextBox)GridView1.Rows[Index].FindControl("state");
        state.ReadOnly = false;
        TextBox pin = (TextBox)GridView1.Rows[Index].FindControl("pin");
        pin.ReadOnly = false;

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
        TextBox mob = (TextBox)GridView1.Rows[Index].FindControl("mob");
        mob.ReadOnly = true;
        TextBox country = (TextBox)GridView1.Rows[Index].FindControl("country");
        country.ReadOnly = true;
        TextBox state = (TextBox)GridView1.Rows[Index].FindControl("state");
        state.ReadOnly = true;
        TextBox pin = (TextBox)GridView1.Rows[Index].FindControl("pin");
        pin.ReadOnly = true;
        TextBox email = (TextBox)GridView1.Rows[Index].FindControl("email");
        email.ReadOnly = true;

        Connect();
        //int count = 0;
        //count = db.CountAdminDetails(EditUsernameTextBox.Text);

        int x = 0;
        x = UpdateUserDetails(fname.Text, lname.Text, int.Parse(mob.Text), country.Text, state.Text, pin.Text, email.Text);

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
        TextBox mob = (TextBox)GridView1.Rows[Index].FindControl("mob");
        mob.ReadOnly = true;
        TextBox country = (TextBox)GridView1.Rows[Index].FindControl("country");
        country.ReadOnly = true;
        TextBox state = (TextBox)GridView1.Rows[Index].FindControl("state");
        state.ReadOnly = true;
        TextBox pin = (TextBox)GridView1.Rows[Index].FindControl("pin");
        pin.ReadOnly = true;
        TextBox email = (TextBox)GridView1.Rows[Index].FindControl("email");
        email.ReadOnly = true;
    }

    protected void DeleteUserLinkButton_Click(object sender, EventArgs e)
    {
        int Index = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
        TextBox uid = (TextBox)GridView1.Rows[Index].FindControl("id");
        uid.ReadOnly = true;

        Connect();

        int x = DeleteUserDetails(uid.Text);
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


    protected void brnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SignUp.aspx");
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        btndelnow.Visible = true;
        txtdel.Visible = true;
        DropDownList2.Visible = true;
        GridView1.Visible = true;
        
        
    }
    protected void txtdelnow_Click(object sender, EventArgs e)
    {
        string s = DropDownList2.SelectedItem.Text;
        string qr1 = "delete from comment where " + s + "=" + Convert.ToInt32(txtdel.Text) + "";
        Response.Write("<script>alert('"+s+"')</script>");
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        con.Open();
        cmd1 = new SqlCommand(qr1, con);
        cmd1.ExecuteNonQuery();
        string qr = "delete from tbl_user where " + DropDownList2.SelectedItem.Text + "=" + Convert.ToInt32(txtdel.Text) + "";
        Response.Write("" + txtdel.Text);
        
        cmd = new SqlCommand(qr, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('Record Deleted')</script>");
        DropDownList2.SelectedItem.Text = "Select";
        DropDownList2.Visible = false;
        txtdel.Visible = false;
        btndelnow.Visible = false;
        
    }

    protected void btnupdate_Click1(object sender, EventArgs e)
    {
       
        DropDownList2.Visible = false;
        txtdel.Visible = false;
        btndelnow.Visible = false;
        GridView1.Visible = true;
        
    }
    
}