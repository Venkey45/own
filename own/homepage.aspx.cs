using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace own
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["page"]=0 ;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Server.Transfer("Adminlogin.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Server.Transfer("userlogin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Button"] = "Register";
            Server.Transfer("Rigister.aspx");
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("search.aspx");
        }
    }
}