using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace WebApplicationSP
{
    public partial class page2 : System.Web.UI.Page
    {
        public static bool sportmaster = false,
sciencecandidat = false,
sciencedoctorat = false;
        public static string form = "",
            faculty = "",
            department = "",
            vercod = "",
            fileName = "";
        public static string userLogin = "";
        public static int count = 1;
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
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/scripts/jquery-1.7.2.min.js",
            });

            //if (Session["img"] != null)
            //    FileUpload1.PostedFile = Convert.ToString(Session["img"]);

            LabelPhoto.Text = "ФОТОГРАФІЯ (JPEG/PNG, min 100x150, max 200x300):";
            name.Text = "ІМ'Я:";
            surname.Text = "ПРІЗВИЩЕ:";
            login.Text = "Логін:";
            email.Text = "E-mail:";
            password.Text = "Пароль:";

            if (rbs.Items[1].Selected)
            {
                FillList2();
                DropDownList1.Enabled = false;
                DropDownList2.Enabled = true;
                DropDownList3.Enabled = false;
            }
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                FileUpload1.SaveAs(Server.MapPath("~/image/" + fileName));

                if (CheckBoxList1.Items[0].Selected)
                    sportmaster = true;
                if (CheckBoxList1.Items[1].Selected)
                    sciencecandidat = true;
                if (CheckBoxList1.Items[2].Selected)
                    sciencedoctorat = true;

                if (DropDownList1.Enabled)
                    form = DropDownList1.SelectedItem.ToString();
                if (DropDownList2.Enabled)
                    faculty = DropDownList2.SelectedItem.ToString();
                if (DropDownList3.Enabled)
                    department = DropDownList3.SelectedItem.ToString();

                ExecuteCommand("insert into registration (name,surname,login," +
                    "email,password1,password2,proffession,sportmaster,form,faculty,sciencecandidat," +
                    "sciencedoctorat,department,photoName) values ('" + tbname.Text + "','" + tbsurname.Text +
                    "','" + tblogin.Text + "','" + tbemail.Text + "','" + tbpassword1.Text + "','" + tbpassword2.Text +
                    "','" + rbs.Items[count].ToString() + "','" + sportmaster + "','" + form + "','" + faculty +
                    "','" + sciencecandidat + "','" + sciencedoctorat + "','" + department + "','" + fileName + "') ;");

                Session["login"] = tblogin.Text;

                vercod = CreateRandomCode(4);
                vercod = vercod.ToLower();
                Session["vercod"] = vercod;

                SendEmail("Verification Code", "katen145@gmail.com");
                Response.Redirect("page3.aspx");

            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("page1.aspx");
        }

        public void FillList1()
        {
            DropDownList1.Items.Add("1 курс");
            DropDownList1.Items.Add("2 курс");
            DropDownList1.Items.Add("3 курс");
            DropDownList1.Items.Add("4 курс");
            DropDownList1.Items.Add("5 курс");
            DropDownList1.Items.Add("6 курс");
        }
        public void FillList2()
        {
            DropDownList2.Items.Add("Механіко-математичний");
            DropDownList2.Items.Add("Радіофізичний");
            DropDownList2.Items.Add("Геологічний");
            DropDownList2.Items.Add("Історичний");
            DropDownList2.Items.Add("Філософський");
        }
        public void FillList3()
        {
            DropDownList3.Items.Add("Наукова бібліотека");
            DropDownList3.Items.Add("Ботанічний сад");
            DropDownList3.Items.Add("Інформаційно-обчислювальний центр");
            DropDownList3.Items.Add("Ректорат");
        }
        protected void rbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbs.Items[0].Selected)//stud
            {
                CheckBoxList1.Items[1].Enabled = false;
                CheckBoxList1.Items[2].Enabled = false;
                FillList1();
                FillList2();
                DropDownList3.Items.Clear();
                DropDownList1.Enabled = true;
                DropDownList2.Enabled = true;
                DropDownList3.Enabled = false;
                count = 0;
            }
            else if (rbs.Items[1].Selected)//teach
            {
                CheckBoxList1.Items[1].Enabled = true;
                CheckBoxList1.Items[2].Enabled = true;
                DropDownList1.Items.Clear();
                //DropDownList2.Items.Clear();
                DropDownList3.Items.Clear();
                DropDownList1.Enabled = false;
                DropDownList2.Enabled = true;
                DropDownList3.Enabled = false;
                count = 1;
            }
            else if (rbs.Items[2].Selected)//assistent
            {
                CheckBoxList1.Items[1].Enabled = true;
                CheckBoxList1.Items[2].Enabled = false;
                DropDownList1.Items.Clear();
                DropDownList2.Items.Clear();
                FillList3();
                DropDownList1.Enabled = false;
                DropDownList2.Enabled = false;
                DropDownList3.Enabled = true;
                count = 2;
            }
        }

        public string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;

            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(36);
                if (temp != -1 && temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }

        public static void SendEmail(string subject, string recipient)
        {
            //var reciever = new MailAddress(recipient, "Verification Code");
            string password = "kpnlkdn95";
            string sender = "katen145@gmail.com";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(sender, password)
            };

            using (var email = new MailMessage(sender, recipient)
            {
                Subject = "Verification Code",
                Body = vercod
            })
            {
                smtp.Send(email);
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            fileName = FileUpload1.PostedFile.FileName;
            Session["img"] = fileName;

            System.Drawing.Image img = System.Drawing.Image.FromStream(FileUpload1.PostedFile.InputStream);
            int height = img.Height;
            int width = img.Width;

            if ((height < 150 && width < 100) || (height > 300 && width > 200))
            {
                CustomValidator1.ErrorMessage = "Height and Width must not exceed 100px.";
                args.IsValid = false;
            }
            else
                args.IsValid = true;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("select login from registration", con);
                SqlDataReader reader = null;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (tblogin.Text == Convert.ToString(reader["login"]))
                    {
                        CustomValidator1.ErrorMessage = "Login exists already. Please enter a different one.";
                        args.IsValid = false;
                        break;
                    }
                    else
                        args.IsValid = true;
                }
            }
        }

    }
}