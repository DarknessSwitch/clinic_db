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
    public partial class PatientList : UserControl
    {
        public PatientList()
        {
            InitializeComponent();
        }

        private void PatientList_Paint(object sender, PaintEventArgs e)
        {

        }

        void lb_Click(object sender, EventArgs e)
        {
            LinkLabel casted = (LinkLabel)sender;
            PatientProfile profile = new PatientProfile(casted.Text);
            Form f = new Form();
            f.Controls.Add(profile);
            f.Size = profile.Size;
            f.Show();
            profile.Show();
            f.FormClosing += f_FormClosing;
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadEntries();
        }
        public void LoadEntries()
        {
            this.tableLayoutPanel1.Controls.Clear();
            List<PatientModel> patients = DbConnector.GetInstance().GetPatientList();
            this.tableLayoutPanel1.RowCount = patients.Count;
            this.tableLayoutPanel1.Update();
            for (int i = 0; i < patients.Count; i++)
            {
                LinkLabel lb = new LinkLabel(); lb.AutoSize = true;
                lb.Font = new Font("Calibri",12); lb.Text = patients[i].Name; lb.Show();
                lb.Click += lb_Click;
                Label lb1 = new Label(); lb1.Text = patients[i].Age.ToString(); lb1.Font= new Font("Calibri",12); lb1.Show();
                Label lb2 = new Label(); lb2.AutoSize = true;
                lb2.Text = patients[i].Address; lb2.Font = new Font("Calibri", 12); lb2.Show();
                DeleteButton b = new DeleteButton(patients[i].id, "patient"); b.Click += b_Click;
                this.tableLayoutPanel1.Controls.Add(lb, 0, i);
                this.tableLayoutPanel1.Controls.Add(lb1, 1, i);
                this.tableLayoutPanel1.Controls.Add(lb2, 2, i);
                this.tableLayoutPanel1.Controls.Add(b, 3, i);
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            DeleteButton casted = (DeleteButton)sender;
            casted.ExecuteDeletion();
            LoadEntries();
        }
        private void PatientList_Load(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPatientForm f = new AddPatientForm(this);
            this.Parent.Parent.Enabled = false;
            f.Show();
        } 
    }
}
