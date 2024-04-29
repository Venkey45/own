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
    public partial class Rigister : System.Web.UI.Page
    {
        void Getstates()
        {
            //create a connection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["vb"].ToString());
            //pass stored procedure by using sqlAdapter class
            string q = "proc_states";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object to dataset
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds, "states");
            //link provide dropdwonlist1 to datasource
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "sname";
            DropDownList1.DataValueField = "sid";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--select--");

        }
        void Blood()
        {
            //create a connection by usnig sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["vb"].ToString());
            //pass stored procedure by using sqlAdapter class
            string q = "proc_blood";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object to Dataset
            DataSet ds = new DataSet();
            //Fill dataset
            da.Fill(ds, "Blood");
            //provide link Between DropDownList to DataSource
            DropDownList3.DataSource = ds;
            DropDownList3.DataTextField = "Blood";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, "--select--");
        }
        void Cities()
        {
            string b = DropDownList1.SelectedItem.Value;
            //create a connection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["vb"].ToString());
            //pass stored procedure by using sqlAdapter class
            string q = "proc_cities2";
            //sqlcommand cass
            SqlCommand cmd = new SqlCommand(q, con);
            //we have to infrom using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            //add values storred procedure
            cmd.Parameters.AddWithValue("@a", b);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //create object to dataset
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds, "cities");
            //link provide dropdwonlist1 to datasource
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "cname";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "--select--");
        }
        void clear()
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = "";
            RadioButton1.Checked = RadioButton2.Checked = false;
            CheckBox1.Checked = CheckBox2.Checked = CheckBox3.Checked = false;
            DropDownList1.SelectedIndex = -1;
            DropDownList2.SelectedIndex = -1;
            DropDownList3.SelectedIndex = -1;
        }

        string s = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                s = Session["Button"].ToString();
                if(s!="Register")
                {
                    Button1.Text = Session["Button1"].ToString();
                    TextBox1.Text = Session["username"].ToString();
                    
                    TextBox3.Text = Session["password"].ToString();
                    string b = Session["Gender"].ToString();
                    if (b.Trim() == RadioButton1.Text)
                    {
                        RadioButton1.Checked = true;
                    }else if (b.Trim() == RadioButton2.Text)
                    {
                        RadioButton2.Checked = true;
                    }
                    string [] c = (Session["Languages"]).ToString().Split();
                    foreach(string s in c)
                    {
                        if (s == CheckBox1.Text)
                        {
                            CheckBox1.Checked = true;
                        }
                       else if (s == CheckBox2.Text)
                        {
                            CheckBox2.Checked = true;
                        }
                        if (s == CheckBox3.Text)
                        {
                            CheckBox3.Checked = true;
                        }
                    }
                   //string q = Session["states"].ToString().Trim();
                    string y = Session["city1"].ToString().Trim();
                    
                    string z = Session["Blood1"].ToString().Trim();
                    Getstates();
                    DropDownList1.SelectedIndex=DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(Session["state"].ToString()));
                    Cities();
                    DropDownList2.SelectedIndex = DropDownList2.Items.IndexOf(DropDownList2.Items.FindByText(y));
                    Blood();
                    DropDownList3.SelectedIndex=DropDownList3.Items.IndexOf(DropDownList3.Items.FindByText(z));
                    TextBox4.Text = Session["Phone Number"].ToString();
                    TextBox5.Text = Session["Email"].ToString();
                    Button1.CausesValidation = false;
                    //call clear method
                    //clear();
                }
                //call the states method
                Getstates();
                Blood();
                DropDownList2.Items.Insert(0, "--select--");
              
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = "";
            //create  a connection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["vb"].ToString());
            //open connection
            con.Open();
            //pass stored prpcedure by using sqlcommand class
            if (Button1.Text == "Register")
            {
                q = "prc_insert";
                SqlCommand cmd = new SqlCommand(q, con);
                //we have to infrom using stored procedure 
                cmd.CommandType = CommandType.StoredProcedure;
                //Add values stored procedure
                cmd.Parameters.AddWithValue("@a", TextBox1.Text);
                cmd.Parameters.AddWithValue("@b", TextBox2.Text);
                string c = "";
                if (RadioButton1.Checked == true)
                {
                    c = RadioButton1.Text;
                }
                else
                {
                    c = RadioButton2.Text;
                }
                cmd.Parameters.AddWithValue("@c", c);
                string x = "";
                if (CheckBox1.Checked == true)
                {
                    x = CheckBox1.Text;
                }
                if (CheckBox2.Checked == true)
                {
                    x = x + " " + CheckBox2.Text;
                }
                if (CheckBox3.Checked == true)
                {
                    x = x + " " + CheckBox3.Text;
                }
                cmd.Parameters.AddWithValue("d", x);
                cmd.Parameters.AddWithValue("e", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("f", DropDownList2.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@g", DropDownList3.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@h", TextBox4.Text);
                cmd.Parameters.AddWithValue("@i", TextBox5.Text);
                //ExeuteNonQuery Method Exeute query
                cmd.ExecuteNonQuery();
                
                Button1.Text = "Register";
                //call clear method
                clear();
                Response.Redirect("userlogin.aspx");
            }
            else
            {
                if (Button1.Text == "update")
                {
                    q = "proc_update1";
                }
                else
                {

                }
               
               
                SqlCommand cmd1 = new SqlCommand(q, con);
                //we have inform using stored proccedure
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@a", Session["username"]);
                cmd1.Parameters.AddWithValue("@g", DropDownList3.SelectedItem.Text);
                cmd1.Parameters.AddWithValue("@h", TextBox4.Text);
                cmd1.Parameters.AddWithValue("@i", TextBox5.Text);
                cmd1.Parameters.AddWithValue("@f", DropDownList2.SelectedItem.Text);
                cmd1.Parameters.AddWithValue("@j", Session["userid"].ToString());
                //Label1.Text = Session["userid"].ToString();
                //Exeute Query by using Execute NonQuery Method
                cmd1.ExecuteNonQuery();
                Button1.Text = "Register";
                Response.Redirect("userWelcome.aspx");
            }


            //close connection
            con.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string b = DropDownList1.SelectedItem.Value;
            //create a connection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["vb"].ToString());
            //pass stored procedure by using sqlAdapter class
            string q = "proc_cities2";
            //sqlcommand cass
            SqlCommand cmd = new SqlCommand(q, con);
            //we have to infrom using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            //add values storred procedure
            cmd.Parameters.AddWithValue("@a", b);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //create object to dataset
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds, "cities");
            //link provide dropdwonlist1 to datasource
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "cname";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "--select--");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = "";
            RadioButton1.Checked = RadioButton2.Checked = false;
            CheckBox1.Checked = CheckBox2.Checked = CheckBox3.Checked = false;
            DropDownList1.SelectedIndex = -1;
            DropDownList2.SelectedIndex = -1;
            DropDownList3.SelectedIndex = -1;
        }
    }
}