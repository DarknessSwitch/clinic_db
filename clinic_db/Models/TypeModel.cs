using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    class TypeModel
    {
        public TypeModel(string id, string name)
        {
            this.id = int.Parse(id); Name = name;
        }
        public TypeModel(string id, string name, string cost)
        {
            this.id = int.Parse(id); Name = name; Cost = int.Parse(cost);
        }
        public int id;
        public string Name;
        public int Cost;
    }
}
