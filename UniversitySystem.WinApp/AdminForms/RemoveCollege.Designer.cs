namespace UniversitySystem.WinApp.AdminForms
{
    partial class RemoveCollege
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgCollege = new System.Windows.Forms.DataGridView();
            this.collegeAndUnivercityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univercityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeAndUnivercityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(657, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(259, 158);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgCollege
            // 
            this.dgCollege.AutoGenerateColumns = false;
            this.dgCollege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCollege.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCollege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collegeIDDataGridViewTextBoxColumn,
            this.collegeNameDataGridViewTextBoxColumn,
            this.univercityNameDataGridViewTextBoxColumn});
            this.dgCollege.DataSource = this.collegeAndUnivercityBindingSource;
            this.dgCollege.Location = new System.Drawing.Point(345, 196);
            this.dgCollege.Name = "dgCollege";
            this.dgCollege.RowHeadersWidth = 62;
            this.dgCollege.RowTemplate.Height = 33;
            this.dgCollege.Size = new System.Drawing.Size(895, 225);
            this.dgCollege.TabIndex = 6;
            this.dgCollege.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCollege_CellClick);
            this.dgCollege.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // collegeAndUnivercityBindingSource
            // 
            this.collegeAndUnivercityBindingSource.DataSource = typeof(UniversitySystem.Classes.CollegeAndUnivercity);
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            // 
            // collegeNameDataGridViewTextBoxColumn
            // 
            this.collegeNameDataGridViewTextBoxColumn.DataPropertyName = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.HeaderText = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeNameDataGridViewTextBoxColumn.Name = "collegeNameDataGridViewTextBoxColumn";
            // 
            // univercityNameDataGridViewTextBoxColumn
            // 
            this.univercityNameDataGridViewTextBoxColumn.DataPropertyName = "UnivercityName";
            this.univercityNameDataGridViewTextBoxColumn.HeaderText = "UnivercityName";
            this.univercityNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.univercityNameDataGridViewTextBoxColumn.Name = "univercityNameDataGridViewTextBoxColumn";
            // 
            // RemoveCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 800);
            this.Controls.Add(this.dgCollege);
            this.Controls.Add(this.btnCancel);
            this.Name = "RemoveCollege";
            this.Text = "RemoveCollege";
            ((System.ComponentModel.ISupportInitialize)(this.dgCollege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeAndUnivercityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCancel;
        private DataGridView dgCollege;
        private BindingSource collegeAndUnivercityBindingSource;
        private DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collegeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn univercityNameDataGridViewTextBoxColumn;
    }
}