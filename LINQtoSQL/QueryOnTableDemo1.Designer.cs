namespace LINQtoSQL
{
    partial class QueryOnTableDemo1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnDescSort = new System.Windows.Forms.Button();
            this.BtnSelectedColumns = new System.Windows.Forms.Button();
            this.BtnEmpCountDeptno = new System.Windows.Forms.Button();
            this.BtnEmpCountJob = new System.Windows.Forms.Button();
            this.BtnCntDeptnoGreaterThan5 = new System.Windows.Forms.Button();
            this.BtnCntJobLessThan5 = new System.Windows.Forms.Button();
            this.BtnMultipleClauses1 = new System.Windows.Forms.Button();
            this.BtnMaxSalByDeptno = new System.Windows.Forms.Button();
            this.BtnMinSalaryByJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJob
            // 
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(643, 12);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(78, 24);
            this.cbJob.TabIndex = 0;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.cbJob_SelectedIndexChanged);
            this.cbJob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbJob_KeyPress);
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(1, 42);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 51;
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(1402, 684);
            this.dgView.TabIndex = 1;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(1431, 42);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(314, 35);
            this.BtnSort.TabIndex = 2;
            this.BtnSort.Text = "Order By Salary Asc";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnDescSort
            // 
            this.BtnDescSort.Location = new System.Drawing.Point(1431, 103);
            this.BtnDescSort.Name = "BtnDescSort";
            this.BtnDescSort.Size = new System.Drawing.Size(314, 35);
            this.BtnDescSort.TabIndex = 3;
            this.BtnDescSort.Text = "Order By Ename Desc";
            this.BtnDescSort.UseVisualStyleBackColor = true;
            this.BtnDescSort.Click += new System.EventHandler(this.BtnDescSort_Click);
            // 
            // BtnSelectedColumns
            // 
            this.BtnSelectedColumns.Location = new System.Drawing.Point(1431, 162);
            this.BtnSelectedColumns.Name = "BtnSelectedColumns";
            this.BtnSelectedColumns.Size = new System.Drawing.Size(314, 35);
            this.BtnSelectedColumns.TabIndex = 4;
            this.BtnSelectedColumns.Text = "Get Selected Columns";
            this.BtnSelectedColumns.UseVisualStyleBackColor = true;
            this.BtnSelectedColumns.Click += new System.EventHandler(this.BtnSelectedColumns_Click);
            // 
            // BtnEmpCountDeptno
            // 
            this.BtnEmpCountDeptno.Location = new System.Drawing.Point(1431, 218);
            this.BtnEmpCountDeptno.Name = "BtnEmpCountDeptno";
            this.BtnEmpCountDeptno.Size = new System.Drawing.Size(314, 35);
            this.BtnEmpCountDeptno.TabIndex = 5;
            this.BtnEmpCountDeptno.Text = "Emp Count Group by Deptno";
            this.BtnEmpCountDeptno.UseVisualStyleBackColor = true;
            this.BtnEmpCountDeptno.Click += new System.EventHandler(this.BtnEmpCountDeptno_Click);
            // 
            // BtnEmpCountJob
            // 
            this.BtnEmpCountJob.Location = new System.Drawing.Point(1431, 277);
            this.BtnEmpCountJob.Name = "BtnEmpCountJob";
            this.BtnEmpCountJob.Size = new System.Drawing.Size(314, 35);
            this.BtnEmpCountJob.TabIndex = 6;
            this.BtnEmpCountJob.Text = "Emp Count Group by Job";
            this.BtnEmpCountJob.UseVisualStyleBackColor = true;
            this.BtnEmpCountJob.Click += new System.EventHandler(this.BtnEmpCountJob_Click);
            // 
            // BtnCntDeptnoGreaterThan5
            // 
            this.BtnCntDeptnoGreaterThan5.Location = new System.Drawing.Point(1431, 340);
            this.BtnCntDeptnoGreaterThan5.Name = "BtnCntDeptnoGreaterThan5";
            this.BtnCntDeptnoGreaterThan5.Size = new System.Drawing.Size(314, 35);
            this.BtnCntDeptnoGreaterThan5.TabIndex = 7;
            this.BtnCntDeptnoGreaterThan5.Text = "Emp Count Group by Deptno > 5";
            this.BtnCntDeptnoGreaterThan5.UseVisualStyleBackColor = true;
            this.BtnCntDeptnoGreaterThan5.Click += new System.EventHandler(this.BtnCntDeptnoGreaterThan5_Click);
            // 
            // BtnCntJobLessThan5
            // 
            this.BtnCntJobLessThan5.Location = new System.Drawing.Point(1431, 398);
            this.BtnCntJobLessThan5.Name = "BtnCntJobLessThan5";
            this.BtnCntJobLessThan5.Size = new System.Drawing.Size(314, 35);
            this.BtnCntJobLessThan5.TabIndex = 8;
            this.BtnCntJobLessThan5.Text = "Emp Count Group by Job < 5";
            this.BtnCntJobLessThan5.UseVisualStyleBackColor = true;
            this.BtnCntJobLessThan5.Click += new System.EventHandler(this.BtnCntJobLessThan5_Click);
            // 
            // BtnMultipleClauses1
            // 
            this.BtnMultipleClauses1.Location = new System.Drawing.Point(1431, 455);
            this.BtnMultipleClauses1.Name = "BtnMultipleClauses1";
            this.BtnMultipleClauses1.Size = new System.Drawing.Size(314, 35);
            this.BtnMultipleClauses1.TabIndex = 9;
            this.BtnMultipleClauses1.Text = "Multiple Clauses in a query";
            this.BtnMultipleClauses1.UseVisualStyleBackColor = true;
            this.BtnMultipleClauses1.Click += new System.EventHandler(this.BtnMultipleClauses1_Click);
            // 
            // BtnMaxSalByDeptno
            // 
            this.BtnMaxSalByDeptno.Location = new System.Drawing.Point(1431, 513);
            this.BtnMaxSalByDeptno.Name = "BtnMaxSalByDeptno";
            this.BtnMaxSalByDeptno.Size = new System.Drawing.Size(314, 35);
            this.BtnMaxSalByDeptno.TabIndex = 10;
            this.BtnMaxSalByDeptno.Text = "Max Sal Group By Deptno";
            this.BtnMaxSalByDeptno.UseVisualStyleBackColor = true;
            this.BtnMaxSalByDeptno.Click += new System.EventHandler(this.BtnMaxSalByDeptno_Click);
            // 
            // BtnMinSalaryByJob
            // 
            this.BtnMinSalaryByJob.Location = new System.Drawing.Point(1431, 577);
            this.BtnMinSalaryByJob.Name = "BtnMinSalaryByJob";
            this.BtnMinSalaryByJob.Size = new System.Drawing.Size(314, 35);
            this.BtnMinSalaryByJob.TabIndex = 11;
            this.BtnMinSalaryByJob.Text = "Min Sal Group By Job";
            this.BtnMinSalaryByJob.UseVisualStyleBackColor = true;
            this.BtnMinSalaryByJob.Click += new System.EventHandler(this.BtnMinSalaryByJob_Click);
            // 
            // QueryOnTableDemo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1757, 728);
            this.Controls.Add(this.BtnMinSalaryByJob);
            this.Controls.Add(this.BtnMaxSalByDeptno);
            this.Controls.Add(this.BtnMultipleClauses1);
            this.Controls.Add(this.BtnCntJobLessThan5);
            this.Controls.Add(this.BtnCntDeptnoGreaterThan5);
            this.Controls.Add(this.BtnEmpCountJob);
            this.Controls.Add(this.BtnEmpCountDeptno);
            this.Controls.Add(this.BtnSelectedColumns);
            this.Controls.Add(this.BtnDescSort);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.cbJob);
            this.Name = "QueryOnTableDemo1";
            this.Text = "QueryOnTableDemo1";
            this.Load += new System.EventHandler(this.QueryOnTableDemo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnDescSort;
        private System.Windows.Forms.Button BtnSelectedColumns;
        private System.Windows.Forms.Button BtnEmpCountDeptno;
        private System.Windows.Forms.Button BtnEmpCountJob;
        private System.Windows.Forms.Button BtnCntDeptnoGreaterThan5;
        private System.Windows.Forms.Button BtnCntJobLessThan5;
        private System.Windows.Forms.Button BtnMultipleClauses1;
        private System.Windows.Forms.Button BtnMaxSalByDeptno;
        private System.Windows.Forms.Button BtnMinSalaryByJob;
    }
}