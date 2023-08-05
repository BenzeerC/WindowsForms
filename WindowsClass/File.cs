using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsClass
{
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Floder is already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Floder is Created");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string path = @"D:\DemoFolder\DemoFile";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("File is Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(txtId.Text));
                binaryWriter.Write(txtName.Text);
                binaryWriter.Write(Convert.ToDouble(txtPrice.Text));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txtId.Text = binaryReader.ReadInt32().ToString();
                txtName.Text = binaryReader.ReadString();
                txtPrice.Text = binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
