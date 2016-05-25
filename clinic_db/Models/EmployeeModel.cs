using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    class EmployeeModel
    {
        public EmployeeModel(string id,string name, string spec, string hs,string yoe)
        {
            this.Name = name; this.Specialty = spec; this.id = int.Parse(id);
            this.YearsOfExpirience = int.Parse(yoe); this.HourSalary = int.Parse(hs);
        }
        public int id;
        public string Name;
        public string Specialty;
        public int YearsOfExpirience;
        public int HourSalary;
    }
}
