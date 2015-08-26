using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Security.AccessControl;
using System.ServiceProcess;


namespace WindowsServicetcp
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        public static RegistryKey regKey = Registry.LocalMachine.OpenSubKey("Software\\SEARCH-Server", true);
        public static Thread T;
        public static bool mustStop;
        public static bool req1 = true;
        public static bool req2 = false;
        protected override void OnStart(string[] args)
        {
            //using (RegistryKey regKey = Registry.LocalMachine.CreateSubKey("Software\\SEARCH-Server"))
            //{
            //    regKey.SetValue("01", "Анніков Дмитро");
            //    regKey.SetValue("02", "Бондарева Тетяна");
            //    regKey.SetValue("03", "Белая Ірина");
            //    regKey.SetValue("04", "Бігун Сергій");
            //}

            T = new Thread(WorkerThread);
            T.Start();
        }
        public static void WorkerThread()
        {
            while (!mustStop)
            {
                WriteNames(regKey.ValueCount.ToString());
                WriteRequest(regKey.GetValueNames().ToString());
                IPAddress IP = IPAddress.Parse("10.0.66.157");
                IPEndPoint ipEndPoint = new IPEndPoint(IP, 40000);
                Socket S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    S.Bind(ipEndPoint);
                    S.Listen(10);
                    int i = 0;
                    string filter = "";

                    while (true)
                    {
                        using (Socket H = S.Accept())
                        {
                            string newpath = "";
                            IPEndPoint L = new IPEndPoint(IP, 0);
                            EndPoint R = (EndPoint)(L);
                            byte[] D = new byte[10000];
                            int Receive = H.ReceiveFrom(D, ref R);// getting the xml with filters

                            string Request = Encoding.GetEncoding(1251).GetString(D, 0, Receive);//turning it to string
                            WriteRequest(Request);//saving it to the log

                            filter = ParsingXML();//getting the filter from the log

                            if ((!req2) && (req1))//if its the first request
                            {
                                newpath = @"SurNamesRESP1.xml";
                                GetStudentsByFilter(filter);//getting students by the filter
                            }
                            else//if its the second request
                            {
                                newpath = @"FirstNamesRESP2.xml";
                                GetStudentsBySurName(filter);//getting students by surname
                            }
                            string W = File.ReadAllText(newpath, Encoding.GetEncoding(1251));//getting students' surnames

                            byte[] M = Encoding.GetEncoding(1251).GetBytes(W);

                            H.Send(M);//sending the student's surnames

                            H.Shutdown(SocketShutdown.Both);
                            i++;
                        }
                    }
                }
                catch (Exception e)
                {
                    WriteRequest(e.Message);
                }
            }
        }

        private static void GetStudentsByFilter(string filtr)
        {
            int i = 0;
            string[] s = new string[regKey.ValueCount];
            string val = "";
            string pattern1 = "^[а-яА-ЯёЁіІїЇ]{1,20}$";
            string[] splits = new string[10];


            WriteNames(regKey.ValueCount.ToString());

            if (filtr == "*")
            {
                foreach (string elem in regKey.GetValueNames())
                {
                    splits = (regKey.GetValue(elem)).ToString().Split(' ');
                    val = splits[0];
                    s[i] = val;
                    i++;
                }
            }
            else if (filtr == "*ов")
            {
                foreach (string elem in regKey.GetValueNames())
                {
                    splits = (regKey.GetValue(elem)).ToString().Split(' ');
                    val = splits[0];
                    if (val.Contains("ов"))
                    {
                        s[i] = val;
                        i++;
                    }
                }
            }
            else if (filtr.Contains('*') && (filtr.Substring(0, 1) != "*"))
            {
                foreach (string elem in regKey.GetValueNames())
                {
                    splits = (regKey.GetValue(elem)).ToString().Split(' ');
                    val = splits[0];
                    if (val.Contains(filtr.TrimEnd('*')))
                    {
                        s[i] = val;
                        i++;
                    }
                }
            }
            else if (Regex.IsMatch(filtr, pattern1))
            {
                foreach (string elem in regKey.GetValueNames())
                {
                    splits = (regKey.GetValue(elem)).ToString().Split(' ');
                    val = splits[0];
                    if (val == filtr)
                    {
                        s[i] = val;
                        i++;
                    }
                }
            }
            CreateXML(@"SurNamesRESP1.xml", s);
            req1 = false;
            req2 = true;
        }

        private static void WriteNames(string z)
        {
            using (StreamWriter F = new StreamWriter(@"NEWNAMES.log", false, Encoding.GetEncoding(1251)))
            {
                F.WriteLine(z);
            }
        }
        private static void GetStudentsBySurName(string surname)
        {
            int i = 0;
            string[] s = new string[regKey.ValueCount];

            foreach (string elem in regKey.GetValueNames())
            {
                if (regKey.GetValue(elem).ToString().Contains(surname))
                {
                    s[i] = (regKey.GetValue(elem)).ToString();
                    i++;
                }
            }
            CreateXML(@"FirstNamesRESP2.xml", s);
            req2 = false;
            req1 = true;
        }

        public static void CreateXML(string pathXML, string[] mas)
        {
            int i = 0;
            XmlNode[] Students = new XmlNode[mas.Length];
            XmlNode[] SurNames = new XmlNode[mas.Length];
            XmlNode[] FirstNames = new XmlNode[mas.Length];

            XmlTextWriter textWritter = new XmlTextWriter(pathXML, Encoding.GetEncoding(1251));
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("head");
            textWritter.WriteEndElement();
            textWritter.Close();

            XmlDocument document = new XmlDocument();
            document.Load(pathXML);
            XmlNode element = document.CreateElement("KIStudents");
            document.DocumentElement.AppendChild(element); // указываем родителя

            while (i < mas.Length)
            {
                if (mas[i] != null)
                {
                    Students[i] = document.CreateElement("Student");
                    element.AppendChild(Students[i]);

                    SurNames[i] = document.CreateElement("SurName"); // даём имя
                    SurNames[i].InnerText = mas[i].Split(' ')[0]; // и значение
                    Students[i].AppendChild(SurNames[i]); // и указываем кому принадлежит

                    if (req2)
                    {
                        FirstNames[i] = document.CreateElement("FirstName"); // даём имя
                        FirstNames[i].InnerText = mas[i].Split(' ')[1]; // и значение
                        Students[i].AppendChild(FirstNames[i]); // и указываем кому принадлежит
                    }
                }
                i++;
            }
            document.Save(pathXML);
        }

        private static void WriteRequest(string z)
        {
            if (!File.Exists(@"XMLfilterRESP1.log"))
                using (File.Create(@"XMLfilterRESP1.log")) { }
            using (StreamWriter F = new StreamWriter(@"XMLfilterRESP1.log", false, Encoding.GetEncoding(1251)))
            {
                F.WriteLine(z);
            }
        }

        private static string ParsingXML()
        {
            string z = File.ReadAllText(@"XMLfilterRESP1.log", Encoding.GetEncoding(1251));
            int start_position = 0;
            int end_position = 0;
            int length = 0;
            string filt = "";
            if (z.Contains("<filter>"))
            {
                start_position = z.IndexOf("<filter>") + 8;
                end_position = z.IndexOf("</filter>");
                length = end_position - start_position;
                filt = z.Substring(start_position, length);
                return filt;
            }
            else
                return "nothing";
        }
        protected override void OnStop()
        {
            if((T!=null)&&(T.IsAlive))
            {
                mustStop=true;
            }
        }
    }
}
