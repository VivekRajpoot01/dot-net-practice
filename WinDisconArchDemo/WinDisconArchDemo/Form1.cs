using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDisconArchDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductUtility prodObj = new ProductUtility();
            dataGridView1.DataSource = prodObj.ShowAll();


            //ProductUtility pUtil = new ProductUtility();
            //DataTable myDt = pUtil.GetAllData();

            //Binding ui element with table column
            txtProdId.DataBindings.Add("Text", myDt, myDt.Columns[0].ColumnName);
            txtProdName.DataBindings.Add("Text", myDt, myDt.Columns[1].ColumnName);
            txtProdPrice.DataBindings.Add("Text", myDt, myDt.Columns[2].ColumnName);
            txtProdDescription.DataBindings.Add("Text", myDt, myDt.Columns[4].ColumnName);
            
        }

        private void btnShowAllProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
