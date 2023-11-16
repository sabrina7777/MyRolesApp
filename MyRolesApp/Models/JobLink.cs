using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyRolesApp.Models
{
    public class JobLink
    {
        [Key]
        public int JobLinkId { get; set; }

        // Foreign key for the Jobs table
        public int JobId { get; set; }
        public Job Job { get; set; }

        // Foreign key for the next job
        public int NextJobId { get; set; }
        public Job NextJob { get; set; }
    }
}
