using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyRolesApp.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int? Tier { get; set; }
        public bool IsActive { get; set; }

        // Navigation property for the Users table
        public ICollection<User> User { get; set; }
        //change back to Users?

        // Navigation property for the JobLinks table
        public ICollection<JobLink> NextJob { get; set; }
  
        public Job()
        {
               //fill in later 
        }

    }
}
