using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_db
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StaffTab.Enter += StaffTab_Enter;
            StaffList slist = new StaffList();
            this.StaffTab.Controls.Add(slist);

            PatientsTab.Enter += PatientsTab_Enter;
            PatientList plist = new PatientList();
            this.PatientsTab.Controls.Add(plist);

            ProceduresTab.Enter += ProceduresTab_Enter;
            ProceduresList prlist = new ProceduresList();
            this.ProceduresTab.Controls.Add(prlist);

            ReportsTab.Enter += ReportsTab_Enter;
            ReportMenu m = new ReportMenu();
            ReportsTab.Controls.Add(m);
        }

        void ReportsTab_Enter(object sender, EventArgs e)
        {
            ReportMenu m = (ReportMenu)ReportsTab.Controls[0];
            m.LoadData();
        }

        void PatientsTab_Enter(object sender, EventArgs e)
        {
            PatientList list = (PatientList)PatientsTab.Controls[0];
            list.LoadEntries();
        }

        void StaffTab_Enter(object sender, EventArgs e)
        {
            StaffList list = (StaffList)StaffTab.Controls[0];
            list.LoadEntries();
        }

        void ProceduresTab_Enter(object sender, EventArgs e)
        {
            ProceduresList list = (ProceduresList)ProceduresTab.Controls[0];
            list.LoadAllEnries();
        }

        private void StaffTab_Click(object sender, EventArgs e)
        {

        }

        private void ReportsTab_Click(object sender, EventArgs e)
        {

        }

        private void StaffTab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddTestButton_Click(object sender, EventArgs e)
        {

        }
    }
}
