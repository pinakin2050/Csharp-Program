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
    public partial class InsertProcedureDemo : Form
    {
        CompanyDBDataContext ObjDC;
        public InsertProcedureDemo()
        {
            InitializeComponent();
        }

        private void InsertProcedureDemo_Load(object sender, EventArgs e)
        {
            ObjDC = new CompanyDBDataContext();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //? represents that it can be null
            int? Eno = null;
            ObjDC.Employee_Insert(tbEname.Text,tbJob.Text,decimal.Parse(tbSalary.Text),tbDname.Text,ref Eno);
            tbEno.Text = Eno.ToString();
            MessageBox.Show("Record inserted Successfully!");//,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            tbEname.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
