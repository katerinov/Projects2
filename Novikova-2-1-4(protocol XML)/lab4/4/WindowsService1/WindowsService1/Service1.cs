using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.IO;
using Microsoft.Win32;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        //ManagementEventWatcher W1, W2, W3;

        protected override void OnStart(string[] args)
        {
            //WqlEventQuery Q1 = new WqlEventQuery("SELECT * FROM __InstanceOperationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_Process' AND TargetInstance.Name='DNSCache.exe' ");
            //W1 = new ManagementEventWatcher(Q1);
            //W1.EventArrived += new EventArrivedEventHandler(OnDNSCacheChanged);
            //W1.Start();

            //WqlEventQuery Q2 = new WqlEventQuery("SELECT * FROM RegistryKeyChangeEvent WHERE Hive = 'HKEY_LOCAL_MACHINE'" + @"AND KeyPath = 'SOFTWARE\\LABA4'");
            //W2 = new ManagementEventWatcher(Q2);
            //W2.EventArrived += new EventArrivedEventHandler(OnRegChanged);
            //W2.Start();

            //WqlEventQuery Q3 = new WqlEventQuery(
            //        "SELECT * FROM __InstanceOperationEvent Within 2 Where TargetInstance ISA 'CIM_DataFile' And TargetInstance.Drive='C:' And " + @"TargetInstance.Path='\\LABA4\\TEST\\'");
            //W3 = new ManagementEventWatcher(Q3);
            //W3.EventArrived += new EventArrivedEventHandler(OnFolderChanged);
            //W3.Start();

            System.Threading.Thread.Sleep(300000);
        }
        private static void OnDNSCacheChanged(object source, EventArrivedEventArgs e)
        {
            using (StreamWriter F = new StreamWriter("C:\\LABA4\\Laba-4.log", true))
            {
                F.WriteLine(DateTime.Now + " DNSCache.exe proccess changed");
            }
        }

        private static void OnRegChanged(object source, EventArrivedEventArgs e)
        {
            using (StreamWriter F = new StreamWriter("C:\\LABA4\\Laba-4.log", true))
            {
                F.WriteLine(DateTime.Now + " HKEY_LOCAL_MACHINE\\Software\\LABA4 changed");
            }
        }

        private static void OnFolderChanged(object source, EventArrivedEventArgs e)
        {
            using (StreamWriter F = new StreamWriter("C:\\LABA4\\Laba-4.log", true))
            {
                F.WriteLine(DateTime.Now + " C:\\LABA4\\TEST changed");
            }
        }


        protected override void OnStop()
        {
            //W1.Stop();
            //W2.Stop();
            //W3.Stop();
        }
    }
}
