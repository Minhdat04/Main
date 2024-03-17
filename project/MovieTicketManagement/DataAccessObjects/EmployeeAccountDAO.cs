using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class EmployeeAccountDAO
    {
        public static List<EmployeeAccount> getAllEmpolyee()
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.EmployeeAccounts.ToList();
            }
        }
    }
}
