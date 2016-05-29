using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace clinic_db
{
    class DbConnector
    {
        #region OLD_FIXED
        private static DbConnector instance = null;
        private MySqlConnection connection;

        public static DbConnector GetInstance()
        {
            if (instance == null)
                instance = new DbConnector();
            return instance;
        }
        private DbConnector()
        {
            connection =
                new MySqlConnection(@"server=localhost;user=root;database=clinic;port=3306;password=1111;
            Convert Zero Datetime=True;");
            connection.Open();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public int AddEntry(string tableName, List<string> values)
        { 
            string args = String.Join(",",values);
            MySqlCommand cmd = new MySqlCommand(string.Format(@"insert into {0} values(null,{1});",
                tableName,args),connection);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("select last_insert_id();",connection);
            MySqlDataReader r = cmd.ExecuteReader(); r.Read();
            int result = int.Parse(r[0].ToString());
            r.Close();
            return result;
        }

        public void DeleteEntry(int id, string tableName)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format(@"delete from {0} where id={1}",
                                                             tableName, id.ToString()), connection);
            cmd.ExecuteNonQuery();
        }

        private MySqlDataReader GetReaderForQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, this.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public List<EmployeeModel> GetStaffList()
        {
            List<EmployeeModel> result = new List<EmployeeModel>();
            string query = @"select * from employee;";
            MySqlDataReader r = GetReaderForQuery(query);
            while(r.Read())
            {
                result.Add(new EmployeeModel(r[0].ToString(), r[1].ToString(), r[2].ToString(),
                                    r[3].ToString(),r[4].ToString()));
            }
            r.Close();
            return result;
        }

        public EmployeeModel GetEmployeeProfile(string name)
        {
            MySqlDataReader reader = GetReaderForQuery(String.Format(  
                                   @"select * from employee where employee.name = ""{0}""", name));
            reader.Read();
            EmployeeModel result = new EmployeeModel(reader[0].ToString(), reader[1].ToString(),
                reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
            reader.Close();
            return result;
        }

        public EmployeeModel GetEmployeeProfile(int id)
        {
            MySqlDataReader reader = GetReaderForQuery(String.Format(
                                   @"select * from employee where employee.id = ""{0}""", id.ToString()));
            reader.Read();
            EmployeeModel result = new EmployeeModel(reader[0].ToString(), reader[1].ToString(),
                reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
            reader.Close();
            return result;
        }

        public void UpdateEmployeeProfile(EmployeeModel profile)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format(@"update employee set 
                                                name=""{0}"",specialty=""{1}"",hour_salary={2},
                                                   years_of_experience={3} where id={2}",
                                                profile.Name, profile.Specialty,profile.HourSalary,
                                                profile.YearsOfexperience,profile.id), connection);
            cmd.ExecuteNonQuery();
        }

        public List<PatientModel> GetPatientList()
        {
            List<PatientModel> result = new List<PatientModel>();
            MySqlDataReader reader = GetReaderForQuery(@"select * from patient;");
            while(reader.Read())
            {
                result.Add(new PatientModel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
            }
            reader.Close();
            return result;
        }

        public PatientModel GetPatientProfile(string name)
        {
            MySqlDataReader reader = GetReaderForQuery(string.Format(@"select * from patient where name=""{0}"";",name));
            reader.Read();
            PatientModel result = new PatientModel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            reader.Close();
            return result;
        }

        public void UpdatePatientProfile(PatientModel profile)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format(@"update patient set name=""{0}"",address=""{1}"",age={2},
                            phone_number=""{3}"",sessions_taken={4} where id={5};",
                            profile.Name, profile.Address, profile.Age, profile.PhoneNumber, profile.SessionsTaken,profile.id), connection);
            cmd.ExecuteNonQuery();
                                                                              
        }

        public List<CardModel> GetCards(int id)
        {
            List<CardModel> result = new List<CardModel>();
            string query = String.Format(@"select c.id,c.disease_name,c.years_suffered, c.is_cured,
                    c.employee_id,c.patient_id, employee.name as doctor,
                    c.type_id, diseasetype.name as 'type',c.added_on
                    from medical_card as c inner join employee
										on employee.id = c.employee_id
                                            inner join diseasetype
                                            on c.type_id=diseasetype.id
                                            where patient_id={0};", id);
            MySqlDataReader r = GetReaderForQuery(query);
            while(r.Read())
            {
                result.Add(new CardModel(r[0].ToString(), r[1].ToString(), r[2].ToString(),
                        r[3].ToString(), r[4].ToString(), r[5].ToString(), r[6].ToString(),
                        r[7].ToString(),r[8].ToString(),r[9].ToString()));
            }
            r.Close();
            return result;            
        }

        public List<ProcedureModel> GetProceduresList()
        {
            List<ProcedureModel> result = new List<ProcedureModel>();
            MySqlDataReader reader = GetReaderForQuery(@"select * from proc;");
            while (reader.Read())
            {
                result.Add(new ProcedureModel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString()));
            }
            reader.Close();
            return result;
        }

        public ProcedureModel GetProcedureProfile(int id)
        {
            MySqlDataReader r = GetReaderForQuery(String.Format(
                                        @"select * from proc where id={0};",id.ToString())); 
            r.Read();
            ProcedureModel result = new ProcedureModel(r[0].ToString(), r[1].ToString(), 
                            r[2].ToString(), r[3].ToString());
            r.Close();
            return result;
        }

        public ProcedureModel GetProcedureProfile(string name)
        {
            MySqlDataReader r = GetReaderForQuery(String.Format(
                                        @"select * from proc where name=""{0}"";", name));
            r.Read();
            ProcedureModel result = new ProcedureModel(r[0].ToString(), r[1].ToString(),
                            r[2].ToString(), r[3].ToString());
            r.Close();
            return result;
        }

        public void UpdateProcedure(ProcedureModel p)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format(@"update proc set 
                                                name=""{0}"",duration={1},cost={2}
                                                    where id={3};",
                                    p.Name, p.Duration, p.Cost, p.id), connection);
            cmd.ExecuteNonQuery();
        }

        public List<TestModel> GetTests(int cardId)
        {
            List<TestModel> result = new List<TestModel>();
            MySqlDataReader r = GetReaderForQuery(String.Format
                                                (@"select test.id,test.date_time,test.result,
                             test.card_id,test.type_id,testtype.name 
                            from test inner join testtype
                            on test.type_id = testtype.id
                             where card_id = {0};", cardId));
            while (r.Read())
            {
                result.Add(new TestModel(r[0].ToString(),r[1].ToString(),r[2].ToString(),
                    r[3].ToString(),r[4].ToString(),r[5].ToString()));
            }
            r.Close();
            return result;
        }

        public void UpdateTest(TestModel t)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format(@"update test set 
                                                type_id=""{0}"",date_time=""{1}"",result=""{2}""
                                                    where id={3};",
                        t.type_id, t.DateTime, t.Result, t.id), connection);
            cmd.ExecuteNonQuery();
        }

        public List<SessionModel> GetSessions(int cardId)
        {
            List<SessionModel> result = new List<SessionModel>();
            MySqlDataReader r = GetReaderForQuery(String.Format
                                                (@"select session.id, session.date_time,
                            session.total_cost,session.proc_id,session.employee_id, 
                            session.card_id, proc.name as 'proc',
                            employee.name as 'doc'
                             from session inner join employee
				                    on employee.id = session.employee_id
                                    inner join proc
                                    on proc.id = session.proc_id
                                      where card_id = {0};", cardId));
            while (r.Read())
            {
                result.Add(new SessionModel(r[0].ToString(), r[1].ToString(), r[2].ToString(),
                                                r[3].ToString(), r[4].ToString(),r[5].ToString(),
                                                r[6].ToString(),r[7].ToString()));
            }
            r.Close();
            return result;
        }

        public List<SurveyModel> GetSurveys(int cardId)
        {
            List<SurveyModel> result = new List<SurveyModel>();
            MySqlDataReader r = GetReaderForQuery(String.Format
                                                (@"select survey.id, survey.date_time,
                        survey.result,survey.card_id,
                    survey.employee_id,survey.type_id,surveytype.name,employee.name as doctor
                      from survey inner join employee on survey.employee_id = employee.id
                      inner join surveytype on surveytype.id = survey.type_id
                      where survey.card_id = {0};", cardId));
            while (r.Read())
            {
                result.Add(new SurveyModel(r[0].ToString(), r[1].ToString(), r[2].ToString(),
                                                r[3].ToString(), r[4].ToString(), 
                                                r[5].ToString(),r[6].ToString(),r[7].ToString()));
            }
            r.Close();
            return result;
        }

        public void UpdateSurvey(SurveyModel s)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format(@"update survey set 
                                                type_id={0},date_time=""{1}"",result=""{2}"",
                                                    employee_id={3}
                                                    where id={4};",
            s.type_id, s.DateTime, s.Result, s.employeeId,s.id), connection);
            cmd.ExecuteNonQuery();
        }

        public DataSet GetDataset(string query)
        {
            DataSet result = new DataSet();
            MySqlDataAdapter a = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(a);
            a.Fill(result, "data");
            return result;
        }


        public List<TypeModel> GetTestTypes()
        {
            List<TypeModel> result = new List<TypeModel>();
            string query = @"select * from testtype;";
            MySqlDataReader r = GetReaderForQuery(query);
            while(r.Read())
            {
                result.Add(new TypeModel(r[0].ToString(), r[1].ToString(), r[2].ToString()));
            }
            r.Close();
            return result;
        }

        public List<TypeModel> GetSurveyTypes()
        {
            List<TypeModel> result = new List<TypeModel>();
            string query = @"select * from surveytype;";
            MySqlDataReader r = GetReaderForQuery(query);
            while(r.Read())
            {
                result.Add(new TypeModel(r[0].ToString(), r[1].ToString(), r[2].ToString()));
            }
            r.Close();
            return result;
        }

        public List<TypeModel> GetDiseaseTypes()
        {
            List<TypeModel> result = new List<TypeModel>();
            string query = @"select * from diseasetype;";
            MySqlDataReader r = GetReaderForQuery(query);
            while(r.Read())
            {
                result.Add(new TypeModel(r[0].ToString(), r[1].ToString()));
            }
            r.Close();
            return result;
        }

        public TypeModel GetDiseaseType(string name)
        {
            string query = string.Format(@"select * from diseasetype where name = ""{0}"";", name);
            MySqlDataReader r = GetReaderForQuery(query);
            r.Read();
            TypeModel result = new TypeModel(r[0].ToString(), r[1].ToString());
            r.Close();
            return result;
        }

        public void UpdateType(TypeModel item, string type)
        {
            string query = type=="disease" 
            ? string.Format(@"update {0}type set name=""{1}"" where id={2};",
                                type,item.Name,item.id)
            : string.Format(@"update {0}type set name=""{1}"",cost={2} where id={3};",
                                type,item.Name,item.Cost,item.id);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        #endregion OLD_FIXED
        public List<KeyValuePair<string, int>> GetDiseaseDisribution(int year)
        {
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();
            string query = string.Format(@"select diseasetype.name ,COUNT(*) as 'count'
                from diseasetype   
                inner join medical_card as mc
                on mc.type_id = diseasetype.id
                where year(mc.added_on)='{0}'
                group by diseasetype.name
                order by diseasetype.name;", year.ToString());
            MySqlDataReader r = GetReaderForQuery(query);
            while (r.Read())
            {
                result.Add(new KeyValuePair<string, int>(r[0].ToString(), int.Parse(r[1].ToString())));
            }
            r.Close();
            return result;
        }

        public List<KeyValuePair<string, int>> GetDiseaseDisribution()
        {
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();
            string query = @"select diseasetype.name ,COUNT(*) as 'count'
                from diseasetype inner join medical_card as mc
                on mc.type_id = diseasetype.id
                group by diseasetype.name;";
            MySqlDataReader r = GetReaderForQuery(query);
            while (r.Read())
            {
                result.Add(new KeyValuePair<string, int>(r[0].ToString(), int.Parse(r[1].ToString())));
            }
            r.Close();
            return result;
        }

        public List<string> GetDiseaseYears()
        {
            List<string> result = new List<string>();
            string query = @"select distinct year(medical_card.added_on) as y from medical_card
                            order by y asc;";
            MySqlDataReader r = GetReaderForQuery(query);
            while(r.Read())
                result.Add(r[0].ToString());
            r.Close();
            return result;
        }
    }
}
