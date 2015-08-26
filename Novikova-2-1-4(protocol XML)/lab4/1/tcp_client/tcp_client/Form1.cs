using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;

namespace tcp_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string cellValue;

        private void b1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            string filter = tb1.Text,
             pathToXml = @"XMLFilterREQ1.xml";

            CreateXML(pathToXml, filter);

            WriteRequest(Speaking(@"XMLFilterREQ1.XML"));//working with filter xml file
            XmlDocument D = new XmlDocument();

            //using (StreamWriter F = new StreamWriter(@"SurNamesRESP1.XML", false, Encoding.GetEncoding(1251))){   }


            D.Load(@"SurNamesREQ1COPY.XML");//loading the final xml file
            int i = 1;
            dataGridView1.Columns.Add("column", "Last Names");
            foreach (XmlNode v in D.SelectNodes("head/KIStudents/Student"))
            {
                dataGridView1.Rows.Add(v["SurName"].InnerText);
                i++;
            }
        }

        protected string Answer;

        public string Speaking(string XmlPath)
        {
            string F = File.ReadAllText(XmlPath, Encoding.GetEncoding(1251));//reading small xml file
            byte[] M = Encoding.GetEncoding(1251).GetBytes(F);//turning small xml file to array of bytes
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("10.0.66.157"), 40000);
            byte[] bytes = new byte[1000000];
            using (Socket S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                S.Connect(ipEndPoint);//connecting to server
                S.Send(M);//sending small xml file

                int bytesRec = S.Receive(bytes);
                Answer = Encoding.GetEncoding(1251).GetString(bytes, 0, bytesRec);
                return Answer;
            }
        }

        private static void WriteRequest(string z)
        {
            using (StreamWriter F = new StreamWriter(@"SurNamesREQ1COPY.XML", false, Encoding.GetEncoding(1251)))
            {
                F.WriteLine(z);
            }
        }



        private static void WriteRequest2(string z)
        {
            using (StreamWriter F = new StreamWriter(@"FirstNamesREQ2COPY.XML", false, Encoding.GetEncoding(1251)))
            {
                F.WriteLine(z);
            }
        }
        public static void CreateXML(string pathXML, string ourFilter)
        {
            string pattern1 = "^[а-яА-ЯёЁіІїЇ]{1,20}$";

            XmlTextWriter textWritter = new XmlTextWriter(pathXML, Encoding.GetEncoding(1251));
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("head");
            textWritter.WriteEndElement();
            textWritter.Close();

            XmlDocument document = new XmlDocument();
            document.Load(pathXML);
            XmlNode element = document.CreateElement("filters");
            document.DocumentElement.AppendChild(element); // указываем родителя

            if (Regex.IsMatch(ourFilter, pattern1))
            {
                XmlNode filter2 = document.CreateElement("filter");
                filter2.InnerText = ourFilter;
                element.AppendChild(filter2);
            }
            else if (ourFilter.Contains('*') && (ourFilter.Substring(0, 1) != "*"))
            {
                XmlNode filter1 = document.CreateElement("filter");
                filter1.InnerText = ourFilter;
                element.AppendChild(filter1);
            }
            else
            {
                switch (ourFilter)
                {
                    case "*ов":
                        XmlNode filter3 = document.CreateElement("filter");
                        filter3.InnerText = "*ов";
                        element.AppendChild(filter3);
                        break;
                    case "*":
                        XmlNode filter4 = document.CreateElement("filter");
                        filter4.InnerText = "*";
                        element.AppendChild(filter4);
                        break;
                }
            }
            document.Save(pathXML);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            
            CreateXML(@"FirstNamesREQ2.xml", cellValue);
            WriteRequest2(Speaking(@"FirstNamesREQ2.XML"));//working with filter xml file

            using (StreamWriter F = new StreamWriter(@"FirstNamesRESP2.XML", false, Encoding.GetEncoding(1251)))
            {
            }
            XmlDocument D = new XmlDocument();
            D.Load(@"FirstNamesREQ2COPY.XML");//loading the final xml file
            int i = 1;
            foreach (XmlNode v in D.SelectNodes("head/KIStudents/Student"))
            {
                dataGridView1.Columns.Add("column1", " First name");
                dataGridView1.Columns.Add("column2", " Last name ");
                dataGridView1.Rows.Add(v["FirstName"].InnerText,v["SurName"].InnerText);
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewSelectedCellCollection DGV = this.dataGridView1.SelectedCells;
            for (int i = 0; i <= DGV.Count - 1; i++)
            {
                cellValue = DGV[i].Value.ToString();
            }
            b2.Enabled=true;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
