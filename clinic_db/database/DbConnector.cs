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
                                                   years_of_expirience={3} where id={2}",
                                                profile.Name, profile.Specialty,profile.HourSalary,
                                                profile.YearsOfExpirience,profile.id), connection);
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
                    c.doctor_id,c.patient_id, d.name from medical_card as c inner join employee as d
                        on c.doctor_id=d.id where c.patient_id={0};", id);
            MySqlDataReader r = GetReaderForQuery(query);
            while(r.Read())
            {
                result.Add(new CardModel(r[0].ToString(), r[1].ToString(), r[2].ToString(),
                        r[3].ToString(), r[4].ToString(), r[5].ToString(), r[6].ToString()));
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
                                                (@"select * from test where card_id = {0}", cardId));
            while (r.Read())
            {
                result.Add(new TestModel(r[0].ToString(),r[1].ToString(),r[2].ToString(),
                                                r[3].ToString(),r[4].ToString()));
            }
            r.Close();
            return result;
        }

        public void UpdateTest(TestModel t)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format(@"update test set 
                                                name=""{0}"",date_time=""{1}"",result=""{2}""
                                                    where id={3};",
                        t.Name, t.DateTime, t.Result, t.id), connection);
            cmd.ExecuteNonQuery();
        }

        public List<SessionModel> GetSessions(int cardId)
        {
            List<SessionModel> result = new List<SessionModel>();
            MySqlDataReader r = GetReaderForQuery(String.Format
                                                (@"select * from session where card_id = {0}", cardId));
            while (r.Read())
            {
                result.Add(new SessionModel(r[0].ToString(), r[1].ToString(), r[2].ToString(),
                                                r[3].ToString(), r[4].ToString(),r[5].ToString()));
            }
            r.Close();
            return result;
        }

        public List<SurveyModel> GetSurveys(int cardId)
        {
            List<SurveyModel> result = new List<SurveyModel>();
            MySqlDataReader r = GetReaderForQuery(String.Format
                                                (@"select * from survey where card_id = {0}", cardId));
            while (r.Read())
            {
                result.Add(new SurveyModel(r[0].ToString(), r[1].ToString(), r[2].ToString(),
                                                r[3].ToString(), r[4].ToString(), r[5].ToString()));
            }
            r.Close();
            return result;
        }

        public void UpdateSurvey(SurveyModel s)
        {
            MySqlCommand cmd = new MySqlCommand(String.Format(@"update survey set 
                                                name=""{0}"",date_time=""{1}"",result=""{2}"",
                                                    doctor_id={3}
                                                    where id={4};",
            s.Name, s.DateTime, s.Result, s.employeeId,s.id), connection);
            cmd.ExecuteNonQuery();
        }

        private MySqlDataReader GetReaderForQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, this.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public DataSet GetDataset(string query)
        {
            DataSet result = new DataSet();
            MySqlDataAdapter a = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(a);
            a.Fill(result, "data");
            return result;
        }
    }
}
