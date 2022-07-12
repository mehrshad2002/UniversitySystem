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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLessonID = new System.Windows.Forms.TextBox();
            this.dtValue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.numberCapacity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCollegeID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComBoRoomID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLesson = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(941, 662);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(576, 68);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(941, 581);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(931, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lesson ID";
            // 
            // txtLessonID
            // 
            this.txtLessonID.Location = new System.Drawing.Point(1031, 180);
            this.txtLessonID.Name = "txtLessonID";
            this.txtLessonID.Size = new System.Drawing.Size(486, 31);
            this.txtLessonID.TabIndex = 11;
            // 
            // dtValue
            // 
            this.dtValue.Location = new System.Drawing.Point(1031, 314);
            this.dtValue.Name = "dtValue";
            this.dtValue.Size = new System.Drawing.Size(486, 31);
            this.dtValue.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(946, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date";
            // 
            // numberCapacity
            // 
            this.numberCapacity.Location = new System.Drawing.Point(1031, 45);
            this.numberCapacity.Name = "numberCapacity";
            this.numberCapacity.Size = new System.Drawing.Size(486, 31);
            this.numberCapacity.TabIndex = 20;
            // 
            // comboBoxCollegeID
            // 
            this.comboBoxCollegeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCollegeID.FormattingEnabled = true;
            this.comboBoxCollegeID.Location = new System.Drawing.Point(1031, 378);
            this.comboBoxCollegeID.Name = "comboBoxCollegeID";
            this.comboBoxCollegeID.Size = new System.Drawing.Size(486, 33);
            this.comboBoxCollegeID.TabIndex = 21;
            this.comboBoxCollegeID.CausesValidationChanged += new System.EventHandler(this.comboBoxCollegeID_CausesValidationChanged);
            this.comboBoxCollegeID.TextChanged += new System.EventHandler(this.comboBoxCollegeID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(920, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "College ID";
            // 
            // ComBoRoomID
            // 
            this.ComBoRoomID.FormattingEnabled = true;
            this.ComBoRoomID.Location = new System.Drawing.Point(1031, 434);
            this.ComBoRoomID.Name = "ComBoRoomID";
            this.ComBoRoomID.Size = new System.Drawing.Size(486, 33);
            this.ComBoRoomID.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(931, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Room ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(931, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Teacher";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(1031, 251);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(486, 33);
            this.comboBoxTeacher.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(931, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Lesson";
            // 
            // comboBoxLesson
            // 
            this.comboBoxLesson.FormattingEnabled = true;
            this.comboBoxLesson.Location = new System.Drawing.Point(1031, 502);
            this.comboBoxLesson.Name = "comboBoxLesson";
            this.comboBoxLesson.Size = new System.Drawing.Size(486, 33);
            this.comboBoxLesson.TabIndex = 27;
            // 
            // CreateSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 844);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLesson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComBoRoomID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxCollegeID);
            this.Controls.Add(this.numberCapacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLessonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreateSelection";
            this.Text = "CreateSelection";
            ((System.ComponentModel.ISupportInitialize)(this.numberCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnCreate;
        private TextBox txtID;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtLessonID;
        private DateTimePicker dtValue;
        private Label label7;
        private NumericUpDown numberCapacity;
        private ComboBox comboBoxCollegeID;
        private Label label8;
        private ComboBox ComBoRoomID;
        private Label label9;
        private Label label3;
        private ComboBox comboBoxTeacher;
        private Label label4;
        private ComboBox comboBoxLesson;
    }
}