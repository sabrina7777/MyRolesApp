using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyRolesApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    // Define the Users table entity
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }

        // Foreign key for the Job table
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
