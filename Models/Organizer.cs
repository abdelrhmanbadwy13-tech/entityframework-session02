using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment02EFCore.Models
{
    [Table("EventOrganizers")]
   public class Organizer
    {
        public int OrganizerId { get; set; } // PK

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }

        //-------------
        // 1-1
        public OrganizerProfile? OrganizerProfile { get; set; }

        //---------------------------------
        //1-M
        public ICollection<Event> Events { get; set; } = new HashSet<Event>();

    }
}
