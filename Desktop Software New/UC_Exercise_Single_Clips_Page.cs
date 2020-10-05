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
    public partial class UC_Exercise_Single_Clips_Page : UserControl
    {
        public UC_Exercise_Single_Clips_Page()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_Exercise_Page"))
            {
                UC_Exercise_Page un = new UC_Exercise_Page();

                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UC_Exercise_Page"].BringToFront();
        }
    }
}
