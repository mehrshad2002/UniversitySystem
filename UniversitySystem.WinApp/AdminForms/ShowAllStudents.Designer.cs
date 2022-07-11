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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridAllData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(590, 519);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(UniversitySystem.Classes.User);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(UniversitySystem.Classes.User);
            // 
            // dataGridAllData
            // 
            this.dataGridAllData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllData.Location = new System.Drawing.Point(163, 116);
            this.dataGridAllData.Name = "dataGridAllData";
            this.dataGridAllData.RowHeadersWidth = 62;
            this.dataGridAllData.RowTemplate.Height = 33;
            this.dataGridAllData.Size = new System.Drawing.Size(1030, 250);
            this.dataGridAllData.TabIndex = 2;
            this.dataGridAllData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAllData_CellContentClick);
            // 
            // ShowAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 670);
            this.Controls.Add(this.dataGridAllData);
            this.Controls.Add(this.btnExit);
            this.Name = "ShowAllStudents";
            this.Text = "ShowAllStudents";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
        private DataGridView dataGridAllData;
    }
}