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
    public partial class ReportMenu : UserControl
    {
        private List<PatientModel> _patients;
        private List<EmployeeModel> _docs;
        private string[] months = {"january","february","march","april","may","june","july",
                                        "august", "september","october","november", "december"};
        public ReportMenu()
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            _patients = DbConnector.GetInstance().GetPatientList();
            _docs = DbConnector.GetInstance().GetStaffList();
            PatientBox.Items.Clear();
            PatientBox.BeginUpdate(); _patients.ForEach(x => PatientBox.Items.Add(x.Name));
            PatientBox.EndUpdate(); PatientBox.Text = _patients[0].Name;
            DoctorBox.Items.Clear();
            DoctorBox.BeginUpdate(); _docs.ForEach(x => DoctorBox.Items.Add(x.Name));
            DoctorBox.EndUpdate(); DoctorBox.Text = _docs[0].Name;



            List<string> years = DbConnector.GetInstance().GetDiseaseYears();
            StartYearBox.Items.Clear();
            StartYearBox.BeginUpdate();
            years.ForEach(x => StartYearBox.Items.Add(x));
            StartYearBox.EndUpdate(); StartYearBox.SelectedIndex = 0;

            EndYearBox.Items.Clear();
            EndYearBox.BeginUpdate();
            years.ForEach(x => EndYearBox.Items.Add(x));
            EndYearBox.EndUpdate(); EndYearBox.SelectedIndex = 0;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void PSessionsButton_Click(object sender, EventArgs e)
        {
            int id = DbConnector.GetInstance().GetPatientProfile(PatientBox.Text).id;
            string query = String.Format(@"select distinct mc.disease_name as 'disease',  diseasetype.name as 'disease type',
 session.date_time as 'session date',proc.name as 'procedure',
	    employee.name as doctor, session.total_cost as 'cost' 
        from session inner join proc on proc.id=session.proc_id
        inner join employee on employee.id = session.employee_id
	    inner join (select medical_card.id,medical_card.disease_name,medical_card.type_id
				from medical_card inner join patient
				on medical_card.patient_id = {0}) as mc
                on session.card_id = mc.id
				inner join diseasetype on diseasetype.id = mc.type_id;", id);
            Form f = new Form();
            ReportWindow w = new ReportWindow("Sessions of " + PatientBox.Text, query);
            f.Controls.Add(w);
            f.Size = w.Size;
            f.Show();
        }

        private void PTestsButton_Click(object sender, EventArgs e)
        {
            int id = DbConnector.GetInstance().GetPatientProfile(PatientBox.Text).id;
            string query = String.Format(@"select distinct testtype.name, test.date_time as 'date', test.result as result
	from test inner join (select medical_card.id 
							from medical_card inner join patient
									on medical_card.patient_id = {0}) as mc
			   on test.card_id = mc.id
               inner join testtype on testtype.id = test.id;", id);
            Form f = new Form();
            ReportWindow w = new ReportWindow("Tests of " + PatientBox.Text, query);
            f.Controls.Add(w);
            f.Size = w.Size;
            f.Show();
        }

        private void PSurveysButton_Click(object sender, EventArgs e)
        {
            int id = DbConnector.GetInstance().GetPatientProfile(PatientBox.Text).id;
            string query = String.Format(@"select distinct surveytype.name as 'survey name', mc.disease_name as disease, survey.result,survey.date_time as 
    'survey date',employee.name as doctor 
    from survey 
    inner join employee on employee.id = survey.employee_id
	inner join (select medical_card.id,medical_card.disease_name from medical_card
				inner join patient
				on medical_card.patient_id ={0}) as mc
                on survey.card_id = mc.id
                inner join surveytype on surveytype.id=survey.type_id;", id);
            Form f = new Form();
            ReportWindow w = new ReportWindow("Surveys of " + PatientBox.Text, query);
            f.Controls.Add(w);
            f.Size = w.Size;
            f.Show();
        }

        private void DSessionsButton_Click(object sender, EventArgs e)
        {
            int id = DbConnector.GetInstance().GetEmployeeProfile(DoctorBox.Text).id;
            string query = String.Format(@"select session.date_time as 'date', proc.name as 'procedure', mc.disease_name as 'disease name',
                        employee.name as 'doctor' , session.total_cost as 'cost'
                            from session inner join employee 
	                        on session.employee_id = {0}
                                inner join proc
                                on proc.id = session.proc_id
                            inner join medical_card as mc 
                                on mc.id = session.card_id;", id);
            Form f = new Form();
            ReportWindow w = new ReportWindow("Procedure sessions by "  + DoctorBox.Text, query);
            f.Controls.Add(w);
            f.Size = w.Size;
            f.Show();
        }

        private void DSurveysButton_Click(object sender, EventArgs e)
        {
            int id = DbConnector.GetInstance().GetEmployeeProfile(DoctorBox.Text).id;
            string query = String.Format(@"select distinct surveytype.name as 'survey name', mc.disease_name as disease, survey.result,survey.date_time as 
                        'survey date',mc.name as 'patient'
                        from survey 
                        inner join employee on survey.employee_id = {0}
	                    inner join (select medical_card.id,medical_card.disease_name,patient.name from medical_card
				inner join patient
				on medical_card.patient_id = patient.id) as mc
                on survey.card_id = mc.id
                 inner join surveytype on surveytype.id=survey.type_id;", id);
            Form f = new Form();
            ReportWindow w = new ReportWindow("Surveys by " + DoctorBox.Text, query);
            f.Controls.Add(w);
            f.Size = w.Size;
            f.Show();
        }

        private void TestConfirmButton_Click(object sender, EventArgs e)
        {
            string startDate = TestStartPicker.Value.ToString("yyyy-MM-dd");
            string endDate = TestEndPicker.Value.ToString("yyyy-MM-dd");
            string query = string.Format(@"select testtype.name as 'test name', test.date_time as 'date', test.result, 
                        mc.disease_name as 'suffered disease', mc.name as 'patient'
	                    from test inner join (select medical_card.disease_name, medical_card.id,patient.name
								from medical_card inner join patient
													on patient.id=medical_card.patient_id) as mc
					 on mc.id = test.card_id
                     inner join testtype on testtype.id = test.type_id
                     where date_format(test.date_time,'%Y-%m-%d')>=Date('{0}') 
                     and date_format(test.date_time,'%Y-%m-%d')<=Date('{1}');", startDate, endDate);
            Form f = new Form();
            ReportWindow w = new ReportWindow("Tests made from " + startDate +" to "+endDate, query);
            f.Controls.Add(w);
            f.Size = w.Size;
            f.Show();
        }

        private void SurveysConfirmButton_Click(object sender, EventArgs e)
        {
            string startDate = SurveyStartPicker.Value.ToString("yyyy-MM-dd");
            string endDate = SurveyEndPicker.Value.ToString("yyyy-MM-dd");
            string query = string.Format(@"select distinct surveytype.name as 'survey name', mc.disease_name as disease, survey.result,survey.date_time as 
                        'survey date',mc.name as 'patient',employee.name as 'doctor'
                        from survey 
                        inner join employee on survey.employee_id = employee.id
	                    inner join (select medical_card.id,medical_card.disease_name,patient.name from medical_card
				inner join patient
				on medical_card.patient_id = patient.id) as mc
                on survey.card_id = mc.id
                inner join surveytype on surveytype.id=survey.type_id
                where date_format(survey.date_time,'%Y-%m-%d')>=('{0}')
                and date_format(survey.date_time,'%Y-%m-%d')<=('{1}');", startDate, endDate);
            Form f = new Form();
            ReportWindow w = new ReportWindow("Surveys made from " + startDate + " to " + endDate, query);
            f.Controls.Add(w);
            f.Size = w.Size;
            f.Show();
        }

        private void SessionsConfirmButton_Click(object sender, EventArgs e)
        {
            string startDate = SessionStartPicker.Value.ToString("yyyy-MM-dd");
            string endDate = SessionEndPicker.Value.ToString("yyyy-MM-dd");
            string query = string.Format(@"select proc.name as 'procedure', session.date_time as 'date',  
                        mc.disease_name as 'treated disease' ,
                        employee.name as 'doctor',mc.name as 'patient', session.total_cost as 'cost'
                            from session inner join employee
					            on employee.id = session.employee_id
				             inner join proc
					             on proc.id = session.proc_id
			                inner join (select medical_card.disease_name, medical_card.id,patient.name
								from medical_card inner join patient
									on patient.id = medical_card.patient_id) as mc
                                    on mc.id = session.card_id
                where date_format(session.date_time,'%Y-%m-%d')>=('{0}')
                and date_format(session.date_time,'%Y-%m-%d')<=('{1}');", startDate, endDate);
            Form f = new Form();
            ReportWindow w = new ReportWindow("Procedure sessions made from " + startDate + " to " + endDate, query);
            f.Controls.Add(w);
            f.Size = w.Size;
            f.Show();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.AutoSize = true;
            f.Controls.Add(new ChartControl());
            f.Show();
        }

        private void ChangeChartButton_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.AutoSize = true;
            f.Controls.Add(new ChartControl(int.Parse(StartYearBox.Text),int.Parse(EndYearBox.Text)));
            f.Show();
        }
    }
}
