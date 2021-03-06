﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_db
{
    public class CardModel
    {
        public CardModel(string id, string name, string suffered, string cured, string d_id, string p_id,
            string docName, string tid,string type,string added)
        {
            this.Name = name; this.IsCured = bool.Parse(cured); this.id = int.Parse(id);
            this.YearsSuffered = int.Parse(suffered); 
            this.doctor_id = int.Parse(d_id); this.patient_id = int.Parse(p_id);
            this.Doctor = docName; type_id = int.Parse(tid); Type = type;
            this.Added = added;
        }
        public int id;
        public string Name;
        public bool IsCured;
        public int YearsSuffered;
        public int doctor_id;
        public int patient_id;
        public string Doctor;
        public int type_id;
        public string Type;
        public string Added;
    }
}
