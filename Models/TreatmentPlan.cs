using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IPTreatmentManagementPortal.Models
{
    public class TreatmentPlan
    {
        public string PackageName { get; set; }
        public string TestDetails { get; set; }
        public double Cost { get; set; }
        
        public string Specialist { get; set; }
        public DateTime CommencementDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
