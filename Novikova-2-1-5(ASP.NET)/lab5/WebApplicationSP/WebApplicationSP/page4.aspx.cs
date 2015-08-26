using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplicationSP
{
    public partial class page4 : System.Web.UI.Page
    {
        public string connectionString = "Data Source=Artemis\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";

        public void ExecuteCommand(string command)
        {
            DataSet data = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, connectionString);
                adapter.Fill(data);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["flag"].ToString() == "true")
                Label1.Visible = true;
            else
            {
                Label2.Visible = true;
                ExecuteCommand("delete registration  where login='" + Session["login"].ToString() + "'");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            Response.Redirect("page1.aspx");
        }
    }
}