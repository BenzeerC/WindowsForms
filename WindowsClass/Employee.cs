﻿using System;
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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "HR", "Admin", "Development", "Testing", "Sales" };
            cmbDepartment.DataSource= list;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bs=Convert.ToDouble(txtBasic.Text);
            double da = bs * 0.10;
            double hra = bs * 0.40;
            double pf = bs * 0.10;
            double pt = bs * 0.11;

            double gross = (bs + da + hra) - (pf + pt);

            txtDA.Text = gross.ToString();
            txtHra.Text = hra.ToString();
            txtPf.Text = pf.ToString();
            txtProfTax.Text = pt.ToString();
            txtGross.Text = gross.ToString();



        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Id:"+txtEmpId.Text+" \n"+"Employee Name:"+txtEmployeeName.Text+"\n "+"Department"+cmbDepartment.Text+"\n "+"Basic Salary"+
                txtBasic.Text+"\n"+"Gross Salary"+txtGross.Text);
        }
    }
}
