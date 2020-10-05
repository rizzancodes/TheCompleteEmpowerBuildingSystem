using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Software_New
{
    public partial class Form1 : Form
    {
        static Form1 _obj;


        public static Form1 Instance
        {

            get
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get
            {
                return panelContainer;
            }
            set
            {
                panelContainer = value;
            }
        }

        //public Button ButtonBack
        //{
        //    get
        //    {
        //        return btnBack;
        //    }
        //    set
        //    {
        //        btnBack = value;
        //    }
        //}


       
        public Form1()
        {
            InitializeComponent();
        }

        private void uC_First_Page1_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // btnBack.Visible = false;
            _obj = this;
            UC_First_Page uc = new UC_First_Page();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string time = class_Timer.get_Time();
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure?", "Exiting The Program", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {

                    Close();
                    MessageBox.Show("You spend a total time of "+time, "Session Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
