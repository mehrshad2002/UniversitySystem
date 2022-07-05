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
            this.btnRemoveUni = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(206, 21);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(349, 50);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(206, 84);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(349, 50);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnAddUnivercity
            // 
            this.btnAddUnivercity.Location = new System.Drawing.Point(206, 150);
            this.btnAddUnivercity.Name = "btnAddUnivercity";
            this.btnAddUnivercity.Size = new System.Drawing.Size(349, 50);
            this.btnAddUnivercity.TabIndex = 2;
            this.btnAddUnivercity.Text = "Add Univercity";
            this.btnAddUnivercity.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUni
            // 
            this.btnRemoveUni.Location = new System.Drawing.Point(206, 217);
            this.btnRemoveUni.Name = "btnRemoveUni";
            this.btnRemoveUni.Size = new System.Drawing.Size(349, 50);
            this.btnRemoveUni.TabIndex = 3;
            this.btnRemoveUni.Text = "Remove Univercity";
            this.btnRemoveUni.UseVisualStyleBackColor = true;
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
            this.btnShowStudents.Location = new System.Drawing.Point(206, 282);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(349, 50);
            this.btnShowStudents.TabIndex = 5;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRemoveUni);
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
        private Button btnRemoveUni;
        private Button btnLogOut;
        private Button btnShowStudents;
    }
}