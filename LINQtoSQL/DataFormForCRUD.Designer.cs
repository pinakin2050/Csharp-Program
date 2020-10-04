namespace LINQtoSQL
{
    partial class DataFormForCRUD
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
            this.LableHeader = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LabelSalary = new System.Windows.Forms.Label();
            this.LabelJob = new System.Windows.Forms.Label();
            this.LabelEname = new System.Windows.Forms.Label();
            this.LableEno = new System.Windows.Forms.Label();
            this.textBoxDname = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.textBoxEname = new System.Windows.Forms.TextBox();
            this.textBoxEno = new System.Windows.Forms.TextBox();
            this.LabelDname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LableHeader
            // 
            this.LableHeader.AutoSize = true;
            this.LableHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableHeader.Location = new System.Drawing.Point(273, 9);
            this.LableHeader.Name = "LableHeader";
            this.LableHeader.Size = new System.Drawing.Size(323, 48);
            this.LableHeader.TabIndex = 0;
            this.LableHeader.Text = "Employe Details";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(515, 391);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(85, 43);
            this.BtnClose.TabIndex = 26;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(421, 391);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 43);
            this.BtnClear.TabIndex = 25;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(327, 391);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(85, 43);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSalary.Location = new System.Drawing.Point(217, 264);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(92, 29);
            this.LabelSalary.TabIndex = 22;
            this.LabelSalary.Text = "Salary:";
            // 
            // LabelJob
            // 
            this.LabelJob.AutoSize = true;
            this.LabelJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJob.Location = new System.Drawing.Point(217, 214);
            this.LabelJob.Name = "LabelJob";
            this.LabelJob.Size = new System.Drawing.Size(61, 29);
            this.LabelJob.TabIndex = 21;
            this.LabelJob.Text = "Job:";
            // 
            // LabelEname
            // 
            this.LabelEname.AutoSize = true;
            this.LabelEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEname.Location = new System.Drawing.Point(217, 164);
            this.LabelEname.Name = "LabelEname";
            this.LabelEname.Size = new System.Drawing.Size(101, 29);
            this.LabelEname.TabIndex = 20;
            this.LabelEname.Text = "Ename:";
            // 
            // LableEno
            // 
            this.LableEno.AutoSize = true;
            this.LableEno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableEno.Location = new System.Drawing.Point(217, 114);
            this.LableEno.Name = "LableEno";
            this.LableEno.Size = new System.Drawing.Size(65, 29);
            this.LableEno.TabIndex = 19;
            this.LableEno.Text = "Eno:";
            // 
            // textBoxDname
            // 
            this.textBoxDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDname.Location = new System.Drawing.Point(333, 308);
            this.textBoxDname.Name = "textBoxDname";
            this.textBoxDname.Size = new System.Drawing.Size(263, 36);
            this.textBoxDname.TabIndex = 18;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.Location = new System.Drawing.Point(333, 261);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(263, 36);
            this.textBoxSalary.TabIndex = 17;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJob.Location = new System.Drawing.Point(333, 212);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(263, 36);
            this.textBoxJob.TabIndex = 16;
            // 
            // textBoxEname
            // 
            this.textBoxEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEname.Location = new System.Drawing.Point(333, 164);
            this.textBoxEname.Name = "textBoxEname";
            this.textBoxEname.Size = new System.Drawing.Size(263, 36);
            this.textBoxEname.TabIndex = 15;
            // 
            // textBoxEno
            // 
            this.textBoxEno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEno.Location = new System.Drawing.Point(333, 114);
            this.textBoxEno.Name = "textBoxEno";
            this.textBoxEno.Size = new System.Drawing.Size(263, 36);
            this.textBoxEno.TabIndex = 14;
            // 
            // LabelDname
            // 
            this.LabelDname.AutoSize = true;
            this.LabelDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDname.Location = new System.Drawing.Point(217, 314);
            this.LabelDname.Name = "LabelDname";
            this.LabelDname.Size = new System.Drawing.Size(102, 29);
            this.LabelDname.TabIndex = 27;
            this.LabelDname.Text = "Dname:";
            // 
            // DataFormForCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 562);
            this.Controls.Add(this.LabelDname);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LabelSalary);
            this.Controls.Add(this.LabelJob);
            this.Controls.Add(this.LabelEname);
            this.Controls.Add(this.LableEno);
            this.Controls.Add(this.textBoxDname);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxJob);
            this.Controls.Add(this.textBoxEname);
            this.Controls.Add(this.textBoxEno);
            this.Controls.Add(this.LableHeader);
            this.Name = "DataFormForCRUD";
            this.Text = "DataFormForCRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LableHeader;
        internal System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Button BtnClear;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Label LabelSalary;
        internal System.Windows.Forms.Label LabelJob;
        internal System.Windows.Forms.Label LabelEname;
        internal System.Windows.Forms.Label LableEno;
        internal System.Windows.Forms.TextBox textBoxDname;
        internal System.Windows.Forms.TextBox textBoxSalary;
        internal System.Windows.Forms.TextBox textBoxJob;
        internal System.Windows.Forms.TextBox textBoxEname;
        internal System.Windows.Forms.TextBox textBoxEno;
        internal System.Windows.Forms.Label LabelDname;
    }
}