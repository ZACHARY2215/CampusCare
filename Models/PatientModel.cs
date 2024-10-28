using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusCare.Models
{
    internal class PatientModel
    {
        public int patient_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime birth_date { get; set; }
        public string gender { get; set; }
        public string student_or_staff { get; set; }
        public int id_number { get; set; }
        public string grade_or_department { get; set; }
        public long contact_number { get; set; }
        public DateTime date_registered { get; set; }

    }

}
