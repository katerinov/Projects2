using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Timers;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace WindowsServiceK
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        public static string
            param = "HKEY_LOCAL_MACHINE\\Software\\Task_Queue\\Parameters",
            path = "HKEY_LOCAL_MACHINE\\Software\\Task_Queue",
         claim = "HKEY_LOCAL_MACHINE\\Software\\Task_Queue\\Claims",
          all = "",
         pattern = @"Task_[0-9]{4}";
        public static Random random = new Random();
        public static string[] s = new string[0];
        public static string[] h = new string[0];
        public static List<string> Tasks = new List<string> { };
        public static int percent = 0;
        public static int Count = 2;
        protected override void OnStart(string[] args)
        {
            Registry.SetValue(param, "Task_Execution_Duration", 60, RegistryValueKind.DWord);//X
            Registry.SetValue(param, "Task_Claim_Check_Period", 30, RegistryValueKind.DWord);//every 30 seconds checks
            Registry.SetValue(param, "Task_Execution_Quantity", 1, RegistryValueKind.DWord);//Y



            Registry.SetValue(claim, "Task_9334", "", RegistryValueKind.String);
            Registry.SetValue(claim, "Task_6464", "", RegistryValueKind.String);
            Registry.SetValue(claim, "Task_1553", "", RegistryValueKind.String);
            Registry.SetValue(claim, "Task_2337", "", RegistryValueKind.String);
            Registry.SetValue(claim, "Task_6334", "", RegistryValueKind.String);

            System.Threading.Thread threadClaims = new System.Threading.Thread(ThreadFuncClaims);
            threadClaims.Start();

            System.Threading.Thread threadTaskExec = new System.Threading.Thread(ThreadFuncTaskExec);
            threadTaskExec.Start();

        }

        public static void WriteToLog(string s)
        {

            using (StreamWriter writer = new StreamWriter(@"C:\Windows\Logs\TaskQueue_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".log"))
            {
                DateTime date = new DateTime();
                date = DateTime.Now;
                all = all + s;

                writer.WriteLine(all + date.ToString() + "\n");
            }
        }

        public static void ThreadFuncClaims()
        {
            int timePeriod = 3;

            Timer t1 = new Timer(timePeriod * 1000);
            t1.Elapsed += new ElapsedEventHandler(ThreadWorkingCycle1);
            t1.Enabled = true;
        }

        public static void ThreadFuncTaskExec()
        {
            Timer t2 = new Timer(2 * 1000);
            t2.Elapsed += new ElapsedEventHandler(ThreadWorkingCycle2);
            t2.Enabled = true;
        }

        private static void ThreadWorkingCycle1(object source, ElapsedEventArgs e)
        {
            using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey("Software\\Task_Queue\\Claims", true))
            {
                foreach (string valueName in regKey.GetValueNames())
                {
                    Tasks.Add(valueName);
                }
            }
            Tasks.Sort();

            while (Tasks.Count > 1)
            {
                if (Regex.IsMatch(Tasks[0], pattern))
                {
                    RegistryKey regKey = Registry.LocalMachine.OpenSubKey("Software\\Task_Queue\\Claims", true);
                    regKey.DeleteValue(Tasks[0]);
                    regKey.Close();
                    Registry.SetValue(path, Tasks[0] + "-[....................]-Queued ", "", RegistryValueKind.String);
                    WriteToLog("Задача Task_" + Tasks[0] + " успішно прийнята в обробку...");
                }
                else
                {
                    WriteToLog("ПОМИЛКА розміщення заявки " + Tasks[0] + " Некоректний синтаксис ...");
                }
                Tasks.Clear();
            }
        }

        private static void ThreadWorkingCycle2(object source, ElapsedEventArgs e)
        {
            int sticks;
            int totaltime = (int)Registry.GetValue(param, "Task_Execution_Duration", 60);

            using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey("Software\\Task_Queue", true))
            {
                h = regKey.GetValueNames();
            }
            {
                for (int i = 0; i < h.Length; i++)
                {
                    if (h[i].IndexOf("Queued") > -1)
                    {
                        if (Count > 0)
                        {
                            using (RegistryKey tempKey = Registry.LocalMachine.OpenSubKey("Software\\Task_Queue", true))
                            {
                                tempKey.DeleteValue(h[i]);
                                tempKey.SetValue(h[i].Substring(0, 10) + new string('.', 20) + "  In progress - 0 % percent", "");
                            }
                            Count--;
                        }
                    }

                    if (h[i].IndexOf("progress") > -1)
                    {
                        using (RegistryKey tempKey = Registry.LocalMachine.OpenSubKey("Software\\Task_Queue", true))
                        {
                            string[] m = h[i].Split(' ');

                            percent = Int32.Parse(m[5]) + (200 / totaltime);
                            sticks = percent / 5;
                            if (percent < 100)
                            {
                                tempKey.DeleteValue(h[i]);
                                tempKey.SetValue(h[i].Substring(0, 10) + new string('I', sticks) + new string('.', 20 - sticks) + "  In progress - " + percent + " % percent", "");

                            }
                            else
                            {
                                tempKey.DeleteValue(h[i]);
                                tempKey.SetValue(h[i].Substring(0, 10) + " Completed", "");
                                WriteToLog(h[i].Substring(0, 10) + " Нуспішно ВИКОНАНА! ...");
                                Count++;
                            }
                        }
                    }

                }
            }
        }

        protected override void OnStop()
        {
        }
    }
}
