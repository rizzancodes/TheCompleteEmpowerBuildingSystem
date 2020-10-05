using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Desktop_Software_New
{
    public partial class UC_Experienced_Page : UserControl
    {
        string baseDirectory = classDirectory.getrootPath()+ @"\Experienced\Connected Exercises";


        public UC_Experienced_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string process1 = baseDirectory + @"\Strength Exercise Connected\Strength Exercise Connected.mp4";
             processStart(process1);
           // MessageBox.Show(process1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_First_Page"))
            {
                UC_First_Page un = new UC_First_Page();

                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UC_First_Page"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void processStart(string str)
        {
            try {
                bool processDir = File.Exists(str);

                //MessageBox.Show(directoryexxx.ToString());
                if(processDir)
                {
                    Process.Start(str);

                }
                else
                {
                    throw new Exception("Unable to open the video. Program is not installed correctly or is at different location!");
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error",MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string process2 = baseDirectory + @"\Balance Exercise Connected\Balance Exercise Connected.mp4";
            processStart(process2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string process3 = baseDirectory + @"\Mobility Exercise Connected\Mobility Exercise Connected.mp4";
            processStart(process3);
        }
    }
}
