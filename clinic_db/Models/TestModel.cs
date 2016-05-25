using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    public class TestModel
    {
        public TestModel(string id, string name, string dtime, string result, string cid)
        {
            this.id = int.Parse(id); this.Name = name; DateTime = dtime; Result = result; 
            cardId = int.Parse(cid);
        }
        public int id;
        public string Name;
        public string DateTime;
        public string Result;
        public int cardId;
    }
}
