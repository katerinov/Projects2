using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static string cellValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //COLLECTION
            ManagementScope S = new ManagementScope(@"\\.\ROOT\cimv2");

            //create object query
            ObjectQuery Q = new ObjectQuery("SELECT * FROM Win32_Process");

            //create object searcher
            ManagementObjectSearcher F = new ManagementObjectSearcher(S, Q);

            //get collection of WMI objects
            ManagementObjectCollection queryCollection = F.Get();

            dataGridView1.Columns.Add("col1", "Descriptions:");
            //dataGridView1.Columns.Add("col2", "ExecutablePaths");, m["ExecutablePath"]
            foreach (ManagementObject m in queryCollection)//enumerate the collection.
            {
               
                // access properties of the WMI object
                dataGridView1.Rows.Add(m["Description"]);
                //if ((m["Description"]).ToString().ToLower() == "calc.exe")
                //{
                //    object[] IN = { 128 };
                //    object R = m.InvokeMethod("SetPriority", IN);
                //}
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection DGV = this.dataGridView1.SelectedCells;
            for (int i = 0; i <= DGV.Count - 1; i++)
            {
                cellValue = DGV[i].Value.ToString();
                MessageBox.Show(DGV[i].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //COLLECTION
            ManagementScope S = new ManagementScope(@"\\.\ROOT\cimv2");

            //create object query
            ObjectQuery Q = new ObjectQuery("SELECT * FROM Win32_Process");

            //create object searcher
            ManagementObjectSearcher F = new ManagementObjectSearcher(S, Q);

            //get collection of WMI objects
            ManagementObjectCollection queryCollection = F.Get();

            //dataGridView1.Columns.Add("col2", "Descriptions:");
            foreach (ManagementObject m in queryCollection)//enumerate the collection.
            {
                // access properties of the WMI object
                if ((m["Description"]).ToString().ToLower() == cellValue)
                    //m.InvokeMethod("Terminate", null);
                    MessageBox.Show((m["Description"]).ToString());
                //dataGridView1.Rows.Add(m["Description"]);
            }
        }

    }
}
