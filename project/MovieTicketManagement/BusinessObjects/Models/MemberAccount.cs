using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class MemberAccount
    {
        public MemberAccount()
        {
            MovieTickets = new HashSet<MovieTicket>();
        }

        public int MemAccId { get; set; }
        public string MemUserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string MemName { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string Phone { get; set; } = null!;
        public bool Status { get; set; }

        public virtual ICollection<MovieTicket> MovieTickets { get; set; }
    }
}
