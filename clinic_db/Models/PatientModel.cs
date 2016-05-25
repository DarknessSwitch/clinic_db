using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    public class PatientModel
    {
        public PatientModel(string id, string name, string age, string phone, string addr, string sessions)
        {
            this.Name = name; this.PhoneNumber = phone; this.id = int.Parse(id);
            this.Age = int.Parse(age); this.Address = addr; this.SessionsTaken = int.Parse(sessions);
        }
        public int id;
        public string Name;
        public string PhoneNumber;
        public string Address;
        public int Age;
        public int SessionsTaken;
    }
}
