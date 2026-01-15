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

// For Binary Serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

// For SOAP Serialization
using System.Runtime.Serialization.Formatters.Soap;
namespace WinSerializeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtID.Text);
            emp1.Name = textName.Text;
            emp1.Salary = Convert.ToInt32(textSalary.Text);

            //Binary Serialization Code Below
            FileStream fs = new FileStream(@"C:\Users\vivek\dot-net\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,emp1);

            foreach(Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
            fs.Close();
            MessageBox.Show("Record Added");
        }

        private void btnDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\vivek\dot-net\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            Employee emp1 = (Employee) bf.Deserialize(fs);
            //Employee emp1 = new Employee();
            txtID.Text = emp1.ID.ToString();
            textName.Text = emp1.Name;
            textSalary.Text = emp1.Salary.ToString(); 
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtID.Text);
            emp1.Name = textName.Text;
            emp1.Salary = Convert.ToInt32(textSalary.Text);

            //XML Serialization Code Below
            FileStream fs = new FileStream(@"C:\Users\vivek\dot-net\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp1);
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\vivek\dot-net\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer xs = new XmlSerializer();

            Employee emp1 = (Employee)bf.Deserialize(fs);
            //Employee emp1 = new Employee();
            txtID.Text = emp1.ID.ToString();
            textName.Text = emp1.Name;
            textSalary.Text = emp1.Salary.ToString();
        }

        private void btnSoapSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtID.Text);
            emp1.Name = textName.Text;
            emp1.Salary = Convert.ToInt32(textSalary.Text);

            //Binary Serialization Code Below
            FileStream fs = new FileStream(@"C:\Users\vivek\dot-net\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, emp1);

            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
            fs.Close();
            MessageBox.Show("Record Added");
        }

        private void btnSoapDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\vivek\dot-net\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            SoapFormatter bf = new SoapFormatter();

            Employee emp1 = (Employee)bf.Deserialize(fs);
            //Employee emp1 = new Employee();
            txtID.Text = emp1.ID.ToString();
            textName.Text = emp1.Name;
            textSalary.Text = emp1.Salary.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
