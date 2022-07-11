namespace UniversitySystem.WinApp.PersonnelForms
{
    partial class Selectionlesson
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
            this.dgSelections = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCollegeAndUnivercity = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollegeAndUnivercity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Location = new System.Drawing.Point(952, 714);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Location = new System.Drawing.Point(952, 665);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgSelections
            // 
            this.dgSelections.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgSelections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelections.GridColor = System.Drawing.SystemColors.Control;
            this.dgSelections.Location = new System.Drawing.Point(37, 44);
            this.dgSelections.Name = "dgSelections";
            this.dgSelections.RowHeadersWidth = 62;
            this.dgSelections.RowTemplate.Height = 33;
            this.dgSelections.Size = new System.Drawing.Size(1027, 273);
            this.dgSelections.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(218, 668);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(700, 31);
            this.txtID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // dgCollegeAndUnivercity
            // 
            this.dgCollegeAndUnivercity.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCollegeAndUnivercity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCollegeAndUnivercity.GridColor = System.Drawing.SystemColors.Control;
            this.dgCollegeAndUnivercity.Location = new System.Drawing.Point(284, 336);
            this.dgCollegeAndUnivercity.Name = "dgCollegeAndUnivercity";
            this.dgCollegeAndUnivercity.RowHeadersWidth = 62;
            this.dgCollegeAndUnivercity.RowTemplate.Height = 33;
            this.dgCollegeAndUnivercity.Size = new System.Drawing.Size(516, 202);
            this.dgCollegeAndUnivercity.TabIndex = 5;
            // 
            // Selectionlesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 867);
            this.Controls.Add(this.dgCollegeAndUnivercity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgSelections);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "Selectionlesson";
            this.Text = "Selectionlesson";
            ((System.ComponentModel.ISupportInitialize)(this.dgSelections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollegeAndUnivercity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private DataGridView dgSelections;
        private TextBox txtID;
        private Label label1;
        private DataGridView dgCollegeAndUnivercity;
    }
}