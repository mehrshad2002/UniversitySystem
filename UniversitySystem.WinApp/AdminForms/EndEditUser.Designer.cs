namespace UniversitySystem.WinApp.AdminForms
{
    partial class EndEditUser
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelCollegeID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridAll = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagPassDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.possDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(324, 641);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(624, 641);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(366, 278);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 31);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(366, 335);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(370, 31);
            this.txtID.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(366, 400);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(370, 31);
            this.txtPassword.TabIndex = 5;
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Location = new System.Drawing.Point(366, 466);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(370, 31);
            this.txtCollegeID.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(260, 281);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 25);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(278, 338);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 25);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(243, 403);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 25);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // labelCollegeID
            // 
            this.labelCollegeID.AutoSize = true;
            this.labelCollegeID.Location = new System.Drawing.Point(243, 472);
            this.labelCollegeID.Name = "labelCollegeID";
            this.labelCollegeID.Size = new System.Drawing.Size(94, 25);
            this.labelCollegeID.TabIndex = 10;
            this.labelCollegeID.Text = "College ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridAll
            // 
            this.dataGridAll.AutoGenerateColumns = false;
            this.dataGridAll.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.cardIDDataGridViewTextBoxColumn,
            this.collegeIDDataGridViewTextBoxColumn,
            this.flagPassDataGridViewCheckBoxColumn,
            this.possDataGridViewTextBoxColumn});
            this.dataGridAll.DataSource = this.userBindingSource;
            this.dataGridAll.Location = new System.Drawing.Point(58, 128);
            this.dataGridAll.Name = "dataGridAll";
            this.dataGridAll.RowHeadersWidth = 62;
            this.dataGridAll.RowTemplate.Height = 33;
            this.dataGridAll.Size = new System.Drawing.Size(963, 93);
            this.dataGridAll.TabIndex = 13;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // cardIDDataGridViewTextBoxColumn
            // 
            this.cardIDDataGridViewTextBoxColumn.DataPropertyName = "CardID";
            this.cardIDDataGridViewTextBoxColumn.HeaderText = "CardID";
            this.cardIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cardIDDataGridViewTextBoxColumn.Name = "cardIDDataGridViewTextBoxColumn";
            this.cardIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            this.collegeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // flagPassDataGridViewCheckBoxColumn
            // 
            this.flagPassDataGridViewCheckBoxColumn.DataPropertyName = "FlagPass";
            this.flagPassDataGridViewCheckBoxColumn.HeaderText = "FlagPass";
            this.flagPassDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.flagPassDataGridViewCheckBoxColumn.Name = "flagPassDataGridViewCheckBoxColumn";
            this.flagPassDataGridViewCheckBoxColumn.Width = 150;
            // 
            // possDataGridViewTextBoxColumn
            // 
            this.possDataGridViewTextBoxColumn.DataPropertyName = "Poss";
            this.possDataGridViewTextBoxColumn.HeaderText = "Poss";
            this.possDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.possDataGridViewTextBoxColumn.Name = "possDataGridViewTextBoxColumn";
            this.possDataGridViewTextBoxColumn.Width = 150;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(UniversitySystem.Classes.User);
            // 
            // EndEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 776);
            this.Controls.Add(this.dataGridAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCollegeID);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtCollegeID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "EndEditUser";
            this.Text = "EndEditUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtPassword;
        private TextBox txtCollegeID;
        private Label labelName;
        private Label labelID;
        private Label labelPassword;
        private Label labelCollegeID;
        private Button button1;
        private DataGridView dataGridAll;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn flagPassDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn possDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
    }
}