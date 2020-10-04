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
    public partial class DataFormForCRUD : Form
    {
        CompanyDBDataContext ObjDC;
        Employee ObjEmployee;

        public DataFormForCRUD()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ObjDC = new CompanyDBDataContext();

            if (textBoxEno.ReadOnly == false)
            {
                ObjEmployee = new Employee()
                {
                    Eno = int.Parse(textBoxEno.Text),
                    Ename = textBoxEname.Text,
                    Job = textBoxJob.Text,
                    Salary = decimal.Parse(textBoxSalary.Text),
                    Dname = textBoxDname.Text
                };
            
                //This code will insert data into the table but data is not committed yet.
                ObjDC.Employees.InsertOnSubmit(ObjEmployee);

                //This code will commit the changes.
                ObjDC.SubmitChanges();

                MessageBox.Show("Record inserted successfully!");
            }
            else
            {
                //To update a record we need to refer to already existing record
                //We can get it by SingleOrDefault method. Using lamba to find the matching record based on Eno
                ObjEmployee = ObjDC.Employees.SingleOrDefault(AliasEmployee => AliasEmployee.Eno == int.Parse(textBoxEno.Text));
                ObjEmployee.Ename = textBoxEname.Text;
                ObjEmployee.Job = textBoxJob.Text;
                ObjEmployee.Salary = decimal.Parse(textBoxSalary.Text);
                ObjEmployee.Dname = textBoxDname.Text;
                ObjDC.SubmitChanges();
                MessageBox.Show("Record updated successfully!");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            textBoxEno.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
