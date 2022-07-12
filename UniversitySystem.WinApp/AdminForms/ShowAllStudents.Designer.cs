namespace UniversitySystem.WinApp.AdminForms
{
    partial class ShowAllStudents
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridAllData = new System.Windows.Forms.DataGridView();
            this.userBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dtOne = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(343, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridAllData
            // 
            this.dataGridAllData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllData.Location = new System.Drawing.Point(174, 22);
            this.dataGridAllData.Name = "dataGridAllData";
            this.dataGridAllData.RowHeadersWidth = 62;
            this.dataGridAllData.RowTemplate.Height = 33;
            this.dataGridAllData.Size = new System.Drawing.Size(1030, 42);
            this.dataGridAllData.TabIndex = 2;
            // 
            // userBindingSource4
            // 
            this.userBindingSource4.DataSource = typeof(UniversitySystem.Classes.User);
            // 
            // dtOne
            // 
            this.dtOne.AutoGenerateColumns = false;
            this.dtOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.cardIDDataGridViewTextBoxColumn,
            this.collegeIDDataGridViewTextBoxColumn,
            this.Delete});
            this.dtOne.DataSource = this.userBindingSource;
            this.dtOne.Location = new System.Drawing.Point(174, 102);
            this.dtOne.Name = "dtOne";
            this.dtOne.RowHeadersWidth = 62;
            this.dtOne.RowTemplate.Height = 33;
            this.dtOne.Size = new System.Drawing.Size(1072, 225);
            this.dtOne.TabIndex = 3;
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
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Width = 150;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(UniversitySystem.Classes.User);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gold;
            this.btnSave.Location = new System.Drawing.Point(839, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ShowAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 670);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtOne);
            this.Controls.Add(this.dataGridAllData);
            this.Controls.Add(this.btnExit);
            this.Name = "ShowAllStudents";
            this.Text = "ShowAllStudents";
            this.Load += new System.EventHandler(this.ShowAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private DataGridView dataGridAllData;
        private BindingSource userBindingSource4;
        private DataGridView dtOne;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Delete;
        private BindingSource userBindingSource;
        private Button btnSave;
    }
}