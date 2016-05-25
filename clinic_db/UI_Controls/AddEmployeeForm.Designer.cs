namespace clinic_db
{
    partial class AddEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SpecialtyLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.ExpirienceLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SpecialtyBox = new System.Windows.Forms.TextBox();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.ExpirienceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new employee";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(106, 238);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 47);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // SpecialtyLabel
            // 
            this.SpecialtyLabel.AutoSize = true;
            this.SpecialtyLabel.Location = new System.Drawing.Point(13, 77);
            this.SpecialtyLabel.Name = "SpecialtyLabel";
            this.SpecialtyLabel.Size = new System.Drawing.Size(50, 13);
            this.SpecialtyLabel.TabIndex = 3;
            this.SpecialtyLabel.Text = "Specialty";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(13, 108);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(60, 13);
            this.SalaryLabel.TabIndex = 4;
            this.SalaryLabel.Text = "Hour salary";
            // 
            // ExpirienceLabel
            // 
            this.ExpirienceLabel.AutoSize = true;
            this.ExpirienceLabel.Location = new System.Drawing.Point(13, 138);
            this.ExpirienceLabel.Name = "ExpirienceLabel";
            this.ExpirienceLabel.Size = new System.Drawing.Size(97, 13);
            this.ExpirienceLabel.TabIndex = 5;
            this.ExpirienceLabel.Text = "Years of expirience";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(145, 47);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(138, 20);
            this.NameBox.TabIndex = 6;
            // 
            // SpecialtyBox
            // 
            this.SpecialtyBox.Location = new System.Drawing.Point(145, 77);
            this.SpecialtyBox.Name = "SpecialtyBox";
            this.SpecialtyBox.Size = new System.Drawing.Size(138, 20);
            this.SpecialtyBox.TabIndex = 7;
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(145, 108);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(138, 20);
            this.SalaryBox.TabIndex = 8;
            // 
            // ExpirienceBox
            // 
            this.ExpirienceBox.Location = new System.Drawing.Point(145, 138);
            this.ExpirienceBox.Name = "ExpirienceBox";
            this.ExpirienceBox.Size = new System.Drawing.Size(138, 20);
            this.ExpirienceBox.TabIndex = 9;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 273);
            this.Controls.Add(this.ExpirienceBox);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.SpecialtyBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ExpirienceLabel);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.SpecialtyLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SpecialtyLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label ExpirienceLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SpecialtyBox;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.TextBox ExpirienceBox;
    }
}