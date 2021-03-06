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
            this.btnAddUnivercity = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.btnShowAllTeacher = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.RemoveSelection = new System.Windows.Forms.Button();
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
            this.btnLogOut.Location = new System.Drawing.Point(786, 12);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(229, 179);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(279, 141);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(229, 110);
            this.btnShowStudents.TabIndex = 5;
            this.btnShowStudents.Text = "Edit Remove Users";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(541, 201);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(229, 50);
            this.btnRoom.TabIndex = 12;
            this.btnRoom.Text = "Add Room";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(541, 141);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(229, 50);
            this.btnRemoveRoom.TabIndex = 13;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(541, 75);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(229, 50);
            this.btnAddLesson.TabIndex = 14;
            this.btnAddLesson.Text = "Add Lesson ";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "Remove Lesson";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(786, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 50);
            this.button5.TabIndex = 16;
            this.button5.Text = "Create Selection ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // RemoveSelection
            // 
            this.RemoveSelection.Location = new System.Drawing.Point(786, 201);
            this.RemoveSelection.Name = "RemoveSelection";
            this.RemoveSelection.Size = new System.Drawing.Size(229, 50);
            this.RemoveSelection.TabIndex = 17;
            this.RemoveSelection.Text = "Remove Selection";
            this.RemoveSelection.UseVisualStyleBackColor = true;
            this.RemoveSelection.Click += new System.EventHandler(this.RemoveSelection_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 367);
            this.Controls.Add(this.RemoveSelection);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.btnRemoveRoom);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.btnShowAllTeacher);
            this.Controls.Add(this.btnRemoveTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAddUnivercity);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Admin";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private Button btnAddUnivercity;
        private Button btnLogOut;
        private Button btnShowStudents;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnAddTeacher;
        private Button btnRemoveTeacher;
        private Button btnShowAllTeacher;
        private Button btnRoom;
        private Button btnRemoveRoom;
        private Button btnAddLesson;
        private Button button4;
        private Button button5;
        private Button RemoveSelection;
    }
}