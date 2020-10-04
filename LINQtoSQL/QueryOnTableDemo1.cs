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
    public partial class QueryOnTableDemo1 : Form
    {
        CompanyDBDataContext ObjDC;
        
        //Maintaining this flag so that combo box can be activated after grid data is loaded 
        //Else the filter will be applied by default
        bool cbJobFlag = false;

        public QueryOnTableDemo1()
        {
            InitializeComponent();
        }

        private void QueryOnTableDemo1_Load(object sender, EventArgs e)
        {
            ObjDC = new CompanyDBDataContext();

            //Loading all data of Emp table in grid
            dgView.DataSource = from E in ObjDC.Emps select E;

            var tab  = from E in ObjDC.Emps select new { E.Job };

            //Loading all jobs in Combo box
            //Using Distinct so that only distinct records get stored in the combo box 
            cbJob.DataSource = tab.Distinct();

            //Using displayMemeber so that only the value gets displayed else it will display like this {Job = "Data"}
            cbJob.DisplayMember = "Job";

            //Making it -1 so that by default all record get fetched
            cbJob.SelectedIndex = -1;
            cbJobFlag = true;
        }

        private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJobFlag)
                dgView.DataSource = from E in ObjDC.Emps where E.Job == cbJob.Text select E;
        }

        //Writing this code so that search can be performed by typing in the combo box
        private void cbJob_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgView.DataSource = from E in ObjDC.Emps where E.Job.Contains(cbJob.Text) select E;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            dgView.DataSource = from E in ObjDC.Emps orderby E.Sal select E;
        }

        private void BtnDescSort_Click(object sender, EventArgs e)
        {
            dgView.DataSource = from E in ObjDC.Emps orderby E.Ename descending select E;
        }

        private void BtnSelectedColumns_Click(object sender, EventArgs e)
        {
            dgView.DataSource = from E in ObjDC.Emps select new { E.Empno, E.Ename, E.Job, E.Sal };
        }

        private void BtnEmpCountDeptno_Click(object sender, EventArgs e)
        {
            //Key equals to the field on which grouping is done.
            dgView.DataSource = from E in ObjDC.Emps group E by E.Deptno into G select new { Deptno = G.Key, EmpCount = G.Count() };
        }

        private void BtnEmpCountJob_Click(object sender, EventArgs e)
        {
            dgView.DataSource = from E in ObjDC.Emps group E by E.Job into G select new { Job = G.Key, EmpCount = G.Count() };
        }

        private void BtnCntDeptnoGreaterThan5_Click(object sender, EventArgs e)
        {
            //If where is used after group by then it works as having clause
            dgView.DataSource = from E in ObjDC.Emps group E by E.Deptno into G where G.Count() > 5 select new { Deptno = G.Key, EmpCount = G.Count() }; 
        }

        private void BtnCntJobLessThan5_Click(object sender, EventArgs e)
        {
            dgView.DataSource = from E in ObjDC.Emps group E by E.Job into G where G.Count() < 5 select new { Job = G.Key, EmpCount = G.Count() };
        }

        private void BtnMultipleClauses1_Click(object sender, EventArgs e)
        {
            dgView.DataSource = from E in ObjDC.Emps where E.Job == "Clerk" group E by E.Deptno into G where G.Count() > 1 orderby G.Key descending select new { Deptno = G.Key, ClerkCount = G.Count() };
        }

        private void BtnMaxSalByDeptno_Click(object sender, EventArgs e)
        {   
            //Passing lambda to get Max salary
            dgView.DataSource = from E in ObjDC.Emps group E by E.Deptno into G select new { Deptno = G.Key, MaxSalary = G.Max(E => E.Sal) };
        }

        private void BtnMinSalaryByJob_Click(object sender, EventArgs e)
        {
            dgView.DataSource = from E in ObjDC.Emps group E by E.Job into G select new { Job = G.Key, MinSalary = G.Min(E => E.Sal)};
         }
    }
}
