using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    class SurveyModel
    {
        public SurveyModel(string id, string dt, string result, string cid, string eid,
            string tid,string type,string empl)
        {
            this.id = int.Parse(id);  DateTime = dt; Result = result;
            employeeId = int.Parse(eid); cardId = int.Parse(cid); type_id = int.Parse(tid);
            Type = type; EmployeeName = empl;
        }
        public int id;
        public string DateTime;
        public string Result;
        public int procId;
        public int employeeId;
        public int cardId;
        public string EmployeeName;
        public string Type;
        public int type_id;
    }
}
