namespace clinic_db
{
    partial class ReportMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PSurveysButton = new System.Windows.Forms.Button();
            this.PTestsButton = new System.Windows.Forms.Button();
            this.PSessionsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DSurveysButton = new System.Windows.Forms.Button();
            this.DSessionsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DoctorBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TestConfirmButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TestEndPicker = new System.Windows.Forms.DateTimePicker();
            this.TestStartPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SurveysConfirmButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SurveyStartPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SurveyEndPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SessionsConfirmButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SessionStartPicker = new System.Windows.Forms.DateTimePicker();
            this.SessionEndPicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(317, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PSurveysButton);
            this.groupBox1.Controls.Add(this.PTestsButton);
            this.groupBox1.Controls.Add(this.PSessionsButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PatientBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patients";
            // 
            // PSurveysButton
            // 
            this.PSurveysButton.Location = new System.Drawing.Point(9, 168);
            this.PSurveysButton.Name = "PSurveysButton";
            this.PSurveysButton.Size = new System.Drawing.Size(148, 23);
            this.PSurveysButton.TabIndex = 4;
            this.PSurveysButton.Text = "Surveys";
            this.PSurveysButton.UseVisualStyleBackColor = true;
            this.PSurveysButton.Click += new System.EventHandler(this.PSurveysButton_Click);
            // 
            // PTestsButton
            // 
            this.PTestsButton.Location = new System.Drawing.Point(9, 139);
            this.PTestsButton.Name = "PTestsButton";
            this.PTestsButton.Size = new System.Drawing.Size(148, 23);
            this.PTestsButton.TabIndex = 3;
            this.PTestsButton.Text = "Tests";
            this.PTestsButton.UseVisualStyleBackColor = true;
            this.PTestsButton.Click += new System.EventHandler(this.PTestsButton_Click);
            // 
            // PSessionsButton
            // 
            this.PSessionsButton.Location = new System.Drawing.Point(9, 106);
            this.PSessionsButton.Name = "PSessionsButton";
            this.PSessionsButton.Size = new System.Drawing.Size(148, 23);
            this.PSessionsButton.TabIndex = 2;
            this.PSessionsButton.Text = "Sessions";
            this.PSessionsButton.UseVisualStyleBackColor = true;
            this.PSessionsButton.Click += new System.EventHandler(this.PSessionsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "For";
            // 
            // PatientBox
            // 
            this.PatientBox.FormattingEnabled = true;
            this.PatientBox.Location = new System.Drawing.Point(6, 57);
            this.PatientBox.Name = "PatientBox";
            this.PatientBox.Size = new System.Drawing.Size(151, 21);
            this.PatientBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DSurveysButton);
            this.groupBox2.Controls.Add(this.DSessionsButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DoctorBox);
            this.groupBox2.Location = new System.Drawing.Point(197, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 336);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctors";
            // 
            // DSurveysButton
            // 
            this.DSurveysButton.Location = new System.Drawing.Point(9, 139);
            this.DSurveysButton.Name = "DSurveysButton";
            this.DSurveysButton.Size = new System.Drawing.Size(148, 23);
            this.DSurveysButton.TabIndex = 5;
            this.DSurveysButton.Text = "Surveys";
            this.DSurveysButton.UseVisualStyleBackColor = true;
            this.DSurveysButton.Click += new System.EventHandler(this.DSurveysButton_Click);
            // 
            // DSessionsButton
            // 
            this.DSessionsButton.Location = new System.Drawing.Point(9, 106);
            this.DSessionsButton.Name = "DSessionsButton";
            this.DSessionsButton.Size = new System.Drawing.Size(148, 23);
            this.DSessionsButton.TabIndex = 5;
            this.DSessionsButton.Text = "Sessions";
            this.DSessionsButton.UseVisualStyleBackColor = true;
            this.DSessionsButton.Click += new System.EventHandler(this.DSessionsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "For";
            // 
            // DoctorBox
            // 
            this.DoctorBox.FormattingEnabled = true;
            this.DoctorBox.Location = new System.Drawing.Point(6, 57);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.Size = new System.Drawing.Size(151, 21);
            this.DoctorBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TestConfirmButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TestEndPicker);
            this.groupBox3.Controls.Add(this.TestStartPicker);
            this.groupBox3.Location = new System.Drawing.Point(385, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 162);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tests";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // TestConfirmButton
            // 
            this.TestConfirmButton.Location = new System.Drawing.Point(55, 133);
            this.TestConfirmButton.Name = "TestConfirmButton";
            this.TestConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.TestConfirmButton.TabIndex = 4;
            this.TestConfirmButton.Text = "Confirm";
            this.TestConfirmButton.UseVisualStyleBackColor = true;
            this.TestConfirmButton.Click += new System.EventHandler(this.TestConfirmButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "From";
            // 
            // TestEndPicker
            // 
            this.TestEndPicker.Location = new System.Drawing.Point(6, 92);
            this.TestEndPicker.Name = "TestEndPicker";
            this.TestEndPicker.Size = new System.Drawing.Size(172, 20);
            this.TestEndPicker.TabIndex = 1;
            // 
            // TestStartPicker
            // 
            this.TestStartPicker.Location = new System.Drawing.Point(6, 41);
            this.TestStartPicker.Name = "TestStartPicker";
            this.TestStartPicker.Size = new System.Drawing.Size(172, 20);
            this.TestStartPicker.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SurveysConfirmButton);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.SurveyStartPicker);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.SurveyEndPicker);
            this.groupBox4.Location = new System.Drawing.Point(385, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 162);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Surveys";
            // 
            // SurveysConfirmButton
            // 
            this.SurveysConfirmButton.Location = new System.Drawing.Point(55, 127);
            this.SurveysConfirmButton.Name = "SurveysConfirmButton";
            this.SurveysConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.SurveysConfirmButton.TabIndex = 5;
            this.SurveysConfirmButton.Text = "Confirm";
            this.SurveysConfirmButton.UseVisualStyleBackColor = true;
            this.SurveysConfirmButton.Click += new System.EventHandler(this.SurveysConfirmButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "End";
            // 
            // SurveyStartPicker
            // 
            this.SurveyStartPicker.Location = new System.Drawing.Point(6, 35);
            this.SurveyStartPicker.Name = "SurveyStartPicker";
            this.SurveyStartPicker.Size = new System.Drawing.Size(172, 20);
            this.SurveyStartPicker.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "From";
            // 
            // SurveyEndPicker
            // 
            this.SurveyEndPicker.Location = new System.Drawing.Point(6, 86);
            this.SurveyEndPicker.Name = "SurveyEndPicker";
            this.SurveyEndPicker.Size = new System.Drawing.Size(172, 20);
            this.SurveyEndPicker.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SessionsConfirmButton);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.SessionStartPicker);
            this.groupBox5.Controls.Add(this.SessionEndPicker);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(589, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 162);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sessions";
            // 
            // SessionsConfirmButton
            // 
            this.SessionsConfirmButton.Location = new System.Drawing.Point(51, 133);
            this.SessionsConfirmButton.Name = "SessionsConfirmButton";
            this.SessionsConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.SessionsConfirmButton.TabIndex = 5;
            this.SessionsConfirmButton.Text = "Confirm";
            this.SessionsConfirmButton.UseVisualStyleBackColor = true;
            this.SessionsConfirmButton.Click += new System.EventHandler(this.SessionsConfirmButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "End";
            // 
            // SessionStartPicker
            // 
            this.SessionStartPicker.Location = new System.Drawing.Point(6, 41);
            this.SessionStartPicker.Name = "SessionStartPicker";
            this.SessionStartPicker.Size = new System.Drawing.Size(172, 20);
            this.SessionStartPicker.TabIndex = 8;
            // 
            // SessionEndPicker
            // 
            this.SessionEndPicker.Location = new System.Drawing.Point(6, 92);
            this.SessionEndPicker.Name = "SessionEndPicker";
            this.SessionEndPicker.Size = new System.Drawing.Size(172, 20);
            this.SessionEndPicker.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "From";
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ReportMenu";
            this.Size = new System.Drawing.Size(810, 440);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button PSurveysButton;
        private System.Windows.Forms.Button PTestsButton;
        private System.Windows.Forms.Button PSessionsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PatientBox;
        private System.Windows.Forms.Button DSurveysButton;
        private System.Windows.Forms.Button DSessionsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DoctorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TestEndPicker;
        private System.Windows.Forms.DateTimePicker TestStartPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TestConfirmButton;
        private System.Windows.Forms.Button SurveysConfirmButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker SurveyStartPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker SurveyEndPicker;
        private System.Windows.Forms.Button SessionsConfirmButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker SessionStartPicker;
        private System.Windows.Forms.DateTimePicker SessionEndPicker;
        private System.Windows.Forms.Label label9;
    }
}
