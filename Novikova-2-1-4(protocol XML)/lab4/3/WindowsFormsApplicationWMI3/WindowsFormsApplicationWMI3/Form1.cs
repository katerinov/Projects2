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
using System.Diagnostics;

namespace WindowsFormsApplicationWMI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string cellValue;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection DGV = this.dataGridView1.SelectedCells;
            for (int i = 0; i <= DGV.Count - 1; i++)
            {
                cellValue = DGV[i].Value.ToString();
                MessageBox.Show(DGV[i].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            ManagementScope S = new ManagementScope(@"\\.\ROOT\cimv2");
            ObjectQuery Q = new ObjectQuery("SELECT * FROM Win32_logicaldisk WHERE drivetype=4");
            ManagementObjectSearcher F = new ManagementObjectSearcher(S, Q);
            ManagementObjectCollection queryCollection = F.Get();
            
            dataGridView1.Columns.Add("col1", "caption");
            dataGridView1.Columns.Add("col2", "descriptions:");
            dataGridView1.Columns.Add("col3", "drivetype");
            foreach (ManagementObject m in queryCollection)//enumerate the collection.
            {
                dataGridView1.Rows.Add( m["Caption"], m["DriveType"], m["Description"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", "/C net use" + cellValue + "/ delete");

        }
    }
}
