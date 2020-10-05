using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desktop_Software_New
{
    public partial class UC_Exercise_Page : UserControl
    {
        public UC_Exercise_Page()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_Experienced_Page"))
            {
                UC_Experienced_Page un = new UC_Experienced_Page();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UC_Experienced_Page"].BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_New_To_Program"))
            {
                UC_New_To_Program un = new UC_New_To_Program();

                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UC_New_To_Program"].BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_Exercise_Single_Clips_Page"))
            {
                UC_Exercise_Single_Clips_Page un = new UC_Exercise_Single_Clips_Page();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UC_Exercise_Single_Clips_Page"].BringToFront();
        }
    }
}
