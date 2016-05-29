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
    public partial class Check : UserControl
    {
        private string _date;
        private List<CardModel> _cards;
        private PatientModel _patient;
        private List<TestModel> _tests;
        private List<SurveyModel> _surveys;
        private List<SessionModel> _sessions;
        private List<TypeModel> _tt;
        private List<TypeModel> _st;

        private int _total;
        public Check(DateTime date, List<CardModel> cards,PatientModel patient)
        {
            InitializeComponent();
            string dateFormat = "dd.MM.yyyy";
            DbConnector db = DbConnector.GetInstance();
            _tt = db.GetTestTypes();
            _st = db.GetSurveyTypes();
            _total = 0;
            _date = date.ToString(dateFormat);
            _cards = cards;
            _patient = patient;
            TitleLabel.Text = string.Format("Check for {0}\n{1}",
                                _patient.Name, _date);
            _tests = new List<TestModel>();
            _surveys = new List<SurveyModel>();
            _sessions = new List<SessionModel>();
            foreach (CardModel c in _cards)
            {
                _tests.AddRange(db.GetTests(c.id).Where(x=>x.DateTime.Substring(0,10)==_date));
                _sessions.AddRange(db.GetSessions(c.id).Where(x=>x.DateTime.Substring(0,10)==_date));
                _surveys.AddRange(db.GetSurveys(c.id).Where(x=>x.DateTime.Substring(0,10)==_date));
            }
            FillTable();
        }

        private void FillTable()
        {
            Table.RowCount = 0;
            _tests.ForEach(x => AddEntry(x.Type, _tt.Find(y => x.Type == y.Name).Cost.ToString()));
            _surveys.ForEach(x => AddEntry(x.Type, _st.Find(y => x.Type == y.Name).Cost.ToString()));
            _sessions.ForEach(x => AddEntry(x.ProcedureName, x.Cost.ToString()));
            TotalLabel.Text = _total.ToString();
        }

        private void AddEntry(string name, string cost)
        {
            Table.RowCount++;
            Label nl = new Label(); nl.AutoSize = true; nl.Font = new Font("Calibri", 12);
            nl.Text = name;
            Label cl = new Label(); cl.AutoSize = true;  cl.Font = new Font("Calibri", 12);
            cl.Text = cost;
            Table.Controls.Add(nl,0, Table.RowCount - 1);
            Table.Controls.Add(cl, 1, Table.RowCount - 1);
            _total += int.Parse(cost);
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
            this.Dispose();
        }
    }
}
