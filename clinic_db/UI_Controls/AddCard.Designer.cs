namespace clinic_db
{
    partial class AddCard
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
            this.TopLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SufferedBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CuredCheckBox = new System.Windows.Forms.CheckBox();
            this.DoctorBox = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.Location = new System.Drawing.Point(49, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(161, 16);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Add new medical card";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disease name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Years suffered";
            // 
            // SufferedBox
            // 
            this.SufferedBox.Location = new System.Drawing.Point(94, 132);
            this.SufferedBox.Name = "SufferedBox";
            this.SufferedBox.Size = new System.Drawing.Size(176, 20);
            this.SufferedBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(94, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 20);
            this.NameBox.TabIndex = 6;
            // 
            // CuredCheckBox
            // 
            this.CuredCheckBox.AutoSize = true;
            this.CuredCheckBox.Location = new System.Drawing.Point(94, 178);
            this.CuredCheckBox.Name = "CuredCheckBox";
            this.CuredCheckBox.Size = new System.Drawing.Size(65, 17);
            this.CuredCheckBox.TabIndex = 7;
            this.CuredCheckBox.Text = "Is Cured";
            this.CuredCheckBox.UseVisualStyleBackColor = true;
            // 
            // DoctorBox
            // 
            this.DoctorBox.FormattingEnabled = true;
            this.DoctorBox.Location = new System.Drawing.Point(94, 92);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.Size = new System.Drawing.Size(176, 21);
            this.DoctorBox.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(175, 238);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 273);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DoctorBox);
            this.Controls.Add(this.CuredCheckBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SufferedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopLabel);
            this.Name = "AddCard";
            this.Text = "AddCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SufferedBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.CheckBox CuredCheckBox;
        private System.Windows.Forms.ComboBox DoctorBox;
        private System.Windows.Forms.Button Add;
    }
}