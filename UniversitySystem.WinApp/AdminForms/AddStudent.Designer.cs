namespace UniversitySystem.WinApp.AdminForms
{
    partial class AddStudent
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.College_ID = new System.Windows.Forms.Label();
            this.Student_ID = new System.Windows.Forms.Label();
            this.comboBoxCollegeID = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Location = new System.Drawing.Point(455, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Location = new System.Drawing.Point(228, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(228, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(339, 31);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(228, 258);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(339, 31);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(228, 137);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(339, 31);
            this.textBoxStudentID.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(127, 93);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 25);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(117, 264);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 25);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label3_Click);
            // 
            // College_ID
            // 
            this.College_ID.AutoSize = true;
            this.College_ID.Location = new System.Drawing.Point(108, 197);
            this.College_ID.Name = "College_ID";
            this.College_ID.Size = new System.Drawing.Size(96, 25);
            this.College_ID.TabIndex = 10;
            this.College_ID.Text = "College_ID";
            // 
            // Student_ID
            // 
            this.Student_ID.AutoSize = true;
            this.Student_ID.Location = new System.Drawing.Point(108, 140);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(98, 25);
            this.Student_ID.TabIndex = 11;
            this.Student_ID.Text = "Student_ID";
            // 
            // comboBoxCollegeID
            // 
            this.comboBoxCollegeID.FormattingEnabled = true;
            this.comboBoxCollegeID.Items.AddRange(new object[] {
            "2001---CMP_Sharif",
            "4001---Art_Tehran",
            "5001---CMP_Tehran"});
            this.comboBoxCollegeID.Location = new System.Drawing.Point(228, 197);
            this.comboBoxCollegeID.Name = "comboBoxCollegeID";
            this.comboBoxCollegeID.Size = new System.Drawing.Size(339, 33);
            this.comboBoxCollegeID.TabIndex = 12;
            this.comboBoxCollegeID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCollegeID);
            this.Controls.Add(this.Student_ID);
            this.Controls.Add(this.College_ID);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private TextBox textBoxStudentID;
        private Label labelName;
        private Label Password;
        private Label College_ID;
        private Label Student_ID;
        private ComboBox comboBoxCollegeID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}