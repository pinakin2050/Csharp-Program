using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQL
{
    public partial class StoredProcedureDemo : Form
    {
        public StoredProcedureDemo()
        {
            InitializeComponent();
        }

        private void StoredProcedureDemo_Load(object sender, EventArgs e)
        {
            CompanyDBDataContext ObjDC = new CompanyDBDataContext();

            //Storing stored procedure's output in the table.
            //You can pass null to get all records
            ISingleResult<Employee_SelectResult> tab = ObjDC.Employee_Select("Product Development");
            dgView.DataSource = tab;
        }
    }
}
