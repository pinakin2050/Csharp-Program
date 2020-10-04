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
    public partial class UpdateForm : Form
    {
        CompanyDBDataContext ObjDC;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ObjDC = new CompanyDBDataContext();
            ObjDC.Employee_Update(int.Parse(tbEno.Text),tbEname.Text,tbJob.Text,decimal.Parse(tbSalary.Text),tbDname.Text);
            MessageBox.Show("Record Updated Successfully!");
        }
    }
}
