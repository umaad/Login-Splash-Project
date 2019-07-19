using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; 


namespace login_s
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            lbdate.Text = DateTime.Today.ToLongDateString();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
           
        }
       
        private void lbtime_Click(object sender, EventArgs e)
        {
            
            lbtime.Text = DateTime.Now.ToLongTimeString();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
           


        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void blockUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blockuser frm = new blockuser();
            frm.MdiParent = this;
            frm.Show();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createuser frm = new createuser();
            frm.MdiParent = this;
            frm.Show();

        }

        private void introductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void facilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
