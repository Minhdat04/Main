using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class MovieTicket
    {
        public int TicketId { get; set; }
        public int? MovSdid { get; set; }
        public int? MemAccId { get; set; }
        public DateTime TicketDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalTicketPrice { get; set; }
        public string SitDetail { get; set; } = null!;

        public virtual MemberAccount? MemAcc { get; set; }
        public virtual MoviewScheduleDetail? MovSd { get; set; }
    }
}
