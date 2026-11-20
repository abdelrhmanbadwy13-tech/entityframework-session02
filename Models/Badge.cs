using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02EFCore.Models
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public string BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public string Tier { get; set; }

        public Attendee Attendee { get; set; }
        public int AttendeeId { get; set; }
    }
}
