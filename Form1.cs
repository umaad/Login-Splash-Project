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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public bool checkentry()

        {
            if(txtuser.Text=="")
            {
                MessageBox.Show("Enter username");
                return false;
            }
            else if(txtpassword.Text=="")
            {
                MessageBox.Show("Enter password");
               return false;
            }
            else if (comboBox1.Text=="")
            {
                MessageBox.Show("Select action");
                return false;
            }
            return true;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
             bool chk = checkentry();
            if (chk==true)
            {
                if (txtuser.Text == "uma")
                {
                    main frm = new main();

                    frm.Show();
                    this.Hide();

                    if (comboBox1.Text == "User")
                    {
                        frm.admin_part.Enabled = false;
                    }
                }
                else
                {
                    count++;
                    MessageBox.Show("Invalid user");
                    if (count==3)
                    Application.Exit();
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
