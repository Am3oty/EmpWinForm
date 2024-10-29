namespace WindowsFormsApp1
{
    partial class MainSc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSc));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelMstatus = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label_show_Name = new System.Windows.Forms.Label();
            this.label_show_Job = new System.Windows.Forms.Label();
            this.label_show_Email = new System.Windows.Forms.Label();
            this.label_show_Phone = new System.Windows.Forms.Label();
            this.label_show_Gender = new System.Windows.Forms.Label();
            this.label_show_Mstatus = new System.Windows.Forms.Label();
            this.label_show_BirthDate = new System.Windows.Forms.Label();
            this.label_show_Salary = new System.Windows.Forms.Label();
            this.label_show_Department = new System.Windows.Forms.Label();
            this.label_show_ID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 259);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(185, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(345, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(9, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name : ";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.BackColor = System.Drawing.Color.Transparent;
            this.labelJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJob.Location = new System.Drawing.Point(12, 79);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(45, 16);
            this.labelJob.TabIndex = 6;
            this.labelJob.Text = "Job : ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(12, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(34, 16);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID : ";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.BackColor = System.Drawing.Color.Transparent;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(230, 79);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(99, 16);
            this.labelDepartment.TabIndex = 8;
            this.labelDepartment.Text = "Department : ";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(220, 9);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(64, 16);
            this.labelSalary.TabIndex = 9;
            this.labelSalary.Text = "Salary : ";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.Location = new System.Drawing.Point(220, 41);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(83, 16);
            this.labelBirthDate.TabIndex = 10;
            this.labelBirthDate.Text = "BirthDate : ";
            // 
            // labelMstatus
            // 
            this.labelMstatus.AutoSize = true;
            this.labelMstatus.BackColor = System.Drawing.Color.Transparent;
            this.labelMstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMstatus.Location = new System.Drawing.Point(599, 9);
            this.labelMstatus.Name = "labelMstatus";
            this.labelMstatus.Size = new System.Drawing.Size(72, 16);
            this.labelMstatus.TabIndex = 11;
            this.labelMstatus.Text = "Mstatus : ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(431, 9);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(70, 16);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Gender : ";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(599, 41);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(63, 16);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Phone : ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(431, 67);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 16);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email : ";
            // 
            // label_show_Name
            // 
            this.label_show_Name.AutoSize = true;
            this.label_show_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_show_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_Name.Location = new System.Drawing.Point(75, 41);
            this.label_show_Name.Name = "label_show_Name";
            this.label_show_Name.Size = new System.Drawing.Size(39, 16);
            this.label_show_Name.TabIndex = 15;
            this.label_show_Name.Text = "????";
            // 
            // label_show_Job
            // 
            this.label_show_Job.AutoSize = true;
            this.label_show_Job.BackColor = System.Drawing.Color.Transparent;
            this.label_show_Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_Job.Location = new System.Drawing.Point(63, 79);
            this.label_show_Job.Name = "label_show_Job";
            this.label_show_Job.Size = new System.Drawing.Size(39, 16);
            this.label_show_Job.TabIndex = 16;
            this.label_show_Job.Text = "????";
            // 
            // label_show_Email
            // 
            this.label_show_Email.AutoSize = true;
            this.label_show_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_show_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_Email.Location = new System.Drawing.Point(512, 67);
            this.label_show_Email.Name = "label_show_Email";
            this.label_show_Email.Size = new System.Drawing.Size(39, 16);
            this.label_show_Email.TabIndex = 17;
            this.label_show_Email.Text = "????";
            // 
            // label_show_Phone
            // 
            this.label_show_Phone.AutoSize = true;
            this.label_show_Phone.BackColor = System.Drawing.Color.Transparent;
            this.label_show_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_Phone.Location = new System.Drawing.Point(680, 41);
            this.label_show_Phone.Name = "label_show_Phone";
            this.label_show_Phone.Size = new System.Drawing.Size(39, 16);
            this.label_show_Phone.TabIndex = 18;
            this.label_show_Phone.Text = "????";
            // 
            // label_show_Gender
            // 
            this.label_show_Gender.AutoSize = true;
            this.label_show_Gender.BackColor = System.Drawing.Color.Transparent;
            this.label_show_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_Gender.Location = new System.Drawing.Point(512, 9);
            this.label_show_Gender.Name = "label_show_Gender";
            this.label_show_Gender.Size = new System.Drawing.Size(39, 16);
            this.label_show_Gender.TabIndex = 19;
            this.label_show_Gender.Text = "????";
            // 
            // label_show_Mstatus
            // 
            this.label_show_Mstatus.AutoSize = true;
            this.label_show_Mstatus.BackColor = System.Drawing.Color.Transparent;
            this.label_show_Mstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_Mstatus.Location = new System.Drawing.Point(677, 9);
            this.label_show_Mstatus.Name = "label_show_Mstatus";
            this.label_show_Mstatus.Size = new System.Drawing.Size(39, 16);
            this.label_show_Mstatus.TabIndex = 20;
            this.label_show_Mstatus.Text = "????";
            // 
            // label_show_BirthDate
            // 
            this.label_show_BirthDate.AutoSize = true;
            this.label_show_BirthDate.BackColor = System.Drawing.Color.Transparent;
            this.label_show_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_BirthDate.Location = new System.Drawing.Point(309, 41);
            this.label_show_BirthDate.Name = "label_show_BirthDate";
            this.label_show_BirthDate.Size = new System.Drawing.Size(39, 16);
            this.label_show_BirthDate.TabIndex = 21;
            this.label_show_BirthDate.Text = "????";
            // 
            // label_show_Salary
            // 
            this.label_show_Salary.AutoSize = true;
            this.label_show_Salary.BackColor = System.Drawing.Color.Transparent;
            this.label_show_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_Salary.Location = new System.Drawing.Point(290, 9);
            this.label_show_Salary.Name = "label_show_Salary";
            this.label_show_Salary.Size = new System.Drawing.Size(39, 16);
            this.label_show_Salary.TabIndex = 22;
            this.label_show_Salary.Text = "????";
            // 
            // label_show_Department
            // 
            this.label_show_Department.AutoSize = true;
            this.label_show_Department.BackColor = System.Drawing.Color.Transparent;
            this.label_show_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_Department.Location = new System.Drawing.Point(335, 79);
            this.label_show_Department.Name = "label_show_Department";
            this.label_show_Department.Size = new System.Drawing.Size(39, 16);
            this.label_show_Department.TabIndex = 23;
            this.label_show_Department.Text = "????";
            // 
            // label_show_ID
            // 
            this.label_show_ID.AutoSize = true;
            this.label_show_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_show_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_ID.Location = new System.Drawing.Point(52, 9);
            this.label_show_ID.Name = "label_show_ID";
            this.label_show_ID.Size = new System.Drawing.Size(39, 16);
            this.label_show_ID.TabIndex = 24;
            this.label_show_ID.Text = "????";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(480, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Filter By : ";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.AllowDrop = true;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBoxFilter.Location = new System.Drawing.Point(97, 150);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 28;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(515, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainSc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.f5f84f0dbde9bb6e2d7cbc51991608f1_Photoroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_show_ID);
            this.Controls.Add(this.label_show_Department);
            this.Controls.Add(this.label_show_Salary);
            this.Controls.Add(this.label_show_BirthDate);
            this.Controls.Add(this.label_show_Mstatus);
            this.Controls.Add(this.label_show_Gender);
            this.Controls.Add(this.label_show_Phone);
            this.Controls.Add(this.label_show_Email);
            this.Controls.Add(this.label_show_Job);
            this.Controls.Add(this.label_show_Name);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelMstatus);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainSc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emplyess Mangement System";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelMstatus;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label_show_Name;
        private System.Windows.Forms.Label label_show_Job;
        private System.Windows.Forms.Label label_show_Email;
        private System.Windows.Forms.Label label_show_Phone;
        private System.Windows.Forms.Label label_show_Gender;
        private System.Windows.Forms.Label label_show_Mstatus;
        private System.Windows.Forms.Label label_show_BirthDate;
        private System.Windows.Forms.Label label_show_Salary;
        private System.Windows.Forms.Label label_show_Department;
        private System.Windows.Forms.Label label_show_ID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}