using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationSP
{
    public partial class page1 : System.Web.UI.Page
    {
        public string connectionString = "Data Source=Artemis\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
        public static string logn = "",
            pass = "";

        public string ExecuteCommand(string comm, string column)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(comm, con);
                SqlDataReader reader = null;
                string res = string.Empty;
                reader = command.ExecuteReader();
                reader.Read();
                res = Convert.ToString(reader[column]);
                return res;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            page1Title.Text = "САЙТ З АВТОРИЗОВАНИМ ДОСТУПОМ";
            LabelLogin.Text = "ЛОГІН:";
            LabelPassword.Text = "ПАРОЛЬ:";
        }

        //redirecting to page2
        protected void Button2_Click(object sender, EventArgs e)
        {
            //Button2.Visible = false;
            //Button1.Visible = false;
            Response.Redirect("page2.aspx");
        }

        //redirecting to page5 with info
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Button1.Visible = false;
            //Button2.Visible = false;
            try
            {
                logn = ExecuteCommand("select login from registration where login='" + TextBoxLogin.Text + "'", "login");
                pass = ExecuteCommand("select password1 from registration where password1='" + TextBoxPassword.Text + "'", "password1");
                Session["login"] = TextBoxLogin.Text;
                Session["pass"] = TextBoxPassword.Text;
                Response.Redirect("page5.aspx");
            }
            catch (Exception ex)
            {
                Label1.Text = "invalid login or password";
            }
        }
    }
}