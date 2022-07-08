namespace UniversitySystem.WinApp.AdminForms
{
    partial class AddRoom
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.dgCollege = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollege)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(320, 532);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(603, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(320, 354);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(436, 31);
            this.txtID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "CollegeID";
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Location = new System.Drawing.Point(320, 434);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(436, 31);
            this.txtCollegeID.TabIndex = 7;
            // 
            // dgCollege
            // 
            this.dgCollege.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCollege.Location = new System.Drawing.Point(294, 29);
            this.dgCollege.Name = "dgCollege";
            this.dgCollege.RowHeadersWidth = 62;
            this.dgCollege.RowTemplate.Height = 33;
            this.dgCollege.Size = new System.Drawing.Size(462, 276);
            this.dgCollege.TabIndex = 8;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 712);
            this.Controls.Add(this.dgCollege);
            this.Controls.Add(this.txtCollegeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dgCollege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Button btnCancel;
        private Label label1;
        private TextBox txtID;
        private Label label3;
        private TextBox txtCollegeID;
        private DataGridView dgCollege;
    }
}