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
    public partial class AddCard : Form
    {
        private PatientModel _patient;
        private List<EmployeeModel> _docs;

        public AddCard(PatientModel patient)
        {
            InitializeComponent();
            _patient = patient;
            TopLabel.Text += " " + _patient.Name;
            _docs = DbConnector.GetInstance().GetStaffList();
            DoctorBox.BeginUpdate();
            _docs.ForEach(x => DoctorBox.Items.Add(x.Name));
            DoctorBox.EndUpdate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            EmployeeModel emp = DbConnector.GetInstance().GetEmployeeProfile(DoctorBox.Text);
            vals.Add(String.Format("\"{0}\"", NameBox.Text));
            vals.Add(SufferedBox.Text);
            string cured = CuredCheckBox.CheckState.ToString()=="Checked" ? "true" : "false";
            vals.Add(cured);
            vals.Add(emp.id.ToString());
            vals.Add(_patient.id.ToString());
            DbConnector.GetInstance().AddEntry("medical_card", vals);
            this.Close();
        }
    }
}
