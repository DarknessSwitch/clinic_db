﻿using System;
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
    public partial class CardProfile : UserControl
    {
        private PatientModel _patient;
        private CardModel _card;
        private List<TestModel> _tests;
        private List<SessionModel> _sessions;
        private List<SurveyModel> _surveys;
        private List<EmployeeModel> _employees;
        private List<TypeModel> _tt;
        private List<TypeModel> _st;

        public CardProfile()
        {
            InitializeComponent();
        }

        public CardProfile(PatientModel patient, CardModel card)
        {
            InitializeComponent();
            _patient = patient;
            _card = card;
            _employees = DbConnector.GetInstance().GetStaffList();
            _tt = DbConnector.GetInstance().GetTestTypes();
            _st = DbConnector.GetInstance().GetSurveyTypes();
            TopLabel.Text = _card.Name + " medical card of " + _patient.Name+"\nAdded on "+_card.Added;
            LoadEntriesTests();
            LoadEntriesSessions();
            LoadEntriesSurveys();
        }

        public void LoadEntriesSurveys()
        {
            SurveysTable.Controls.Clear();
            _surveys = DbConnector.GetInstance().GetSurveys(_card.id);
            SurveysTable.RowCount = _tests.Count;
            SurveysTable.Update();
            for (int i = 0; i < _surveys.Count; i++)
            {
                ComboBox n = new ComboBox(); n.Font = new Font("Calibri", 12);
                n.BeginUpdate();
                _st.ForEach(x => n.Items.Add(x.Name));
                n.EndUpdate(); n.Text = _surveys[i].Type;
             
                DateTimePicker lb1 = new DateTimePicker(); lb1.Size = new Size(120, lb1.Height);
                lb1.Text = _surveys[i].DateTime; lb1.Show();

                TextBox lb2 = new TextBox(); lb2.Font = new Font("Calibri", 12); 
                lb2.Text = _surveys[i].Result; lb2.Show();
                
                ComboBox cb = new ComboBox(); cb.Font = new Font("Calibri", 12); 
                cb.BeginUpdate();
                _employees.ForEach(x => cb.Items.Add(x.Name));
                cb.EndUpdate(); cb.Text = _surveys[i].EmployeeName;

                Label lb3 = new Label(); lb3.Font = new Font("Calibri", 12);
                lb3.Text = _st.Find(x => x.Name == _surveys[i].Type).Cost.ToString(); lb3.Show();

                DeleteButton vb = new DeleteButton(_surveys[i].id, "survey");
                vb.Click += vb_Click;
                this.SurveysTable.Controls.Add(n, 0, i);
                this.SurveysTable.Controls.Add(lb1, 1, i);
                this.SurveysTable.Controls.Add(lb2, 2, i);
                this.SurveysTable.Controls.Add(cb, 3, i);
                this.SurveysTable.Controls.Add(lb3, 4, i);
                this.SurveysTable.Controls.Add(vb, 5, i);
            }
        }

        void vb_Click(object sender, EventArgs e)
        {
            DeleteButton b = (DeleteButton)sender;
            b.ExecuteDeletion();
            LoadEntriesSurveys();
        }

        public void LoadEntriesSessions()
        {
            SessionsTable.Controls.Clear();
            _sessions= DbConnector.GetInstance().GetSessions(_card.id);
            SessionsTable.RowCount = _sessions.Count;
            SessionsTable.Update();
            for (int i = 0; i < _sessions.Count; i++)
            {
                Label lb = new Label(); lb.AutoSize = true; lb.Font = new Font("Calibri", 12); lb.Size = new Size(150, lb.Height);
                lb.Text = _sessions[i].ProcedureName; lb.Show();

                DateTimePicker lb1 = new DateTimePicker(); lb1.Size = new Size(120, lb1.Height);
                lb1.Text = _sessions[i].DateTime; lb1.Show();

                Label lb2 = new Label(); lb2.Font = new Font("Calibri", 12); lb2.Text = _sessions[i].EmployeeName; lb2.Show();
                Label lb3 = new Label(); lb3.Font = new Font("Calibri", 12); lb3.Text = _sessions[i].Cost.ToString(); lb2.Show();
                DeleteButton sb = new DeleteButton(_sessions[i].id, "session");
                sb.Click+=sb_Click;
                this.SessionsTable.Controls.Add(lb, 0, i);
                this.SessionsTable.Controls.Add(lb1, 1, i);
                this.SessionsTable.Controls.Add(lb2, 2, i);
                this.SessionsTable.Controls.Add(lb3, 3, i);
                this.SessionsTable.Controls.Add(sb, 4, i);
            }
        }

        void sb_Click(object sender, EventArgs e)
        {
            DeleteButton b = (DeleteButton)sender;
            b.ExecuteDeletion();
            LoadEntriesSessions();
        }

        public void LoadEntriesTests()
        {
            CuredLabel.Text = _card.IsCured ? "Cured" : "Not cured";
            TestsTable.Controls.Clear();
            _tests = DbConnector.GetInstance().GetTests(_card.id);
            TestsTable.RowCount = _tests.Count;
            TestsTable.Update();
            for (int i = 0; i < _tests.Count; i++)
            {
                DateTimePicker lb1 = new DateTimePicker(); lb1.Size = new Size(120, lb1.Height);
                lb1.Text = _tests[i].DateTime; lb1.Show();
                TextBox lb2 = new TextBox(); lb2.Font = new Font("Calibri", 12);
                lb2.Size = new Size(300, lb2.Height); 
                lb2.Text = _tests[i].Result; lb2.Show();
                ComboBox cb = new ComboBox(); cb.BeginUpdate(); _tt.ForEach(x => cb.Items.Add(x.Name)); cb.EndUpdate();
                cb.Text = _tests[i].Type;
                Label lb3 = new Label(); lb3.Font = new Font("Calibri", 12);
                lb3.Text = _tt.Find(x=>x.Name==_tests[i].Type).Cost.ToString(); lb3.Show();
                DeleteButton b = new DeleteButton(_tests[i].id, "test");
                b.Click += b_Click;
                this.TestsTable.Controls.Add(cb, 0, i);
                this.TestsTable.Controls.Add(lb1, 1, i);
                this.TestsTable.Controls.Add(lb2, 2, i);
                this.TestsTable.Controls.Add(lb3, 3, i);
                this.TestsTable.Controls.Add(b, 4, i);
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            DeleteButton b = (DeleteButton)sender;
            b.ExecuteDeletion();
            LoadEntriesTests();
        }

        private void AddTestButton_Click(object sender, EventArgs e)
        {
            List<string> val = new List<string>(){"'"+DateTime.Now.ToString("yyyy-MM-dd")+"'",
                                        "\"\"", _card.id.ToString(),_tt[0].id.ToString()};
            DbConnector.GetInstance().AddEntry("test", val);
            LoadEntriesTests();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DbConnector db = DbConnector.GetInstance();
            for (int i = 0; i < _tests.Count; i++)
            {
                DateTime dt = DateTime.Parse(TestsTable.GetControlFromPosition(1, i).Text);
                int tid = _tt.Find(x => x.Name == TestsTable.GetControlFromPosition(0, i).Text).id;
                _tests[i].type_id = tid;
                _tests[i].DateTime = dt.ToString("yyy-MM-dd HH:mm:ss");
                _tests[i].Result = TestsTable.GetControlFromPosition(2,i).Text;
                db.UpdateTest(_tests[i]);
            }
            LoadEntriesTests();
        }

        private void AddSessionButton_Click(object sender, EventArgs e)
        {
            this.Parent.Enabled = false;
            AddSession f = new AddSession(_card);
            f.FormClosing += f_FormClosing;
            f.Show();
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Parent.Enabled = true;
            LoadEntriesSessions();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form parent = (Form)this.Parent;
            parent.Close();
        }

        private void CardProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> val = new List<string>(){String.Format("\"{0}\"",
                                        DateTime.Now.ToString("yyyy-MM-dd")),
                                        "\"\"",  _card.id.ToString(),_employees[0].id.ToString(),
                                                    _st[0].id.ToString()};
            DbConnector.GetInstance().AddEntry("survey", val);
            LoadEntriesSurveys();
        }

        private void SaveSurveyButton_Click(object sender, EventArgs e)
        {
            DbConnector db = DbConnector.GetInstance();
            for (int i = 0; i < _surveys.Count; i++)
            {
                DateTime dt = DateTime.Parse(SurveysTable.GetControlFromPosition(1, i).Text);
                _surveys[i].type_id = _st.Find(x=>x.Name==SurveysTable.GetControlFromPosition(0, i).Text).id;
                _surveys[i].DateTime = dt.ToString("yyy-MM-dd HH:mm:ss");
                _surveys[i].Result = SurveysTable.GetControlFromPosition(2, i).Text;
                _surveys[i].employeeId = db.GetEmployeeProfile(SurveysTable.GetControlFromPosition(3, i).Text).id;
                db.UpdateSurvey(_surveys[i]);
            }
            LoadEntriesSurveys();
        }
    }
}
