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
    public partial class CRUD : Form
    {
        CompanyDBDataContext ObjDC;
        DataFormForCRUD ObjCrudForm;

        public CRUD()
        {
            InitializeComponent();
        }

        //Method to load data into grid.
        private void LoadData()
        {
            ObjDC = new CompanyDBDataContext();
            dgView.DataSource = ObjDC.Employees;
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            ObjCrudForm = new DataFormForCRUD();
            ObjCrudForm.ShowDialog();
            
            //Loading data again to display newly insterted records.
            LoadData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                ObjCrudForm = new DataFormForCRUD();
                ObjCrudForm.textBoxEno.ReadOnly = true;
                ObjCrudForm.BtnClear.Enabled = false;
                ObjCrudForm.BtnSave.Text = "Update";
                ObjCrudForm.textBoxEno.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
                ObjCrudForm.textBoxEname.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
                ObjCrudForm.textBoxJob.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
                ObjCrudForm.textBoxSalary.Text = dgView.SelectedRows[0].Cells[3].Value.ToString();
                ObjCrudForm.textBoxDname.Text = dgView.SelectedRows[0].Cells[4].Value.ToString();
                ObjCrudForm.ShowDialog();
                LoadData();
            }
            else
                MessageBox.Show("Please select a record!","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this record?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Eno =  Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value);
                    Employee ObjEmployee = ObjDC.Employees.SingleOrDefault(E => E.Eno == Eno);
                    ObjDC.Employees.DeleteOnSubmit(ObjEmployee);
                    ObjDC.SubmitChanges();
                    MessageBox.Show("Record deleted successfully!");
                    LoadData();
                }
            }
            else
                MessageBox.Show("Please select a record!","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
