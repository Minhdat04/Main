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
        public static MemberAccount GetMemberByID(int memberID)
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MemberAccounts.FirstOrDefault(c => c.MemAccId == memberID);
            }
        }
        public static void CreateMember(MemberAccount member)
        {
            try
            {
                MemberAccount mem1 = GetMemberByID(member.MemAccId);
                if (mem1 == null)
                {
                    using var context = new MovieTicketManagementContext();
                    context.MemberAccounts.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
