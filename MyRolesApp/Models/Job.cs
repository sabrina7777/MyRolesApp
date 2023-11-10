using System.Diagnostics;

namespace MyRolesApp.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public bool IsActive { get; set; }
        public string JobTitle { get; set; }

        public string? JobDescription { get; set; }
        //added this after connectors so not sure what is affects after the fact
        //Ran add-migration jobdescription, update-database, it added under migration folder
        //will all changes to models add a new migration?
        private int? Tier { get; set; }

        public string? NextJob { get; set; }

        public Job()
        {
               //fill in later 
        }

    }
}
