using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library_3;
using Library_4;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(TextBox2.Text);
                int y = Int32.Parse(TextBox1.Text);
                KI3_Class_3 m3 = new KI3_Class_3();
                Label3.Text =(m3.F3(x,y)+2*KI3_Class_4.F4(x,y)).ToString();
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }

        }
    }
}