using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Desktop_Software_New
{
    public partial class UC_New_To_Program : UserControl
    {
        string baseDirectory = classDirectory.getrootPath() + @"\New To The Program";
        public UC_New_To_Program()
        {
            InitializeComponent();
            btn2_lbl.Visible = false;
            btn3_lbl.Visible = false;
            btn4_lbl.Visible = false;
            btn5_lbl.Visible = false;
            btn6_lbl.Visible = false;
            panel1.Visible = false;
            button_WOC2.Visible = false;
            button_WOC3.Visible = false;
            button_WOC4.Visible = false;
            button_WOC5.Visible = false;
            button_WOC6.Visible = false;
            


        }

        private void button1_Click(object sender, EventArgs e)
        {


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

        private void UC_New_To_Program_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            

           string process1 = baseDirectory + @"\1- Disclaimer.mp4";
           processStart(process1);
            //    MessageBox.Show(process1);
            button_WOC2.Visible = true;
            btn2_lbl.Visible = true;



        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            

            string process1 = baseDirectory + @"\2- Program Manual\File.pdf";
            processStart(process1);
            btn3_lbl.Visible = true;
            button_WOC3.Visible = true;
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
           

            string process1 = baseDirectory + @"\3- Watch this part 1\WF 1.mp4";
            processStart(process1);
            btn4_lbl.Visible = true;
            button_WOC4.Visible = true;
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            

            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_Exercise_Page"))
            {
                UC_Exercise_Page un = new UC_Exercise_Page();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UC_Exercise_Page"].BringToFront();

            btn5_lbl.Visible = true;
            button_WOC5.Visible = true;





        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
          

            string process1 = baseDirectory + @"\5- Watch this part 2\WF 2.mp4";
            processStart(process1);
            btn6_lbl.Visible = true;
            button_WOC6.Visible = true;
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            

            string process1 = baseDirectory + @"\6- Watch this part 3\WF 3.mp4";
            processStart(process1);
            panel1.Visible = true;



        }
        private void processStart(string str)
        {
            try
            {
                bool processDir = File.Exists(str);

                //MessageBox.Show(directoryexxx.ToString());
                if (processDir)
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
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }



    }
}
