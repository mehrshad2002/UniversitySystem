namespace UniversitySystem.WinApp
{
    partial class Admin
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnEditData = new System.Windows.Forms.Button();
            this.btnAddUnivercity = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.btnShowAllTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(279, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(229, 50);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(279, 75);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(229, 50);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnEditData
            // 
            this.btnEditData.Location = new System.Drawing.Point(279, 141);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(229, 50);
            this.btnEditData.TabIndex = 2;
            this.btnEditData.Text = "EditUser";
            this.btnEditData.UseVisualStyleBackColor = true;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // btnAddUnivercity
            // 
            this.btnAddUnivercity.Location = new System.Drawing.Point(12, 12);
            this.btnAddUnivercity.Name = "btnAddUnivercity";
            this.btnAddUnivercity.Size = new System.Drawing.Size(229, 50);
            this.btnAddUnivercity.TabIndex = 3;
            this.btnAddUnivercity.Text = "Add Univercity";
            this.btnAddUnivercity.UseVisualStyleBackColor = true;
            this.btnAddUnivercity.Click += new System.EventHandler(this.btnAddUnivercity_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Tomato;
            this.btnLogOut.Location = new System.Drawing.Point(206, 346);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(349, 50);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(279, 201);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(229, 50);
            this.btnShowStudents.TabIndex = 5;
            this.btnShowStudents.Text = "Show All User ( Student And Admin )";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove Univercity";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove College";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add College";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(12, 267);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(229, 50);
            this.btnAddTeacher.TabIndex = 9;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.Location = new System.Drawing.Point(279, 267);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(229, 50);
            this.btnRemoveTeacher.TabIndex = 10;
            this.btnRemoveTeacher.Text = "Remove Teacher";
            this.btnRemoveTeacher.UseVisualStyleBackColor = true;
            this.btnRemoveTeacher.Click += new System.EventHandler(this.btnRemoveTeacher_Click);
            // 
            // btnShowAllTeacher
            // 
            this.btnShowAllTeacher.Location = new System.Drawing.Point(541, 267);
            this.btnShowAllTeacher.Name = "btnShowAllTeacher";
            this.btnShowAllTeacher.Size = new System.Drawing.Size(229, 50);
            this.btnShowAllTeacher.TabIndex = 11;
            this.btnShowAllTeacher.Text = "All Teacher";
            this.btnShowAllTeacher.UseVisualStyleBackColor = true;
            this.btnShowAllTeacher.Click += new System.EventHandler(this.btnShowAllTeacher_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.btnShowAllTeacher);
            this.Controls.Add(this.btnRemoveTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAddUnivercity);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Admin";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private Button btnEditData;
        private Button btnAddUnivercity;
        private Button btnLogOut;
        private Button btnShowStudents;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnAddTeacher;
        private Button btnRemoveTeacher;
        private Button btnShowAllTeacher;
    }
}