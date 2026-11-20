using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment02EFCore.Models
{
    public class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }
        public string Biography { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }



        public Organizer Organizer { get; set; }

      
        public int OrganizerId { get; set; } 

    }
}
