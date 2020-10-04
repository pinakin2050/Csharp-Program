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
    public partial class UpdateProcedureDemo : Form
    {
        CompanyDBDataContext ObjDC;
        public UpdateProcedureDemo()
        {
            InitializeComponent();
        }

        private void LoadDataInGrid()
        {
            ObjDC = new CompanyDBDataContext();
            dgView.DataSource = ObjDC.Employees;
        }
        private void UpdateProcedureDemo_Load(object sender, EventArgs e)
        {
            LoadDataInGrid();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(dgView.SelectedRows.Count > 0)
            {
                UpdateForm ObjUpdateForm = new UpdateForm();
                ObjUpdateForm.tbEno.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
                ObjUpdateForm.tbEname.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
                ObjUpdateForm.tbJob.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
                ObjUpdateForm.tbSalary.Text = dgView.SelectedRows[0].Cells[3].Value.ToString();
                ObjUpdateForm.tbDname.Text = dgView.SelectedRows[0].Cells[4].Value.ToString();
                ObjUpdateForm.ShowDialog();
                LoadDataInGrid();
            }
            else
            {
                MessageBox.Show("Please select one record!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
