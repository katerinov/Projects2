using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;



namespace WebApplicationSP
{
    public partial class page5 : System.Web.UI.Page
    {
        public string connectionString = "Data Source=Artemis\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
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
            Label3.Text = ExecuteCommand("SELECT name FROM  registration  where login='" + Session["login"].ToString() + "'", "Name");
            Label6.Text = ExecuteCommand("SELECT surname FROM  registration where login='" + Session["login"].ToString() + "'", "Surname");
            Label4.Text = Session["login"].ToString();
            Label5.Text = ExecuteCommand("SELECT email FROM  registration where login='" + Session["login"].ToString() + "'", "email");
            Image2.ImageUrl = @"~\image\" + ExecuteCommand("SELECT photoName FROM  registration where login='" + Session["login"].ToString() + "'", "photoName");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page1.aspx");
        }

    }
}