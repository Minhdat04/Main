using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class EmployeeAccount
    {
        public int EmpAccId { get; set; }
        public string EmpUserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string EmpName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Role { get; set; } = null!;
        public bool Status { get; set; }
    }
}
