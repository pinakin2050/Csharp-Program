using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQL
{
    public partial class RowWiseDisplayRecords : Form
    {
        CompanyDBDataContext objDC;
        List<Employee> Emps;
        int RowNo=0;
        public RowWiseDisplayRecords()
        {
            InitializeComponent();
        }

        private void RowWiseDisplayRecords_Load(object sender, EventArgs e)
        {
            objDC = new CompanyDBDataContext();

            //Storing data of table into list.
            Emps = objDC.Employees.ToList();
            DisplayRow();
        }

        private void DisplayRow()
        {
            textBoxEno.Text = Emps[RowNo].Eno.ToString();
            textBoxEname.Text = Emps[RowNo].Ename;
            textBoxJob.Text = Emps[RowNo].Job;
            textBoxSalary.Text = Emps[RowNo].Salary.ToString();
            textBoxDname.Text = Emps[RowNo].Dname;            
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (RowNo > 0)
            {
                --RowNo;
                DisplayRow();
            }
            else
                MessageBox.Show("This is the first record!");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (RowNo < Emps.Count - 1)
            {
                ++RowNo;
                DisplayRow();
            }
            else
                MessageBox.Show("This is the last record!");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
