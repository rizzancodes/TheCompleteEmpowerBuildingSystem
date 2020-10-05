using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Software_New
{
    public partial class START : Form
    {
        class_Timer cls = new class_Timer();
        public START()
        {
            InitializeComponent();
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                SystemSounds.Exclamation.Play();
                cls.start_Timer();
                
                //showForm(new Form1());
                //this.Hide();

                this.Hide();
                Form1 sistema = new Form1();
                sistema.ShowDialog();
                this.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        
        }

        private void showForm(Form form)
        {
            
            form.Show();

        }


    }
}
