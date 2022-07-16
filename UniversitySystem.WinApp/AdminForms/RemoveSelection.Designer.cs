namespace UniversitySystem.WinApp.AdminForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgSelectionNew = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectionNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgSelectionNew
            // 
            this.dgSelectionNew.AutoGenerateColumns = false;
            this.dgSelectionNew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSelectionNew.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgSelectionNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelectionNew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgSelectionNew.DataSource = this.selectionBindingSource;
            this.dgSelectionNew.Location = new System.Drawing.Point(187, 179);
            this.dgSelectionNew.Name = "dgSelectionNew";
            this.dgSelectionNew.RowHeadersWidth = 62;
            this.dgSelectionNew.RowTemplate.Height = 33;
            this.dgSelectionNew.Size = new System.Drawing.Size(822, 225);
            this.dgSelectionNew.TabIndex = 5;
            this.dgSelectionNew.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSelectionNew_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // selectionBindingSource
            // 
            this.selectionBindingSource.DataSource = typeof(UniversitySystem.Classes.Selection);
            // 
            // RemoveSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 766);
            this.Controls.Add(this.dgSelectionNew);
            this.Controls.Add(this.button1);
            this.Name = "RemoveSelection";
            this.Text = "RemoveSelection";
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectionNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridView dgSelectionNew;
        private BindingSource selectionBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}