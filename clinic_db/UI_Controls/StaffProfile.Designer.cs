namespace clinic_db
{
    partial class StaffProfile
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SpecialtyLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.YoELabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SpecialtyTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.YoeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(42, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(267, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SpecialtyLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SalaryLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.YoELabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SpecialtyTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SalaryTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.YoeTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.97701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.02299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 180);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SpecialtyLabel
            // 
            this.SpecialtyLabel.AutoSize = true;
            this.SpecialtyLabel.Location = new System.Drawing.Point(3, 40);
            this.SpecialtyLabel.Name = "SpecialtyLabel";
            this.SpecialtyLabel.Size = new System.Drawing.Size(50, 13);
            this.SpecialtyLabel.TabIndex = 1;
            this.SpecialtyLabel.Text = "Specialty";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(3, 131);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(60, 13);
            this.SalaryLabel.TabIndex = 3;
            this.SalaryLabel.Text = "Hour salary";
            // 
            // YoELabel
            // 
            this.YoELabel.AutoSize = true;
            this.YoELabel.Location = new System.Drawing.Point(3, 87);
            this.YoELabel.Name = "YoELabel";
            this.YoELabel.Size = new System.Drawing.Size(97, 13);
            this.YoELabel.TabIndex = 2;
            this.YoELabel.Text = "Years of experience";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(160, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // SpecialtyTextBox
            // 
            this.SpecialtyTextBox.Location = new System.Drawing.Point(160, 43);
            this.SpecialtyTextBox.Name = "SpecialtyTextBox";
            this.SpecialtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.SpecialtyTextBox.TabIndex = 5;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(160, 90);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalaryTextBox.TabIndex = 7;
            // 
            // YoeTextBox
            // 
            this.YoeTextBox.Location = new System.Drawing.Point(160, 134);
            this.YoeTextBox.Name = "YoeTextBox";
            this.YoeTextBox.Size = new System.Drawing.Size(100, 20);
            this.YoeTextBox.TabIndex = 6;
            // 
            // StaffProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CloseButton);
            this.Name = "StaffProfile";
            this.Size = new System.Drawing.Size(379, 255);
            this.Load += new System.EventHandler(this.StaffProfile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SpecialtyLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label YoELabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SpecialtyTextBox;
        private System.Windows.Forms.TextBox YoeTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
    }
}
