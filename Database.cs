using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



    public class Database
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public void Connect()
        {
            //string ConnectionString = "ConfigurationManager.ConnectionStrings["con"].ConnectionString";
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Open();
        }
        public int InsertNewUser(String UserName, String FirstName, String LastName, long PhoneNumber, String Email, String Password)
        {
            SqlCommand count_cmd = new SqlCommand("select  count(*) from User_details where Username='" + UserName + "'", con);
            int x = 0;
            x = Convert.ToInt32(count_cmd.ExecuteScalar());

            if (x == 1)
            {
                return 0;
            }
            else
            {
                string insert_cmd = "insert into User_details values('" + UserName + "','" + FirstName + "','" + LastName + "'," + PhoneNumber + ",'" + Email + "','" + Password + "',0)";
                SqlCommand cmd = new SqlCommand(insert_cmd, con);
                return cmd.ExecuteNonQuery();

            }

        }
        public int LogInUser(String UserName, String Password)
        {
            SqlCommand count_cmd = new SqlCommand("select  count(*) from User_details where Username='" + UserName + "' and Password='" + Password + "'", con);
            int result = Convert.ToInt32(count_cmd.ExecuteScalar());

            if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int LogInAdmin(String AdminUserName, String AdminPassword)
        {
            SqlCommand count_cmd = new SqlCommand("select  count(*) from User_details whereAdmin_details where Username='" + AdminUserName + "' and Password='" + AdminPassword + "'", con);
            int result = Convert.ToInt32(count_cmd.ExecuteScalar());

            if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string ForgotPassword(String Email)
        {
            SqlCommand retrive_cmd = new SqlCommand("SELECT Password FROM User_details Where Email= '" + Email + "'", con);
            SqlDataReader dr = retrive_cmd.ExecuteReader();

            dr.Read();

            if (dr.HasRows)
            {
                string details = dr[0].ToString();
                return details;
            }
            else
            {
                return null;
            }
        }
        public int EditUserProfile(String UserName, String FirstName, String LastName, long PhoneNumber, String Email, String Password)
        {
            SqlCommand count_cmd = new SqlCommand("select  count(*) from Customer_Subscription where Username='" + UserName + "'", con);
            int result = Convert.ToInt32(count_cmd.ExecuteScalar());
            int status;
            if (result == 1)
            {
                status = 1;
                cmd = new SqlCommand("update User_details set Username='" + UserName + "',First_name='" + FirstName + "',Last_name='" + LastName + "',Password='" + Password + "',Email='" + Email + "',Status='" + status + "'where Username='" + UserName + "'", con);
                return cmd.ExecuteNonQuery();
            }
            else
            {
                status = 0;
                cmd = new SqlCommand("update User_details set Username='" + UserName + "',First_name='" + FirstName + "',Last_name='" + LastName + "',Password='" + Password + "',Email='" + Email + "',Status='" + status + "'where Username='" + UserName + "'", con);
                return cmd.ExecuteNonQuery();
            }
        }
        public int Customer_Subscription(string Plan_Id, string Username, double Data_Uploaded, double Data_Allotted, int Valid_Upto, string Folder_Path, int Status)
        {

            string Check_username = "select count(*) from Customer_Subscription where Username='" + Username + "'";
            SqlCommand count_cmd = new SqlCommand(Check_username, con);
            int x = count_cmd.ExecuteNonQuery();
            SqlCommand cmd;

            if (x == 1)
            {
                string update_cmd = "UPDATE Customer_Subscription SET Plan_id='" + Plan_Id + "',Data_uploaded=" + Data_Uploaded + "',Data_allotted=" + Data_Allotted + ",Valid_upto=" + Valid_Upto + ",Floder_path='" + Folder_Path + "',Status=" + Status + "";
                cmd = new SqlCommand(update_cmd, con);
                cmd.ExecuteNonQuery();
                return 1;
            }
            else
            {
                string insert_cmd = "insert into Customer_Subscription values('" + Plan_Id + "','" + Username + "'," + Data_Uploaded + "," + Data_Allotted + "," + Valid_Upto + ",'" + Folder_Path + "'," + Status + ")";
                cmd = new SqlCommand(insert_cmd, con);
                cmd.ExecuteNonQuery();
                return 1;
            }
        }
        public SqlDataReader GetDetails()
        {
            SqlCommand cmd = new SqlCommand("select * from Subscription_plan_details", con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader GettempDetails()
        {
            SqlCommand cmd = new SqlCommand("select * from Template_Details", con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public void Delete_Template(string title)
        {
            SqlCommand cmd = new SqlCommand("delete from Template_Details where Title='" + title + "'", con);
            cmd.ExecuteNonQuery();
        }
        public void Disconnect()
        {
            con.Close();
        }
        public string CheckConnection()
        {
            return con.State.ToString();
        }
        public int SearchCustomer(String UserName)
        {
            SqlCommand count_cmd = new SqlCommand("select  count(*) from Customer_Subscription where Username='" + UserName + "' ", con);
            int result = Convert.ToInt32(count_cmd.ExecuteScalar());
            if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //---------------Admin------------------
        public SqlDataReader GetUserDetails()
        {
            cmd = new SqlCommand("select * from  tbl_user", con);
            return cmd.ExecuteReader();

        }
		
		//Edited
		
		
        public int UpdateUserDetails(string fname, string lname, int mob, string country, string state, string pin,string email)
        {
            cmd = new SqlCommand("update tbl_user set fname='" + fname + "',lname='" +lname + "',mob='" + mob + "',country='" + country + "',state='" + state + "',pin='" + pin + "' where email='" + email + "'", con);
            return cmd.ExecuteNonQuery();
        }
		
		
		

        public int DeleteUserDetails(string email)
        {
            cmd = new SqlCommand("delete from tbl_user  where email='" + email + "'" , con);
            return cmd.ExecuteNonQuery();
        }

        public int CountAdminDetails(string Username)
        {

            cmd = new SqlCommand("select  count(*) from Admin_details where Username='" + Username + "'", con);
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        public int InsertNewAdminDetails(string Username, string First_name, string Last_name, string Password, string Email, int Status)
        {
            cmd = new SqlCommand("insert into Admin_details values('" + Username + "','" + First_name + "','" + Last_name + "','" + Password + "','" + Email + "','" + Status + "')", con);
            return cmd.ExecuteNonQuery();
        }

        //------------User Detail---------------------,format(Vaild_upto,'dd-mm-yyyy') as Vaild_upto      
        public SqlDataReader GetAllUserDetails()
        {
            cmd = new SqlCommand("select *  from  User_details left join Customer_Subscription on User_details.Username=Customer_Subscription.Username", con);
            return cmd.ExecuteReader();

        }
        public int CountCustomerSubscriptionDetails(string Username)
        {

            cmd = new SqlCommand("select  count(*) from Customer_Subscription where Username='" + Username + "'", con);
            return int.Parse(cmd.ExecuteScalar().ToString());
        }
        public int UpdateCustomerSubscriptionDetails(string Username, int Status)
        {
            cmd = new SqlCommand("update Customer_Subscription set  Status='" + Status + "' where Username='" + Username + "'", con);
            return cmd.ExecuteNonQuery();
        }
        public int DeleteCustomerSubscriptionDetails(string Username)
        {
            cmd = new SqlCommand("delete from Customer_Subscription   where Username='" + Username + "'", con);
            return cmd.ExecuteNonQuery();
        }
        //---------Subscription Plan--------------------
        public SqlDataReader GetAllSubscriptionPlan()
        {

            cmd = new SqlCommand("select * from  Subscription_plan_details", con);
            dr = cmd.ExecuteReader();
            return dr;

        }
        public int CountSubscriptionPlan(string Plan_id)
        {

            cmd = new SqlCommand("select  count(*) from Subscription_plan_details where Plan_id='" + Plan_id + "'", con);
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        public int UpdateSubscriptionPlan(int Sr_no, string Plan_id, string Data_limit, string Price, int Validation_time, string Plan_name)
        {
            cmd = new SqlCommand("update Subscription_plan_details set Plan_id='" + Plan_id + "',Data_limit='" + Data_limit + "',Price='" + Price + "',Validation_time='" + Validation_time + "',Plan_name='" + Plan_name + "' where Sr_no=" + Sr_no, con);
            return cmd.ExecuteNonQuery();
        }
        public int DeleteSubscriptionPlan(int Sr_no)
        {
            cmd = new SqlCommand("delete from Subscription_plan_details   where Sr_no=" + Sr_no, con);
            return cmd.ExecuteNonQuery();
        }
        public int InsertNewSubscriptionPlan(string Plan_id, string Data_limit, string Price, int Validation_time, string Plan_name)
        {
            cmd = new SqlCommand("insert into Subscription_plan_details values('" + Plan_id + "','" + Data_limit + "','" + Price + "','" + Validation_time + "','" + Plan_name + "')", con);
            return cmd.ExecuteNonQuery();
        }
        public int Auto_Increament_SrNo_SubscriptionPlan(int Sr_no)
        {
            cmd = new SqlCommand("ALTER TABLE `Subscription_plan_details` AUTO_INCREMENT = 1", con);
            return cmd.ExecuteNonQuery();
        }
        //---------Feedback--------------------
        public int SubmitFeedback(String UserName, int interfaceRating, int servicesRating, int planRating, int WebtempRating, String comment)
        {
            string insertFeedback_cmd = "insert into Feedback values('" + UserName + "'," + interfaceRating + "," + servicesRating + "," + planRating + "," + WebtempRating + ",'" + comment + "')";
            SqlCommand cmd = new SqlCommand(insertFeedback_cmd, con);
            return cmd.ExecuteNonQuery();
        }
        public int checkCustomerStatus(String Username, long sizeOfPosted)
        {

            int status = 1;
            double dataUploaded = 0, dataAllotted = 0;
            SqlCommand cmd = new SqlCommand("select Data_Uploaded,Data_allotted from Customer_Subscription where Username='" + Username + "' and Status='" + status + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dataUploaded = Double.Parse(dr[0].ToString());
                dataAllotted = Double.Parse(dr[1].ToString());
            }

            double UploadSize = sizeOfPosted + dataUploaded;

            if ((dataUploaded < dataAllotted))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void updateDataUploaded(String Username, long sizeOfPosted)
        {
            SqlCommand cmd2 = new SqlCommand("Update Customer_Subscription set Data_Uploaded=Data_Uploaded+" + sizeOfPosted + " where Username='" + Username + "'", con);
            cmd2.ExecuteNonQuery();
        }
        public DataTable PlanUploadDetails(string username)
        {
            //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Mukesh;UID=sa;pwd=mukesh;");
            //Connect();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string cmdstr = "select Data_uploaded,Data_allotted from Customer_Subscription where Username='" + username + "'";
            SqlDataAdapter adp = new SqlDataAdapter(cmdstr, con);
            adp.Fill(ds);
            dt = ds.Tables[0];
            return dt;



        }
        public SqlDataReader GetUserDetails(String Username)
        {
            cmd = new SqlCommand("select First_name, Last_name,Phone_no,Email,Password  from  User_details where Username='" + Username + "'", con);
            return cmd.ExecuteReader();
        }
        public int AddNewTemplate(string name, string title, string home_page, string folder_path)
        {
            string insert_temp = "insert into Template_Details values('" + name + "','" + title + "','" + home_page + "','" + folder_path + "')";
            SqlCommand cmd = new SqlCommand(insert_temp, con);
            cmd.ExecuteNonQuery();
            return 1;
        }
        public SqlDataReader ProvideURL(string category)
        {
            string query = "select Home_Page from Template_Details where Category='" + category + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }
    }

