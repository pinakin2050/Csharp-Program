namespace LINQtoSQL
{
    partial class InsertProcedureDemo
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
            this.LabelDname = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.LabelSalary = new System.Windows.Forms.Label();
            this.LabelJob = new System.Windows.Forms.Label();
            this.LabelEname = new System.Windows.Forms.Label();
            this.LableEno = new System.Windows.Forms.Label();
            this.tbDname = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.tbEname = new System.Windows.Forms.TextBox();
            this.tbEno = new System.Windows.Forms.TextBox();
            this.LableHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelDname
            // 
            this.LabelDname.AutoSize = true;
            this.LabelDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDname.Location = new System.Drawing.Point(209, 318);
            this.LabelDname.Name = "LabelDname";
            this.LabelDname.Size = new System.Drawing.Size(102, 29);
            this.LabelDname.TabIndex = 41;
            this.LabelDname.Text = "Dname:";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(507, 395);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(85, 43);
            this.BtnClose.TabIndex = 40;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(413, 395);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 43);
            this.BtnClear.TabIndex = 39;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnInsert.ForeColor = System.Drawing.Color.White;
            this.BtnInsert.Location = new System.Drawing.Point(319, 395);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(85, 43);
            this.BtnInsert.TabIndex = 38;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSalary.Location = new System.Drawing.Point(209, 268);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(92, 29);
            this.LabelSalary.TabIndex = 37;
            this.LabelSalary.Text = "Salary:";
            // 
            // LabelJob
            // 
            this.LabelJob.AutoSize = true;
            this.LabelJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJob.Location = new System.Drawing.Point(209, 218);
            this.LabelJob.Name = "LabelJob";
            this.LabelJob.Size = new System.Drawing.Size(61, 29);
            this.LabelJob.TabIndex = 36;
            this.LabelJob.Text = "Job:";
            // 
            // LabelEname
            // 
            this.LabelEname.AutoSize = true;
            this.LabelEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEname.Location = new System.Drawing.Point(209, 168);
            this.LabelEname.Name = "LabelEname";
            this.LabelEname.Size = new System.Drawing.Size(101, 29);
            this.LabelEname.TabIndex = 35;
            this.LabelEname.Text = "Ename:";
            // 
            // LableEno
            // 
            this.LableEno.AutoSize = true;
            this.LableEno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableEno.Location = new System.Drawing.Point(209, 118);
            this.LableEno.Name = "LableEno";
            this.LableEno.Size = new System.Drawing.Size(65, 29);
            this.LableEno.TabIndex = 34;
            this.LableEno.Text = "Eno:";
            // 
            // tbDname
            // 
            this.tbDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDname.Location = new System.Drawing.Point(325, 312);
            this.tbDname.Name = "tbDname";
            this.tbDname.Size = new System.Drawing.Size(263, 36);
            this.tbDname.TabIndex = 33;
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(325, 265);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(263, 36);
            this.tbSalary.TabIndex = 32;
            // 
            // tbJob
            // 
            this.tbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJob.Location = new System.Drawing.Point(325, 216);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(263, 36);
            this.tbJob.TabIndex = 31;
            // 
            // tbEname
            // 
            this.tbEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEname.Location = new System.Drawing.Point(325, 168);
            this.tbEname.Name = "tbEname";
            this.tbEname.Size = new System.Drawing.Size(263, 36);
            this.tbEname.TabIndex = 30;
            // 
            // tbEno
            // 
            this.tbEno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEno.Location = new System.Drawing.Point(325, 118);
            this.tbEno.Name = "tbEno";
            this.tbEno.ReadOnly = true;
            this.tbEno.Size = new System.Drawing.Size(263, 36);
            this.tbEno.TabIndex = 29;
            // 
            // LableHeader
            // 
            this.LableHeader.AutoSize = true;
            this.LableHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableHeader.Location = new System.Drawing.Point(265, 13);
            this.LableHeader.Name = "LableHeader";
            this.LableHeader.Size = new System.Drawing.Size(323, 48);
            this.LableHeader.TabIndex = 28;
            this.LableHeader.Text = "Employe Details";
            // 
            // InsertProcedureDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 601);
            this.Controls.Add(this.LabelDname);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.LabelSalary);
            this.Controls.Add(this.LabelJob);
            this.Controls.Add(this.LabelEname);
            this.Controls.Add(this.LableEno);
            this.Controls.Add(this.tbDname);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.tbEname);
            this.Controls.Add(this.tbEno);
            this.Controls.Add(this.LableHeader);
            this.Name = "InsertProcedureDemo";
            this.Text = "InsertProcedureDemo";
            this.Load += new System.EventHandler(this.InsertProcedureDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelDname;
        internal System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Button BtnClear;
        internal System.Windows.Forms.Button BtnInsert;
        internal System.Windows.Forms.Label LabelSalary;
        internal System.Windows.Forms.Label LabelJob;
        internal System.Windows.Forms.Label LabelEname;
        internal System.Windows.Forms.Label LableEno;
        internal System.Windows.Forms.TextBox tbDname;
        internal System.Windows.Forms.TextBox tbSalary;
        internal System.Windows.Forms.TextBox tbJob;
        internal System.Windows.Forms.TextBox tbEname;
        internal System.Windows.Forms.TextBox tbEno;
        private System.Windows.Forms.Label LableHeader;
    }
}