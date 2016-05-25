using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    class ProcedureModel
    {
        public ProcedureModel(string id, string name, string duration, string cost)
        {
            this.id = int.Parse(id); this.Name = name; this.Cost = int.Parse(cost);
            this.Duration = int.Parse(duration);
        }
        public int id;
        public string Name;
        public int Cost;
        public int Duration;
    }
}
