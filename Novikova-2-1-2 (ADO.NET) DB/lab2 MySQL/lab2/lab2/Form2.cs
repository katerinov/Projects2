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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string connectionString = "server=10.0.66.224; port=3306; database=Salon_Krasi; user=root; password=123456;charset=cp1251;";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "";
            DataSet data = new DataSet();

            if (radioButtonGet.Checked)
                command = "select*from Vidi_Poslug ";
            //if (radioButtonGet.Checked)
            //command = "select*from [Salon Krasi].[dbo].[Vidi Poslug] where ID=" + richTextBoxID.Text;

            if (radioButtonAdd.Checked)
            {
                command = "insert into Vidi_Poslug (Name,TimeNeeded) values ('" + richTextBoxName.Text + "'," + richTextBoxTime.Text + ");";
                MessageBox.Show("Entry added");
            }
            if (radioButtonUpdate.Checked)
            {
                command = "update Vidi_Poslug set Name='" + richTextBoxName.Text + "', TimeNeeded= " + richTextBoxTime.Text + " where ID=" + richTextBoxID.Text;
                MessageBox.Show("Entry updated");
            }
            if (radioButtonDelete.Checked)
            {
                command = "delete from Vidi_Poslug where ID =" + richTextBoxID.Text;
                MessageBox.Show("Entry deleted by id");
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
            Regex Sample = new Regex("^[а-яА-ЯёЁіІїЇa-zA-Z]{1,20}$");
            Match Result = Sample.Match(s);
            return Result.Success;
        }
        private void richTextBoxName_Validating(object sender, CancelEventArgs e)
        {
            NameError(richTextBoxName);
        }

        private void richTextBoxTime_Validating(object sender, CancelEventArgs e)
        {
            NumberError(richTextBoxTime);
        }
        public void NumberError(RichTextBox tb)
        {
            button1.Enabled = true;
            if ((!PassNumFormat(tb.Text)) && (tb.Text != ""))
            {
                errorProvider1.SetError(tb, "Тут мають бути тільки цифри!");
                button1.Enabled = false;
            }
            else
                errorProvider1.Clear();
        }
        public bool PassNumFormat(string s)
        {
            Regex Sample = new Regex("^[1-9][0-9]{1,6}$");
            Match Result = Sample.Match(s);
            return Result.Success;
        }
        private void radioButtonGet_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxID.Enabled = false;
            richTextBoxName.Enabled = false;
            richTextBoxTime.Enabled = false;
        }

        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxID.Enabled = true;
            richTextBoxName.Enabled = true;
            richTextBoxTime.Enabled = true;
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxID.Enabled = false;
            richTextBoxName.Enabled = true;
            richTextBoxTime.Enabled = true;
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxID.Enabled = true;
            richTextBoxName.Enabled = false;
            richTextBoxTime.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBoxID.Enabled = true;
            richTextBoxName.Enabled = true;
            richTextBoxTime.Enabled = true;
        }
    }
}
