using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    public class SessionModel
    {
        public SessionModel(string id, string dt, string cost, string pid, string eid,string cid,
            string proc,string emp)
        {
            this.id = int.Parse(id); DateTime = dt; Cost = int.Parse(cost);
            procId = int.Parse(pid); employeeId = int.Parse(eid); cardId = int.Parse(cid);
            ProcedureName = proc; EmployeeName = emp;
        }
        public int id;
        public string DateTime;
        public int Cost;
        public int procId;
        public int employeeId;
        public int cardId;
        public string ProcedureName;
        public string EmployeeName;
    }
}
