namespace clinic_db
{
    partial class PatientProfile
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
            this.ProfileTable = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.SessionsLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.SessionsBox = new System.Windows.Forms.TextBox();
            this.CardTable = new System.Windows.Forms.TableLayoutPanel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.CardsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.ProfileTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(206, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ProfileTable
            // 
            this.ProfileTable.AutoSize = true;
            this.ProfileTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ProfileTable.ColumnCount = 2;
            this.ProfileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.33094F));
            this.ProfileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.66906F));
            this.ProfileTable.Controls.Add(this.NameLabel, 0, 0);
            this.ProfileTable.Controls.Add(this.AddressLabel, 0, 1);
            this.ProfileTable.Controls.Add(this.AgeLabel, 0, 2);
            this.ProfileTable.Controls.Add(this.PhoneLabel, 0, 3);
            this.ProfileTable.Controls.Add(this.SessionsLabel, 0, 4);
            this.ProfileTable.Controls.Add(this.NameBox, 1, 0);
            this.ProfileTable.Controls.Add(this.AddressBox, 1, 1);
            this.ProfileTable.Controls.Add(this.AgeBox, 1, 2);
            this.ProfileTable.Controls.Add(this.PhoneBox, 1, 3);
            this.ProfileTable.Controls.Add(this.SessionsBox, 1, 4);
            this.ProfileTable.Location = new System.Drawing.Point(3, 91);
            this.ProfileTable.Name = "ProfileTable";
            this.ProfileTable.RowCount = 5;
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ProfileTable.Size = new System.Drawing.Size(278, 210);
            this.ProfileTable.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(4, 1);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(4, 45);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(4, 89);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(4, 134);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(76, 13);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone number";
            // 
            // SessionsLabel
            // 
            this.SessionsLabel.AutoSize = true;
            this.SessionsLabel.Location = new System.Drawing.Point(4, 173);
            this.SessionsLabel.Name = "SessionsLabel";
            this.SessionsLabel.Size = new System.Drawing.Size(79, 13);
            this.SessionsLabel.TabIndex = 4;
            this.SessionsLabel.Text = "Sessions taken";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(104, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(141, 20);
            this.NameBox.TabIndex = 5;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(104, 48);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(141, 20);
            this.AddressBox.TabIndex = 6;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(104, 92);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(141, 20);
            this.AgeBox.TabIndex = 7;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(104, 137);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(141, 20);
            this.PhoneBox.TabIndex = 8;
            // 
            // SessionsBox
            // 
            this.SessionsBox.Location = new System.Drawing.Point(104, 176);
            this.SessionsBox.Name = "SessionsBox";
            this.SessionsBox.Size = new System.Drawing.Size(141, 20);
            this.SessionsBox.TabIndex = 9;
            // 
            // CardTable
            // 
            this.CardTable.AutoScroll = true;
            this.CardTable.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.CardTable.AutoSize = true;
            this.CardTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CardTable.ColumnCount = 4;
            this.CardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CardTable.Location = new System.Drawing.Point(287, 110);
            this.CardTable.Name = "CardTable";
            this.CardTable.RowCount = 2;
            this.CardTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CardTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CardTable.Size = new System.Drawing.Size(297, 105);
            this.CardTable.TabIndex = 3;
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.Location = new System.Drawing.Point(104, 48);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(106, 20);
            this.TopLabel.TabIndex = 4;
            this.TopLabel.Text = "Patient profile";
            // 
            // CardsLabel
            // 
            this.CardsLabel.AutoSize = true;
            this.CardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsLabel.Location = new System.Drawing.Point(379, 48);
            this.CardsLabel.Name = "CardsLabel";
            this.CardsLabel.Size = new System.Drawing.Size(106, 20);
            this.CardsLabel.TabIndex = 5;
            this.CardsLabel.Text = "Medical cards";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Disease";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Years Suffered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doctor";
            // 
            // AddCardButton
            // 
            this.AddCardButton.Location = new System.Drawing.Point(621, 81);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(95, 23);
            this.AddCardButton.TabIndex = 9;
            this.AddCardButton.Text = "Add new card";
            this.AddCardButton.UseVisualStyleBackColor = true;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.AutoSize = true;
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardsLabel);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.CardTable);
            this.Controls.Add(this.ProfileTable);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CloseButton);
            this.Name = "PatientProfile";
            this.Size = new System.Drawing.Size(725, 375);
            this.Load += new System.EventHandler(this.PatientProfile_Load);
            this.ProfileTable.ResumeLayout(false);
            this.ProfileTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TableLayoutPanel ProfileTable;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label SessionsLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox SessionsBox;
        private System.Windows.Forms.TableLayoutPanel CardTable;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label CardsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddCardButton;
    }
}
