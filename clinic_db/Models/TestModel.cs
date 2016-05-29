using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    public class TestModel
    {
        public TestModel(string id, string dtime, string result, string cid,
            string tid,string type)
        {
            this.id = int.Parse(id); DateTime = dtime; Result = result;
            cardId = int.Parse(cid); type_id = int.Parse(tid); Type = type;
        }
        public int id;
        public string DateTime;
        public string Result;
        public int cardId;
        public int type_id;
        public string Type;
    }
}
