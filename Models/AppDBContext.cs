using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IPTreatmentManagementPortal.Models
{
    public class AppDBContext : DbContext 
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {



        }

        public DbSet<PatientRecords> PatientRecords { get; set; }
    }
}
