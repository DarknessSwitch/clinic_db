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
    public partial class AddSession : Form
    {
        private List<ProcedureModel> _procs;
        private List<EmployeeModel> _docs;
        private CardModel _card;

        public AddSession(CardModel card)
        {
            InitializeComponent();
            _card = card;
            _procs = DbConnector.GetInstance().GetProceduresList();
            _docs = DbConnector.GetInstance().GetStaffList();
            ProcedureBox.BeginUpdate();
            _procs.ForEach(x => ProcedureBox.Items.Add(x.Name));
            ProcedureBox.EndUpdate();
            DoctorBox.BeginUpdate();
            _docs.ForEach(x => DoctorBox.Items.Add(x.Name));
            DoctorBox.EndUpdate();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            ProcedureModel proc = DbConnector.GetInstance().GetProcedureProfile(ProcedureBox.Text);
            EmployeeModel emp = DbConnector.GetInstance().GetEmployeeProfile(DoctorBox.Text);
            int cost = proc.Cost + emp.HourSalary*proc.Duration/60;
            vals.Add(string.Format("\"{0}\"", DatePicker.Value.ToString("yyyy-MM-dd hh:mm:ss")));
            vals.Add(cost.ToString());
            vals.Add(proc.id.ToString());
            vals.Add(emp.id.ToString());
            vals.Add(_card.id.ToString());
            DbConnector.GetInstance().AddEntry("session", vals);
            this.Close();
        }
    }
}
