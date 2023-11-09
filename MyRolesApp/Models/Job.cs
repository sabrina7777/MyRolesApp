using System.Diagnostics;

namespace MyRolesApp.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public bool IsActive { get; set; }
        public string JobTitle { get; set; }
        private int? Tier { get; set; }

        public string? NextJob { get; set; }

        public Job()
        {
               //fill in later 
        }

    }
}
