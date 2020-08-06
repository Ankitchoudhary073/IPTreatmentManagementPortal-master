using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IPTreatmentManagementPortal.Models
{
    public class PatientRecords
    {
        [Key]
        public int PatientId { get; set; }
        [DisplayName("Patient Name")]
        public string PatientName { get; set; }

        [DisplayName("Age")]
        public int Age { get; set; }
        [DisplayName("Ailment")]
        public string Ailment { get; set; }
        [DisplayName("Package Name")]
        public Package Package { get; set; }

        public double Cost { get; set; }
        public string Specialist { get; set; }
        public string InsurerName { get; set; }
        public double Balance { get; set; }

    }
}
