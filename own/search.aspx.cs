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
    public partial class search : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["vb"].ToString());
        void GetData()
        {
            //pass query to database by using sqldatdaAdpter class 
            string q = "proc_searchDisplay";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object to data set
            DataSet ds = new DataSet();
            //fill data set
            da.Fill(ds, "main");
            //link provide between gridview to datascourec
            GridView1.DataSource = ds;
            //Bind Dataset
            GridView1.DataBind();
        }
        void Getsate()
        {
            //pass query to database by using sqldatdaAdpter class 
            string q = "proc_states";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object to data set
            DataSet ds = new DataSet();
            //fill data set
            da.Fill(ds, "states");
            //link provide between dropDownList to datascourec
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "sname";
            DropDownList2.DataValueField = "sid";
            //Bind Dataset
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "--select--");
        }
        void Blood()
        {
            //pass query to database by using sqldatdaAdpter class 
            string q = "proc_blood";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object to data set
            DataSet ds = new DataSet();
            //fill data set
            da.Fill(ds, "Blood");
            //link provide between dropDownList to datascourec
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "Blood";
           
            //Bind Dataset
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--select--");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //call grtdata method
                GetData();
                //call Getstates Method
                Getsate();
                //call Blood Method
                Blood();
                DropDownList3.Items.Insert(0, "--select--");
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pass query to database by using sqldatdaAdpter class 
            string q = "proc_cities2";
            //by using sqlcommand class
            SqlCommand cmd = new SqlCommand(q, con);
            //we have infrome using stored prcedure 
            cmd.CommandType = CommandType.StoredProcedure;
            //add values
            cmd.Parameters.AddWithValue("@a", DropDownList2.SelectedValue);
            //usnig sqldataAdpterclass
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //create object to data set
            DataSet ds = new DataSet();
            //fill data set
            da.Fill(ds, "cities");
            //link provide between dropDownList to datascourec
            DropDownList3.DataSource = ds;
            DropDownList3.DataTextField = "cname";
           
            //Bind Dataset
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, "--selecct--");
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //pass query to database by using sqldatdaAdpter class 
            string q = "proc_search";
            SqlCommand cmd = new SqlCommand(q, con);
            //we have infrom using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            //Add values
            cmd.Parameters.AddWithValue("@a", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@b", DropDownList2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@c", DropDownList3.SelectedItem.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //create object to data set
            DataSet ds = new DataSet();
            //fill data set
            da.Fill(ds, "main");
            //link provide between gridview to datascourec
            GridView1.DataSource = ds;
            //Bind Dataset
            GridView1.DataBind();
            GridView1.Visible = true;
        }
    }
}