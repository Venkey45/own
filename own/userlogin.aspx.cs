using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace own
{
    public partial class userlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create connection
            SqlConnection con = new SqlConnection("integrated security = yes; database = KINGSBANK;data Source=.");
            //open connection
            con.Open();
            //pass stored procedure to database by using sqlcommand class
            string q = "proc_userpass";
            SqlCommand cmd = new SqlCommand(q, con);
            //we inform to stored procedrure 
            cmd.CommandType = CommandType.StoredProcedure;
            //giving values
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            //execute stored procedure
            object a = cmd.ExecuteScalar();
            if ((int)a!=0)
            {
                Session["username1"] = TextBox1.Text;
                Server.Transfer("userWelcome.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Invalid user";
            }
            
        }
    }
}