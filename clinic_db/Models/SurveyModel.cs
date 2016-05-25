using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    class SurveyModel
    {
        public SurveyModel(string id, string name, string dt, string result, string cid, string eid)
        {
            this.id = int.Parse(id); Name = name;  DateTime = dt; Result = result;
            employeeId = int.Parse(eid); cardId = int.Parse(cid);
        }
        public int id;
        public string Name;
        public string DateTime;
        public string Result;
        public int procId;
        public int employeeId;
        public int cardId;
        public string EmployeeName;
    }
}
