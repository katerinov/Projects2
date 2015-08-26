using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplicationSP
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == Session["vercod"].ToString())
                Session["flag"] = "true";
            else
                Session["flag"] = "false";
            Response.Redirect("page4.aspx");
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx");
        }
    }
}