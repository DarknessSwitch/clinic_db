using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_db
{
    public partial class StaffList : UserControl
    {
        public StaffList()
        {
            InitializeComponent();
        }
       
        private void StaffList_Load(object sender, EventArgs e)
        {

        }

        public void LoadEntries()
        {
            this.tableLayoutPanel1.Controls.Clear();
            DbConnector db = DbConnector.GetInstance();
            List<EmployeeModel> staffList = new List<EmployeeModel>();
            staffList = db.GetStaffList();
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.RowCount = staffList.Count;
            this.tableLayoutPanel1.Update();
            for (int i = 0; i < staffList.Count; i++)
            {
                LinkLabel lb = new LinkLabel(); lb.Text = staffList[i].Name; lb.Show();
                Label lb1 = new Label(); lb1.Text = staffList[i].Specialty; lb1.Show();
                DeleteButton b = new DeleteButton(staffList[i].id, "employee"); b.Show();
                lb.Click += lb_Click;
                b.Click += b_Click;
                this.tableLayoutPanel1.Controls.Add(lb, 0, i);
                this.tableLayoutPanel1.Controls.Add(lb1, 1, i);
                this.tableLayoutPanel1.Controls.Add(b, 2, i);
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            DeleteButton b = (DeleteButton)sender;
            b.ExecuteDeletion();
            LoadEntries();
        }

        void lb_Click(object sender, EventArgs e)
        {
            LinkLabel castedSender = (LinkLabel)sender;
            Form f = new Form();
            StaffProfile profileForm = new StaffProfile(castedSender.Text);
            f.Size = profileForm.Size;
            profileForm.Show();
            f.Controls.Add(profileForm);
            f.Show();
            f.FormClosing += f_FormClosing;
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadEntries();
        }

        private void StaffList_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Enabled = false;
            AddEmployeeForm af = new AddEmployeeForm(this);
            af.Show();
        }
    }
}
