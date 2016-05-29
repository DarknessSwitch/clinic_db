namespace clinic_db
{
    partial class ProceduresList
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
            this.ProceduresTable = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SurveyTable = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DiseaseTable = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddSurveyButton = new System.Windows.Forms.Button();
            this.AddDiseaseButton = new System.Windows.Forms.Button();
            this.SaveSurveyButton = new System.Windows.Forms.Button();
            this.SaveDiseaseButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveTestButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TestsTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProceduresTable
            // 
            this.ProceduresTable.AutoScroll = true;
            this.ProceduresTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ProceduresTable.ColumnCount = 4;
            this.ProceduresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.87417F));
            this.ProceduresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.12583F));
            this.ProceduresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.ProceduresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.ProceduresTable.Location = new System.Drawing.Point(20, 98);
            this.ProceduresTable.Name = "ProceduresTable";
            this.ProceduresTable.RowCount = 2;
            this.ProceduresTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ProceduresTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ProceduresTable.Size = new System.Drawing.Size(354, 164);
            this.ProceduresTable.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(20, 47);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(20, 18);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add new procedure";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(158, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(235, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(142, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Procedures list";
            // 
            // SurveyTable
            // 
            this.SurveyTable.AutoScroll = true;
            this.SurveyTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SurveyTable.ColumnCount = 3;
            this.SurveyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SurveyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SurveyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SurveyTable.Location = new System.Drawing.Point(406, 349);
            this.SurveyTable.Name = "SurveyTable";
            this.SurveyTable.RowCount = 2;
            this.SurveyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SurveyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SurveyTable.Size = new System.Drawing.Size(371, 150);
            this.SurveyTable.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(542, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Survey type list";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(454, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(579, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cost";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(390, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 555);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DiseaseTable
            // 
            this.DiseaseTable.AutoScroll = true;
            this.DiseaseTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DiseaseTable.ColumnCount = 2;
            this.DiseaseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DiseaseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DiseaseTable.Location = new System.Drawing.Point(20, 349);
            this.DiseaseTable.Name = "DiseaseTable";
            this.DiseaseTable.RowCount = 2;
            this.DiseaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DiseaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DiseaseTable.Size = new System.Drawing.Size(354, 150);
            this.DiseaseTable.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(63, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(143, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Disease type list";
            // 
            // AddSurveyButton
            // 
            this.AddSurveyButton.Location = new System.Drawing.Point(406, 268);
            this.AddSurveyButton.Name = "AddSurveyButton";
            this.AddSurveyButton.Size = new System.Drawing.Size(114, 23);
            this.AddSurveyButton.TabIndex = 19;
            this.AddSurveyButton.Text = "Add new type";
            this.AddSurveyButton.UseVisualStyleBackColor = true;
            this.AddSurveyButton.Click += new System.EventHandler(this.AddSurveyButton_Click);
            // 
            // AddDiseaseButton
            // 
            this.AddDiseaseButton.Location = new System.Drawing.Point(20, 268);
            this.AddDiseaseButton.Name = "AddDiseaseButton";
            this.AddDiseaseButton.Size = new System.Drawing.Size(114, 23);
            this.AddDiseaseButton.TabIndex = 20;
            this.AddDiseaseButton.Text = "Add new type";
            this.AddDiseaseButton.UseVisualStyleBackColor = true;
            this.AddDiseaseButton.Click += new System.EventHandler(this.AddDiseaseButton_Click);
            // 
            // SaveSurveyButton
            // 
            this.SaveSurveyButton.Location = new System.Drawing.Point(406, 298);
            this.SaveSurveyButton.Name = "SaveSurveyButton";
            this.SaveSurveyButton.Size = new System.Drawing.Size(114, 23);
            this.SaveSurveyButton.TabIndex = 22;
            this.SaveSurveyButton.Text = "Save changes";
            this.SaveSurveyButton.UseVisualStyleBackColor = true;
            this.SaveSurveyButton.Click += new System.EventHandler(this.SaveSurveyButton_Click);
            // 
            // SaveDiseaseButton
            // 
            this.SaveDiseaseButton.Location = new System.Drawing.Point(20, 297);
            this.SaveDiseaseButton.Name = "SaveDiseaseButton";
            this.SaveDiseaseButton.Size = new System.Drawing.Size(114, 23);
            this.SaveDiseaseButton.TabIndex = 23;
            this.SaveDiseaseButton.Text = "Save changes";
            this.SaveDiseaseButton.UseVisualStyleBackColor = true;
            this.SaveDiseaseButton.Click += new System.EventHandler(this.SaveDiseaseButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(577, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(462, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name";
            // 
            // SaveTestButton
            // 
            this.SaveTestButton.Location = new System.Drawing.Point(414, 47);
            this.SaveTestButton.Name = "SaveTestButton";
            this.SaveTestButton.Size = new System.Drawing.Size(114, 23);
            this.SaveTestButton.TabIndex = 21;
            this.SaveTestButton.Text = "Save changes";
            this.SaveTestButton.UseVisualStyleBackColor = true;
            this.SaveTestButton.Click += new System.EventHandler(this.SaveTestButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(559, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Test type list";
            // 
            // TestsTable
            // 
            this.TestsTable.AutoScroll = true;
            this.TestsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TestsTable.ColumnCount = 3;
            this.TestsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TestsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TestsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TestsTable.Location = new System.Drawing.Point(406, 98);
            this.TestsTable.Name = "TestsTable";
            this.TestsTable.RowCount = 2;
            this.TestsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TestsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TestsTable.Size = new System.Drawing.Size(371, 146);
            this.TestsTable.TabIndex = 7;
            // 
            // AddTestButton
            // 
            this.AddTestButton.Location = new System.Drawing.Point(414, 18);
            this.AddTestButton.Name = "AddTestButton";
            this.AddTestButton.Size = new System.Drawing.Size(114, 23);
            this.AddTestButton.TabIndex = 18;
            this.AddTestButton.Text = "Add new type";
            this.AddTestButton.UseVisualStyleBackColor = true;
            this.AddTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // ProceduresList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.Controls.Add(this.AddTestButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TestsTable);
            this.Controls.Add(this.SaveDiseaseButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveSurveyButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddDiseaseButton);
            this.Controls.Add(this.SaveTestButton);
            this.Controls.Add(this.AddSurveyButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DiseaseTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SurveyTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProceduresTable);
            this.Name = "ProceduresList";
            this.Size = new System.Drawing.Size(778, 553);
            this.Load += new System.EventHandler(this.ProceduresList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ProceduresTable;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel SurveyTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel DiseaseTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddSurveyButton;
        private System.Windows.Forms.Button AddDiseaseButton;
        private System.Windows.Forms.Button SaveSurveyButton;
        private System.Windows.Forms.Button SaveDiseaseButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveTestButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel TestsTable;
        private System.Windows.Forms.Button AddTestButton;
    }
}
