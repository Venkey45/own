using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace own
{
    public partial class userWelcome : System.Web.UI.Page
    {
        void GetData()
        {
            //cerate a connection by using sqlconnection
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["vb"].ToString());
            //pass stored procedure by sql command class
            string q = "proc_userDisplay";
            SqlCommand cmd = new SqlCommand(q, con);
            //we have infrom using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            //add values
            cmd.Parameters.AddWithValue("@a", Session["username"].ToString());
            //pass cmd by using sqldataAdpter class
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //create object to dataset
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds, "main");
            //link provide gridview to datascource
            GridView1.DataSource = ds;
            //Bind Data
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //call getData method
                GetData();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("homepage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("search.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
          
            if (e.CommandName == "vEdit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Label l1 = (Label)row.FindControl("Label1");
                Label l2 = (Label)row.FindControl("Label2");
                Label l3 = (Label)row.FindControl("Label3");
                Label l4 = (Label)row.FindControl("Label4");
                Label l5 = (Label)row.FindControl("Label5");
                Label l6 = (Label)row.FindControl("Label6");
                Label l7 = (Label)row.FindControl("Label7");
                Label l8 = (Label)row.FindControl("Label8");
                Label l9 = (Label)row.FindControl("Label9");
                Label l10 = (Label)row.FindControl("Label10");
                Session["userid"] = l1.Text;
                Session["username"] = l2.Text;
                Session["password"] = l3.Text;
                Session["gender"] = l4.Text;
                Session["Languages"] = l5.Text;
                Session["state"] = l6.Text;
                Session["city1"] = l7.Text;
                Session["Blood1"] = l8.Text;
                Session["Phone Number"] = l9.Text;
                Session["Email"] = l10.Text;
                Session["Button"] = "update";
                Session["Button1"] = "update";
                Server.Transfer("Rigister.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}