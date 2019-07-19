using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_s
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            txtprogress.Text = progressBar1.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            txtprogress.Text = progressBar1.Value.ToString();
            this.progressBar1.Value= this.progressBar1.Value+1; 
            if(progressBar1.Value==10)
            {
                lblprogress.Text = "starting up";
                //txtprogress.Text = progressBar1.Value.ToString();
            }
            else if (progressBar1.Value==30)
            {
                lblprogress.Text = "starting module";
                //txtprogress.Text = progressBar1.Value.ToString();
            }
            else if (progressBar1.Value == 50)
            {
                lblprogress.Text = "loading module";
                //txtprogress.Text = progressBar1.Value.ToString();
            }
            else if (progressBar1.Value == 70)
            {
                lblprogress.Text = "loading module";
                //txtprogress.Text = progressBar1.Value.ToString();
            }
            else if (progressBar1.Value == 90)
            {
                lblprogress.Text = "finishing up";
                //txtprogress.Text = progressBar1.Value.ToString();
            }
            else if (progressBar1.Value == 98)
            {
                txtprogress.Text = progressBar1.Value.ToString();
               // MessageBox.Show("Loading Complete");
                frm.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }

        private void txtprogress_TextChanged(object sender, EventArgs e)
        {
           // txtprogress.Text = "%";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
