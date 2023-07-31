using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="1234" && txtPassword.Text=="admin")
            {
                MessageBox.Show("Login Successful");
                
                
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
