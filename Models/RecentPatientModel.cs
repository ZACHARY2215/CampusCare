using System;

namespace CampusCare.Models
{
    internal class RecentPatientModel
    {
        public int patient_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_registered { get; set; }
    }
}
