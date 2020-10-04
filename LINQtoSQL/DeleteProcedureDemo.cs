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
    public partial class DeleteProcedureDemo : Form
    {
        CompanyDBDataContext ObjDC;

        public DeleteProcedureDemo()
        {
            InitializeComponent();
        }

        private void LoadDataInGrid()
        {
            ObjDC = new CompanyDBDataContext();
            dgView.DataSource = ObjDC.Employees;
        }

        private void DeleteProcedureDemo_Load(object sender, EventArgs e)
        {
            LoadDataInGrid();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Eno = int.Parse(dgView.SelectedRows[0].Cells[0].Value.ToString());
                    ObjDC.Employee_Delete(Eno);
                    MessageBox.Show("Record deleted successfully!");
                    LoadDataInGrid();
                }
            }
            else
                MessageBox.Show("Please select one Record!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
