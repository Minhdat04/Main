using BusinessObjects.Models;
using Microsoft.Extensions.Configuration;
using Repositories;
using System.Runtime.InteropServices;

namespace MovieTicketManagementWinApp

{
    public partial class Form1 : Form
    {
        MemberAccountRepository memRepo = new MemberAccountRepository();
        EmployeeAccountRepository empRepo = new EmployeeAccountRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var member = memRepo.GetAll().FirstOrDefault(x => x.MemUserName == username && x.Password == password);
            var employee = empRepo.GetAll().FirstOrDefault(x => x.EmpUserName == username && x.Password == password);
            if (member != null)
            {
                if(member.Status == true)
                {
                    frmMemberPage frmMemberPage = new frmMemberPage(member);
                    frmMemberPage.Show();
                }
                else
                {
                    MessageBox.Show("You can not enter.");
                    return;
                }
            }
            else if (employee != null)
            {
               if(employee.Status == true)
                {
                    frmEmployeePage frmEmployeePage = new frmEmployeePage(employee);
                    frmEmployeePage.Show();
                }
                else
                {
                    MessageBox.Show("You can not enter.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please login again");
                return;
            }
        }
    }
}
