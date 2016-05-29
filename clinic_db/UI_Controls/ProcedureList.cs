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
    public partial class ProceduresList : UserControl
    {
        private List<ProcedureModel> procs;
        private List<TypeModel> tests;
        private List<TypeModel> survs;
        private List<TypeModel> dis;

        public ProceduresList()
        {
            InitializeComponent();
        }

        private void ProceduresList_Load(object sender, EventArgs e)
        {
            LoadAllEnries();
        }
        public void LoadAllEnries()
        {
            LoadEntriesProcs();
            LoadEntriesSurveys();
            LoadEntriesTests();
            LoadEntriesDisease();
        }


        #region SURVEYS
        public void LoadEntriesSurveys()
        {
            SurveyTable.Controls.Clear();
            survs = DbConnector.GetInstance().GetSurveyTypes();
            SurveyTable.RowCount = survs.Count;
            SurveyTable.Update();
            for (int i = 0; i < survs.Count; i++)
            {
                TextBox lb = new TextBox(); lb.Font = new Font("Calibri", 12); lb.Text = survs[i].Name; lb.Show();
                TextBox lb1 = new TextBox(); lb1.Font = new Font("Calibri", 12); lb1.Text = survs[i].Cost.ToString(); lb1.Show();
                DeleteButton b2 = new DeleteButton(survs[i].id, "surveytype");
                b2.Click += b2_Click;
                this.SurveyTable.Controls.Add(lb, 0, i);
                this.SurveyTable.Controls.Add(lb1, 1, i);
                this.SurveyTable.Controls.Add(b2, 2, i);
            }
        }

        void b2_Click(object sender, EventArgs e)
        {
            DeleteButton casted = (DeleteButton)sender;
            casted.ExecuteDeletion();
            LoadEntriesSurveys();
        }

        private void AddSurveyButton_Click(object sender, EventArgs e)
        {
            List<string> entry = new List<string>() { "\"\"", "0" };
            DbConnector.GetInstance().AddEntry("surveytype", entry);
            LoadEntriesSurveys();
        }

        private void SaveSurveyButton_Click(object sender, EventArgs e)
        {
            DbConnector db = DbConnector.GetInstance();
            for (int i = 0; i < SurveyTable.RowCount; i++)
            {
                survs[i].Name = SurveyTable.GetControlFromPosition(0, i).Text;
                survs[i].Cost = int.Parse(SurveyTable.GetControlFromPosition(1, i).Text);
                db.UpdateType(survs[i], "survey");
            }
        }
        #endregion


        #region TEST
        public void LoadEntriesTests()
        {
            TestsTable.Controls.Clear();
            tests = DbConnector.GetInstance().GetTestTypes();
            TestsTable.RowCount = tests.Count;
            TestsTable.Update();
            for (int i = 0; i < tests.Count; i++)
            {
                TextBox lb = new TextBox(); lb.Font = new Font("Calibri", 12); lb.Text = tests[i].Name; lb.Show();
                TextBox lb1 = new TextBox(); lb1.Font = new Font("Calibri", 12); lb1.Text = tests[i].Cost.ToString(); lb1.Show();
                DeleteButton b1 = new DeleteButton(tests[i].id, "testtype");
                b1.Click += b1_Click;
                this.TestsTable.Controls.Add(lb, 0, i);
                this.TestsTable.Controls.Add(lb1, 1, i);
                this.TestsTable.Controls.Add(b1, 2, i);
            }
        }

        void b1_Click(object sender, EventArgs e)
        {
            DeleteButton casted = (DeleteButton)sender;
            casted.ExecuteDeletion();
            LoadEntriesTests();
        }

        private void AddTestButton_Click(object sender, EventArgs e)
        {
            List<string> entry = new List<string>() { "\"\"", "0" };
            DbConnector.GetInstance().AddEntry("testtype", entry);
            LoadEntriesTests();
        }

        private void SaveTestButton_Click(object sender, EventArgs e)
        {
            DbConnector db = DbConnector.GetInstance();
            for (int i = 0; i < TestsTable.RowCount; i++)
            {
                tests[i].Name = TestsTable.GetControlFromPosition(0, i).Text;
                tests[i].Cost = int.Parse(TestsTable.GetControlFromPosition(1, i).Text);
                db.UpdateType(tests[i], "test");
            }
        }

        #endregion


        #region PROCEDURES
        public void LoadEntriesProcs()
        {
            this.ProceduresTable.Controls.Clear();
            procs = DbConnector.GetInstance().GetProceduresList();
            this.ProceduresTable.RowCount = procs.Count;
            this.ProceduresTable.Update();
            for (int i = 0; i < procs.Count; i++)
            {
                TextBox lb = new TextBox(); lb.Font = new Font("Calibri", 12); lb.Text = procs[i].Name; lb.Show();
                TextBox lb1 = new TextBox(); lb1.Font = new Font("Calibri", 12); lb1.Text = procs[i].Duration.ToString(); lb1.Show();
                TextBox lb2 = new TextBox(); lb2.Font = new Font("Calibri", 12); lb2.Text = procs[i].Cost.ToString(); lb2.Show();
                DeleteButton b = new DeleteButton(procs[i].id, "proc");
                b.Click += b_Click;
                this.ProceduresTable.Controls.Add(lb, 0, i);
                this.ProceduresTable.Controls.Add(lb1, 1, i);
                this.ProceduresTable.Controls.Add(lb2, 2, i);
                this.ProceduresTable.Controls.Add(b, 3, i);
            }
        }
        void b_Click(object sender, EventArgs e)
        {
            DeleteButton b = (DeleteButton)sender;
            b.ExecuteDeletion();
            LoadEntriesProcs();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<string> entry = new List<string>(){"\"\"","0","0"};
            DbConnector.GetInstance().AddEntry("proc", entry);
            LoadEntriesProcs();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DbConnector db = DbConnector.GetInstance();
            for (int i = 0; i < ProceduresTable.RowCount; i++)
            {
                procs[i].Name = ProceduresTable.GetControlFromPosition(0,i).Text;
                procs[i].Duration = int.Parse(ProceduresTable.GetControlFromPosition(1,i).Text);
                procs[i].Cost = int.Parse(ProceduresTable.GetControlFromPosition(2,i).Text);
                db.UpdateProcedure(procs[i]);
            }
        }
#endregion

        #region DISEASE
        public void LoadEntriesDisease()
        {
            dis = DbConnector.GetInstance().GetDiseaseTypes();
            DiseaseTable.Controls.Clear();
            DiseaseTable.RowCount = dis.Count;
            DiseaseTable.Update();
            for (int i = 0; i < dis.Count; i++)
            {
                TextBox lb = new TextBox(); lb.Font = new Font("Calibri", 12); lb.Text = dis[i].Name; lb.Show();
                DeleteButton b3 = new DeleteButton(dis[i].id, "diseasetype");
                b3.Click += b3_Click;
                this.DiseaseTable.Controls.Add(lb, 0, i);
                this.DiseaseTable.Controls.Add(b3, 1, i);
            }
        }

        void b3_Click(object sender, EventArgs e)
        {
            DeleteButton b = (DeleteButton)sender;
            b.ExecuteDeletion();
            LoadEntriesDisease();
        }

        private void AddDiseaseButton_Click(object sender, EventArgs e)
        {
            List<string> entry = new List<string>() { "\"\"" };
            DbConnector.GetInstance().AddEntry("diseasetype", entry);
            LoadEntriesDisease();
        }

        private void SaveDiseaseButton_Click(object sender, EventArgs e)
        {
            DbConnector db = DbConnector.GetInstance();
            for (int i = 0; i < DiseaseTable.RowCount; i++)
            {
                dis[i].Name = DiseaseTable.GetControlFromPosition(0, i).Text;
                db.UpdateType(dis[i], "disease");
            }
        }
        #endregion
    
    }
}
