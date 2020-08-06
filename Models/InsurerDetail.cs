
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IPTreatmentManagementPortal.Models
{
    public class InsurerDetail
    {
        [Key]
        public string InsurerName { get; set; }
       
        public string InsurerPackageName { get; set; }
        public int InsuranceAmountLimit { get; set; }
        public string DisbursementDuration { get; set; }

       
    }
}
