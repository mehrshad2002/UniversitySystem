namespace UniversitySystem.WinApp.AdminForms
{
    partial class CreateSelection
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgCollege = new System.Windows.Forms.DataGridView();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLessonID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.dtValue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dgTeacher = new System.Windows.Forms.DataGridView();
            this.dgLesson = new System.Windows.Forms.DataGridView();
            this.dgRoom = new System.Windows.Forms.DataGridView();
            this.numberCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(941, 656);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(576, 68);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(941, 575);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(576, 68);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(1031, 102);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(486, 31);
            this.txtID.TabIndex = 3;
            // 
            // dgCollege
            // 
            this.dgCollege.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCollege.Location = new System.Drawing.Point(23, 45);
            this.dgCollege.Name = "dgCollege";
            this.dgCollege.RowHeadersWidth = 62;
            this.dgCollege.RowTemplate.Height = 33;
            this.dgCollege.Size = new System.Drawing.Size(842, 150);
            this.dgCollege.TabIndex = 4;
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Location = new System.Drawing.Point(1031, 164);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(486, 31);
            this.txtCollegeID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(941, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(965, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(931, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "College ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(931, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teacher ID";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(1031, 239);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(486, 31);
            this.txtTeacherID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(931, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lesson ID";
            // 
            // txtLessonID
            // 
            this.txtLessonID.Location = new System.Drawing.Point(1031, 304);
            this.txtLessonID.Name = "txtLessonID";
            this.txtLessonID.Size = new System.Drawing.Size(486, 31);
            this.txtLessonID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(931, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Room ID";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(1031, 374);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(486, 31);
            this.txtRoom.TabIndex = 13;
            // 
            // dtValue
            // 
            this.dtValue.Location = new System.Drawing.Point(1031, 438);
            this.dtValue.Name = "dtValue";
            this.dtValue.Size = new System.Drawing.Size(486, 31);
            this.dtValue.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(946, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date";
            // 
            // dgTeacher
            // 
            this.dgTeacher.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeacher.Location = new System.Drawing.Point(23, 220);
            this.dgTeacher.Name = "dgTeacher";
            this.dgTeacher.RowHeadersWidth = 62;
            this.dgTeacher.RowTemplate.Height = 33;
            this.dgTeacher.Size = new System.Drawing.Size(842, 155);
            this.dgTeacher.TabIndex = 17;
            // 
            // dgLesson
            // 
            this.dgLesson.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLesson.Location = new System.Drawing.Point(23, 401);
            this.dgLesson.Name = "dgLesson";
            this.dgLesson.RowHeadersWidth = 62;
            this.dgLesson.RowTemplate.Height = 33;
            this.dgLesson.Size = new System.Drawing.Size(842, 149);
            this.dgLesson.TabIndex = 18;
            // 
            // dgRoom
            // 
            this.dgRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoom.Location = new System.Drawing.Point(23, 575);
            this.dgRoom.Name = "dgRoom";
            this.dgRoom.RowHeadersWidth = 62;
            this.dgRoom.RowTemplate.Height = 33;
            this.dgRoom.Size = new System.Drawing.Size(842, 149);
            this.dgRoom.TabIndex = 19;
            // 
            // numberCapacity
            // 
            this.numberCapacity.Location = new System.Drawing.Point(1031, 45);
            this.numberCapacity.Name = "numberCapacity";
            this.numberCapacity.Size = new System.Drawing.Size(486, 31);
            this.numberCapacity.TabIndex = 20;
            // 
            // CreateSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 844);
            this.Controls.Add(this.numberCapacity);
            this.Controls.Add(this.dgRoom);
            this.Controls.Add(this.dgLesson);
            this.Controls.Add(this.dgTeacher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLessonID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCollegeID);
            this.Controls.Add(this.dgCollege);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreateSelection";
            this.Text = "CreateSelection";
            ((System.ComponentModel.ISupportInitialize)(this.dgCollege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnCreate;
        private TextBox txtID;
        private DataGridView dgCollege;
        private TextBox txtCollegeID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTeacherID;
        private Label label5;
        private TextBox txtLessonID;
        private Label label6;
        private TextBox txtRoom;
        private DateTimePicker dtValue;
        private Label label7;
        private DataGridView dgTeacher;
        private DataGridView dgLesson;
        private DataGridView dgRoom;
        private NumericUpDown numberCapacity;
    }
}