using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace own
{
    public partial class Adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create a connection 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["vb"].ToString());
            //open connection
            con.Open();
            //pass query to data base
            string q = "proc_admin ";
            SqlCommand cmd = new SqlCommand(q, con);
            //we inform to stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            //giving values
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            object p = cmd.ExecuteScalar();
            if ((int)p != 0)
            {
                //Response.Write("Valid user");
                Response.Redirect("Registerwelcome.aspx");
             }
            else
            {
                Response.Write("Invalid user");
            }
            con.Close();
        }
    }
}