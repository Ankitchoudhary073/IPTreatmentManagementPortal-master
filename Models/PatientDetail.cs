﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace IPTreatmentManagementPortal.Models
{
    public class PatientDetail
    {
        [DisplayName("Patient Name")]
        [StringLength(30, ErrorMessage = "Only 30 characters allowed")]
        public string PatientName { get; set; }
      
        [DisplayName("Age")]
     
        public int Age { get; set; }

        [DisplayName("Ailment")]
        public string Ailment { get; set; }

        [DisplayName("Package Name")]
        public Package Package { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [DisplayName("Treatment Commencement Date")]
        public DateTime Date { get; set; }

        
    }
    public enum Package
    {
        Package1,
        Package2
    }
}
