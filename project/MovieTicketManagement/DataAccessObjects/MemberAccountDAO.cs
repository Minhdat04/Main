using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MemberAccountDAO
    {
        public static List<MemberAccount> getAllMember()
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MemberAccounts.ToList();
            }
        }

        public static int GetAgeById(int memberId)
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                MemberAccount member = context.MemberAccounts.FirstOrDefault(m => m.MemAccId == memberId);
                int age = 0;
                if (member != null)
                {

                    DateTime currentDate = DateTime.Now;
                    age = currentDate.Year - member.Birthday.Year;
                }
                return age;
            }
        }
    }
}
