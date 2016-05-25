namespace clinic_db
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PatientsTab = new System.Windows.Forms.TabPage();
            this.StaffTab = new System.Windows.Forms.TabPage();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.ProceduresTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PatientsTab);
            this.tabControl1.Controls.Add(this.StaffTab);
            this.tabControl1.Controls.Add(this.ProceduresTab);
            this.tabControl1.Controls.Add(this.ReportsTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 25);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 412);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // PatientsTab
            // 
            this.PatientsTab.Location = new System.Drawing.Point(4, 29);
            this.PatientsTab.Name = "PatientsTab";
            this.PatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTab.Size = new System.Drawing.Size(842, 379);
            this.PatientsTab.TabIndex = 0;
            this.PatientsTab.Text = "Patients";
            this.PatientsTab.UseVisualStyleBackColor = true;
            // 
            // StaffTab
            // 
            this.StaffTab.Location = new System.Drawing.Point(4, 29);
            this.StaffTab.Name = "StaffTab";
            this.StaffTab.Padding = new System.Windows.Forms.Padding(3);
            this.StaffTab.Size = new System.Drawing.Size(842, 379);
            this.StaffTab.TabIndex = 1;
            this.StaffTab.Text = "Staff";
            this.StaffTab.UseVisualStyleBackColor = true;
            this.StaffTab.Click += new System.EventHandler(this.StaffTab_Click);
            this.StaffTab.Paint += new System.Windows.Forms.PaintEventHandler(this.StaffTab_Paint);
            // 
            // ReportsTab
            // 
            this.ReportsTab.Location = new System.Drawing.Point(4, 29);
            this.ReportsTab.Name = "ReportsTab";
            this.ReportsTab.Size = new System.Drawing.Size(842, 379);
            this.ReportsTab.TabIndex = 2;
            this.ReportsTab.Text = "Reports";
            this.ReportsTab.UseVisualStyleBackColor = true;
            this.ReportsTab.Click += new System.EventHandler(this.ReportsTab_Click);
            // 
            // ProceduresTab
            // 
            this.ProceduresTab.Location = new System.Drawing.Point(4, 29);
            this.ProceduresTab.Name = "ProceduresTab";
            this.ProceduresTab.Size = new System.Drawing.Size(842, 379);
            this.ProceduresTab.TabIndex = 3;
            this.ProceduresTab.Text = "Procedures";
            this.ProceduresTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PatientsTab;
        private System.Windows.Forms.TabPage StaffTab;
        private System.Windows.Forms.TabPage ReportsTab;
        private System.Windows.Forms.TabPage ProceduresTab;
    }
}