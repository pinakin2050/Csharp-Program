using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LINQtoSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creating obj of Data Context class to connect with DB
            CompanyDBDataContext dc = new CompanyDBDataContext();
            
            //Employees is an auto generated table property
            Table<Employee> tab = dc.Employees;

            //This will load table data in the GridView in form
            dataGridView1.DataSource = tab;
        }
    }
}
