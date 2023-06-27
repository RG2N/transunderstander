using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transunderstander
{
    public partial class Form1 : Form
    {
        string Cversion = "1.0.0";

        public Form1()
        {
            InitializeComponent();
            using (WebClient client = new WebClient())
            {
                string downloadString = client.DownloadString("https://raw.githubusercontent.com/RG2N/transunderstander/main/latestversion");
                if (downloadString != Cversion)
                {
                    DialogResult dialogResult = MessageBox.Show("Your application is out of date! Current Version: v" + Cversion + " Latest Version: v" + downloadString + " Would you like to go to the latest download?", "Out of date version!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://github.com/RG2N/transunderstander/releases");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        // Nothing
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                if (checkBox3.Checked == true)
                {
                    MessageBox.Show("Guy ---> Guy", "Not Transgender!");
                    // They are not transgender: Guy --> Guy
                }
                if (checkBox4.Checked == true)
                {
                    // They are transgender: Guy --> Girl
                    MessageBox.Show("Guy ---> Girl", "Transgender!");
                }
            } else if (checkBox2.Checked == true)
            {
                if (checkBox3.Checked == true)
                {
                    // They are transgender: Girl --> Guy
                    MessageBox.Show("Girl ---> Guy", "Transgender!");
                }
                if (checkBox4.Checked == true)
                {
                    // They are not transgender: Girl --> Girl
                    MessageBox.Show("Girl ---> Girl", "Not Transgender!");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
            }
        }
    }
}
