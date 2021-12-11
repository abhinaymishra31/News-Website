using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;

public partial class Pnb : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd, cmd1;
    SqlDataReader dr;
    String umail = "";
    int uidd;
    int feed = 0;
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Open();
            string query = "select top 6 * from tbl_news category=Regional AND subcategory=Maharashtra order by date desc";

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            con.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {


        var i = ((Button)sender).NamingContainer;
        Button bt = (Button)i.FindControl("Button1");
        Response.Write("<script>alert();</script>");
        if ((Session["username"] == null))
        {
            bt.Enabled = true;
        }

    }



    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {



        if (e.CommandName == "Comment") // check command is cmd_delete
        {
            if ((Session["username"] != null))
            {


                umail = Session["username"].ToString();
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                con.Open();

                string se = "select uid from TBL_USER where email='" + umail + "'";
                //SqlDataReader dr;
                cmd = new SqlCommand(se, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    uidd = int.Parse(dr["uid"].ToString());




                }
                dr.Close();

                string n = ((Label)e.Item.FindControl("Label3")).Text;

                string c = ((TextBox)e.Item.FindControl("TextBox1")).Text;

                string query = "insert into comment(nid,uid,comment) values ('" + n + "','" + uidd + "','" + c + "')";
                cmd1 = new SqlCommand(query, con);
                cmd1.ExecuteNonQuery();

                con.Close();




            }
        }

        if (e.CommandName == "Share")
        {
            if ((Session["username"] != null))
            {

                TextBox txtBox = e.Item.FindControl("TextBox2") as TextBox;
                txtBox.Visible = true;
                ImageButton bt = e.Item.FindControl("ImageButton3") as ImageButton;
                bt.Visible = true;
            }
        }
        if (e.CommandName == "Mail")
        {
            TextBox txtBox = e.Item.FindControl("TextBox2") as TextBox;


            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string msg = string.Empty;

            try
            {

                con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                con.Open();
                string news = ""; string description = "";
                string n = ((Label)e.Item.FindControl("Label3")).Text;
                string sq = "select news,description from tbl_news where nid ='" + n + "'";
                //SqlDataReader dr;
                cmd = new SqlCommand(sq, con);
                SqlDataReader dr1;
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    news = dr1["news"].ToString();
                    description = dr1["description"].ToString();
                    dr1.Close();
                }
                con.Close();

                MailAddress fromAddress = new MailAddress("newswebsiteips@gmail.com");
                message.From = fromAddress;
                message.To.Add(txtBox.Text);
                string un = (Session["username"]).ToString();
                message.Subject = "News shared to you by---" + un;
                message.IsBodyHtml = true;
                message.Body = "News Title-" + news + "            " + "News Body-" + description + "             " + "Thank You for reading";

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
        if (e.CommandName == "Feedback")
        {
            RadioButtonList rt = e.Item.FindControl("RadioButtonList1") as RadioButtonList;
            string f = rt.SelectedValue;
            int cf = Convert.ToInt32(f);
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Open();
            string n = ((Label)e.Item.FindControl("Label3")).Text;

            string sq = "select feedback from tbl_news where nid ='" + n + "'";
            //SqlDataReader dr;
            cmd = new SqlCommand(sq, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                feed = int.Parse(dr["feedback"].ToString());
            }
            dr.Close();
            feed = (feed + cf) / 2;
            string qr = "update tbl_news set feedback='" + feed + "' where nid='" + n + "'";
            cmd1 = new SqlCommand(qr, con);
            cmd1.ExecuteNonQuery();

            con.Close();


        }

    }




    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item ||
           e.Item.ItemType == ListItemType.AlternatingItem)
        {
            if ((Session["username"] != null))
            {
                ImageButton bt1 = e.Item.FindControl("ImageButton2") as ImageButton;
                bt1.Enabled = true;

                umail = Session["username"].ToString();
                TextBox txtBox = e.Item.FindControl("TextBox1") as TextBox;
                txtBox.ReadOnly = false;

                Button bt = e.Item.FindControl("Button1") as Button;
                bt.Enabled = true;
            }
        }
    }
}


