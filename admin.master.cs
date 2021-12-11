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

public partial class admin : System.Web.UI.MasterPage
{
    
    SqlCommand cmd;
    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        }
        if ((Session["username"] != null))
        {
            Label Label1 = (Label)Page.Master.FindControl("Label1");
            Label1.Visible = true;
            Label1.Text = "welcome  " + Convert.ToString(Session["username"]);
            Button5.Visible = true;
        }
        if ((Session["edusername"] != null))
        {
            Button5.Visible = true;
        }
        if ((Session["edusername"] != null))
        {
            Label Label1 = (Label)Page.Master.FindControl("Label1");
            Label1.Visible = true;
            Label1.Text = "welcome editor "+"  " + Convert.ToString(Session["edusername"]);
            Button5.Visible = true;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
    
    }
    
    protected void Button5_Click(object sender, EventArgs e)
    {
        Session.Remove("username");
            Session.Remove("edusername");
         
            Response.Redirect("Default.aspx");
        }

   
}
   

