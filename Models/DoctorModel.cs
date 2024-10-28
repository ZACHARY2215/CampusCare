using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusCare.Models
{
    internal class DoctorModel
    {
       
            public int doctor_id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string role { get; set; }
            public long contact_number { get; set; }
            public string status { get; set; }
    }
}
