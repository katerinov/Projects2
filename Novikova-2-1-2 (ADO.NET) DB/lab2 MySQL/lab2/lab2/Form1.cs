using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string connectionString = "server=10.0.66.224; port=3306; database=Salon_Krasi; user=root; password=123456; charset=cp1251;";

        public void ExecuteCommand(string command)
        {
            DataSet data = new DataSet();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command, connectionString);
                adapter.Fill(data);
            }
        }

        public void Start(string select, string insert)
        {
            DataSet data = new DataSet();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(select, connectionString);
                adapter.Fill(data);

                try
                {
                    string t = data.Tables[0].Rows[0][0].ToString();
                }
                catch
                {
                    ExecuteCommand(insert);
                }
            }
        }

        public void FillPoslugi()
        {
            DataSet data = new DataSet();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter("select Name from Vidi_Poslug", connectionString);
                ad.Fill(data);
            }
            comboBox1.Items.Clear();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                comboBox1.Items.Add(data.Tables[0].Rows[i][0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string selectFrom1 = "SELECT * FROM Vidi_Poslug WHERE Name = 'Fake Nails' AND TimeNeeded= 45 ;";
            string selectFrom2 = "SELECT * FROM Vidi_Poslug WHERE Name='Hairstyle Chemistry' AND TimeNeeded=120";
            string insertInto1 = "insert into Vidi_Poslug (Name,TimeNeeded) values ('Fake Nails',45)  ;";
            string insertInto2 = "insert into Vidi_Poslug (name,TimeNeeded) values ('Hairstyle Chemistry',120)";
            Start(selectFrom1, insertInto1);
            Start(selectFrom2, insertInto2);
            FillPoslugi();
        }

        private void button1_Click(object sender, EventArgs e)
        {//button get query
            string command = "";
            DataSet data = new DataSet();

            if ((radioButtonGet.Checked) && (checkBoxID.Checked))
                command = "select*from Fahivtsi_Salonu where ID=" + richTextBoxID.Text;
            if ((radioButtonGet.Checked) && (checkBoxPoslug.Checked))
                command = "select * from Fahivtsi_Salonu where Posluga_ID = (select ID from Vidi_Poslug where Name = '" + comboBox1.Text + "')";
            if ((radioButtonGet.Checked) && (!checkBoxPoslug.Checked) && (!checkBoxID.Checked))
                command = "select * from Fahivtsi_Salonu";

            if (radioButtonAdd.Checked)
            {
                command = "insert into Fahivtsi_Salonu (FirstName,MiddleName,SurName,Posluga_ID,Employee_Since) values ('" + richTextBoxName.Text + "','" + richTextBoxMName.Text + "','" + richTextBoxLName.Text + "',(select ID from Vidi_Poslug where Name='" + comboBox1.Text + "')," + richTextBoxYear.Text + ");";
                MessageBox.Show("Entry added");
            }
            if (radioButtonUpdate.Checked)
            {
                command = "update Fahivtsi_Salonu set FirstName='" + richTextBoxName.Text + "',MiddleName='" + richTextBoxMName.Text + "',SurName='" + richTextBoxLName.Text + "',Posluga_ID=(select ID from Vidi_Poslug where Name='" + comboBox1.Text + "'), Employee_Since= " + richTextBoxYear.Text + " where ID=" + richTextBoxID.Text;
                MessageBox.Show("Entry updated");
            }
            if ((radioButtonDelete.Checked) && (checkBoxID.Checked))
            {
                command = "delete from Fahivtsi_Salonu where ID =" + richTextBoxID.Text;
                MessageBox.Show("Entry deleted by id");
            }
            if ((radioButtonDelete.Checked) && (checkBoxPoslug.Checked))
            {
                command = "delete from Fahivtsi_Salonu where Posluga_ID = (select ID from Vidi_Poslug where Name = '" + comboBox1.Text + "')";
                MessageBox.Show("Entry deleted by name of Poslug");
            }
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command, connectionString);
                adapter.Fill(data);
            }
            if (radioButtonGet.Checked)
                dataGridViewDB.DataSource = data.Tables[0];
        }


        private void comboBox1_Click(object sender, EventArgs e)
        {
            FillPoslugi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPoslug.Enabled = false;
            checkBoxID.Enabled = false;
            if (radioButtonAdd.Checked)
            {
                richTextBoxName.Enabled = true;
                richTextBoxMName.Enabled = true;
                richTextBoxLName.Enabled = true;
                richTextBoxYear.Enabled = true;
                richTextBoxID.Enabled = false;
                comboBox1.Enabled = true;
            }
        }

        private void radioButtonGet_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPoslug.Enabled = true;
            checkBoxID.Enabled = true;

            richTextBoxName.Enabled = false;
            richTextBoxMName.Enabled = false;
            richTextBoxLName.Enabled = false;
            richTextBoxYear.Enabled = false;
            richTextBoxID.Enabled = false;
            comboBox1.Enabled = false;

            if (checkBoxID.Checked)
                richTextBoxID.Enabled = true;
            if (checkBoxPoslug.Checked)
                comboBox1.Enabled = true;
        }

        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPoslug.Enabled = false;
            checkBoxID.Enabled = false;

            richTextBoxName.Enabled = true;
            richTextBoxMName.Enabled = true;
            richTextBoxLName.Enabled = true;
            richTextBoxYear.Enabled = true;
            richTextBoxID.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPoslug.Enabled = true;
            checkBoxID.Enabled = true;

            richTextBoxName.Enabled = false;
            richTextBoxMName.Enabled = false;
            richTextBoxLName.Enabled = false;
            richTextBoxYear.Enabled = false;
            richTextBoxID.Enabled = false;
            comboBox1.Enabled = false;

            if (checkBoxID.Checked)
                richTextBoxID.Enabled = true;
            if (checkBoxPoslug.Checked)
                comboBox1.Enabled = true;
        }

        private void checkBoxPoslug_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButtonGet.Checked) || (radioButtonDelete.Checked))
            {
                if (checkBoxPoslug.Checked)
                {
                    richTextBoxID.Enabled = false;
                    richTextBoxName.Enabled = false;
                    richTextBoxMName.Enabled = false;
                    richTextBoxLName.Enabled = false;
                    richTextBoxYear.Enabled = false;
                    comboBox1.Enabled = true;
                }
                else
                {
                    if (!checkBoxID.Checked)
                    {
                        richTextBoxID.Enabled = false;
                        richTextBoxName.Enabled = false;
                        richTextBoxMName.Enabled = false;
                        richTextBoxLName.Enabled = false;
                        richTextBoxYear.Enabled = false;
                        comboBox1.Enabled = false;
                    }
                    else
                        comboBox1.Enabled = false;
                }
                if ((checkBoxID.Checked) && (checkBoxPoslug.Checked))
                {
                    richTextBoxID.Enabled = true;
                    comboBox1.Enabled = true;
                }
            }
        }

        private void checkBoxID_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButtonGet.Checked) || (radioButtonDelete.Checked))
            {
                if (checkBoxID.Checked)
                {
                    richTextBoxID.Enabled = true;
                    richTextBoxName.Enabled = false;
                    richTextBoxMName.Enabled = false;
                    richTextBoxLName.Enabled = false;
                    richTextBoxYear.Enabled = false;
                    comboBox1.Enabled = false;
                }
                else
                {
                    if (!checkBoxPoslug.Checked)
                    {
                        richTextBoxID.Enabled = false;
                        richTextBoxName.Enabled = false;
                        richTextBoxMName.Enabled = false;
                        richTextBoxLName.Enabled = false;
                        richTextBoxYear.Enabled = false;
                        comboBox1.Enabled = false;
                    }
                    else
                        richTextBoxID.Enabled = false;
                }
                if ((checkBoxID.Checked) && (checkBoxPoslug.Checked))
                {
                    richTextBoxID.Enabled = true;
                    comboBox1.Enabled = true;
                }
            }
        }



        private void richTextBoxName_Validating(object sender, CancelEventArgs e)
        {
            NameError(richTextBoxName);
        }
        public void NameError(RichTextBox tb)
        {
            button1.Enabled = true;
            if ((!PassNameFormat(tb.Text)) && (tb.Text != ""))
            {
                errorProvider1.SetError(tb, "Тут мають бути тільки букви!");
                button1.Enabled = false;
            }
            else
                errorProvider1.Clear();
        }
        public bool PassNameFormat(string s)
        {
            Regex Sample = new Regex("^[а-яА-ЯёіїІЇЁa-zA-Z]{1,20}$");
            Match Result = Sample.Match(s);
            return Result.Success;
        }

        public bool PassYearFormat(string s)
        {
            Regex Sample = new Regex("^[1-9][0-9]{1,6}$");
            Match Result = Sample.Match(s);
            return Result.Success;
        }

        private void richTextBoxMName_Validating(object sender, CancelEventArgs e)
        {
            NameError(richTextBoxMName);
        }

        private void richTextBoxLName_Validating(object sender, CancelEventArgs e)
        {
            NameError(richTextBoxLName);
        }

        private void richTextBoxYear_Validating(object sender, CancelEventArgs e)
        {
            button1.Enabled = true;
            if ((!PassYearFormat(richTextBoxYear.Text)) && (richTextBoxYear.Text != ""))
            {
                errorProvider1.SetError(richTextBoxYear, "Тут має бути рік, записаний цифрами!");
                button1.Enabled = false;
            }
            else
                errorProvider1.Clear();
        }

    }
}
