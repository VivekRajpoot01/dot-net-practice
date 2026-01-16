using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string FileName = openFileDialog1.FileName;
            Assembly assemblyObj = Assembly.LoadFrom(FileName);

            Type[] myType = assemblyObj.GetTypes();
            //this.ReflectAll(myType[0]);
            //Form1.ReflectAll(myType[0]);



        }

        public void ReflectAll(Type typeObj)
        {
            // Getting all methods
            MethodInfo[] methodList = typeObj.GetMethods();

            //getting all properties
            PropertyInfo[] propList = typeObj.GetProperties();

            // load all properties
            foreach(var item in propList)
            {
                listBox1.Items.Add(item);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
