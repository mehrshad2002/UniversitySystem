namespace UniversitySystem.WinApp.StudentForms
{
    partial class RemoveSelection
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
            this.button2 = new System.Windows.Forms.Button();
            this.dgAllSelection = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionForStudentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionForStudentListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgAllSelection
            // 
            this.dgAllSelection.AutoGenerateColumns = false;
            this.dgAllSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAllSelection.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAllSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgAllSelection.DataSource = this.selectionForStudentListBindingSource;
            this.dgAllSelection.Location = new System.Drawing.Point(75, 50);
            this.dgAllSelection.Name = "dgAllSelection";
            this.dgAllSelection.RowHeadersWidth = 62;
            this.dgAllSelection.RowTemplate.Height = 33;
            this.dgAllSelection.Size = new System.Drawing.Size(844, 350);
            this.dgAllSelection.TabIndex = 2;
            this.dgAllSelection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllSelection_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // selectionForStudentListBindingSource
            // 
            this.selectionForStudentListBindingSource.DataSource = typeof(UniversitySystem.Classes.SelectionForStudentList);
            // 
            // RemoveSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 760);
            this.Controls.Add(this.dgAllSelection);
            this.Controls.Add(this.button2);
            this.Name = "RemoveSelection";
            this.Text = "RemoveSelection";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionForStudentListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button2;
        private DataGridView dgAllSelection;
        private BindingSource selectionForStudentListBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}