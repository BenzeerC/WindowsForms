using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Binary Serilization
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
// xml serilization
using System.Xml.Serialization;
// Soap serilization
using System.Runtime.Serialization.Formatters.Soap;
//Json serilization
using System.Text.Json;

namespace WindowsClass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBWrite1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Prod.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(textBox1.Text);
                p1.Name = textBox2.Text;
                p1.Price = Convert.ToInt32(textBox3.Text);
                binaryFormatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Prod.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Product p1 = new Product();
                p1=(Product)binaryFormatter.Deserialize(fileStream);
               textBox1.Text=p1.Id.ToString();
                textBox2.Text=p1.Name.ToString();
                textBox3.Text=p1.Price.ToString();
                //binaryFormatter.Serialize(fileStream, p1);
                fileStream.Close();
                //MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Prod.xml";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                XmlSerializer serializer = new XmlSerializer(typeof(Product));
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(textBox1.Text);
                p1.Name = textBox2.Text;
                p1.Price = Convert.ToInt32(textBox3.Text);
                serializer.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Prod.xml";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
               XmlSerializer serializer1 = new XmlSerializer(typeof(Product));
                Product p1 = new Product();
                p1 = (Product)serializer1.Deserialize(fileStream);
                textBox1.Text = p1.Id.ToString();
                textBox2.Text = p1.Name.ToString();
                textBox3.Text = p1.Price.ToString();
                //serializer1.Serialize(fileStream, p1);
                fileStream.Close();
                //MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Prod.soap";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(textBox1.Text);
                p1.Name = textBox2.Text;
                p1.Price = Convert.ToInt32(textBox3.Text);
                soapFormatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Prod.soap";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter1 = new SoapFormatter();
                Product p1 = new Product();
                p1 = (Product)soapFormatter1.Deserialize(fileStream);
                textBox1.Text = p1.Id.ToString();
                textBox2.Text = p1.Name.ToString();
                textBox3.Text = p1.Price.ToString();
                //serializer1.Serialize(fileStream, p1);
                fileStream.Close();
                //MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Prod.json";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
               
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(textBox1.Text);
                p1.Name = textBox2.Text;
                p1.Price = Convert.ToInt32(textBox3.Text);
                JsonSerializer.Serialize<Product>(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DemoFolder\Prod.json";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                //SoapFormatter soapFormatter1 = new SoapFormatter();
                Product p1 = new Product();
                p1 = (Product)JsonSerializer.Deserialize<Product>(fileStream);
                textBox1.Text = p1.Id.ToString();
                textBox2.Text = p1.Name.ToString();
                textBox3.Text = p1.Price.ToString();
                //serializer1.Serialize(fileStream, p1);
                fileStream.Close();
                //MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
