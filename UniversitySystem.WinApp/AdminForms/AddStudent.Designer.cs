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
            this.Student_ID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgCollege = new System.Windows.Forms.DataGridView();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollege)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Location = new System.Drawing.Point(437, 694);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Location = new System.Drawing.Point(437, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(308, 385);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(524, 31);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(308, 556);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(524, 31);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(308, 435);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(524, 31);
            this.textBoxStudentID.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(207, 391);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 25);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(197, 562);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 25);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label3_Click);
            // 
            // Student_ID
            // 
            this.Student_ID.AutoSize = true;
            this.Student_ID.Location = new System.Drawing.Point(188, 438);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(98, 25);
            this.Student_ID.TabIndex = 11;
            this.Student_ID.Text = "Student_ID";
            // 
            // dgCollege
            // 
            this.dgCollege.AllowUserToAddRows = false;
            this.dgCollege.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCollege.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCollege.Location = new System.Drawing.Point(188, 120);
            this.dgCollege.Name = "dgCollege";
            this.dgCollege.RowHeadersWidth = 62;
            this.dgCollege.RowTemplate.Height = 33;
            this.dgCollege.Size = new System.Drawing.Size(744, 225);
            this.dgCollege.TabIndex = 13;
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Location = new System.Drawing.Point(308, 494);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(524, 31);
            this.txtCollegeID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "CollegeID";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 784);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCollegeID);
            this.Controls.Add(this.dgCollege);
            this.Controls.Add(this.Student_ID);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dgCollege)).EndInit();
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
        private Label Student_ID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgCollege;
        private TextBox txtCollegeID;
        private Label label1;
    }
}