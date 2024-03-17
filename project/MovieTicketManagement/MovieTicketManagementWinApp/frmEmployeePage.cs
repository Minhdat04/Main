using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementWinApp
{
    public partial class frmEmployeePage : Form
    {
        EmployeeAccount a = new EmployeeAccount();
        public frmEmployeePage(EmployeeAccount employeeAccount)
        {
            InitializeComponent();
            a = employeeAccount;
        }

        private void frmEmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void btnManageMovie_Click(object sender, EventArgs e)
        {
            frmManageMovie frmManageMovie = new frmManageMovie(a);
            frmManageMovie.ShowDialog();
           
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmManageCategory frmManageCategory = new frmManageCategory(a);
            frmManageCategory.Show();
            
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            frmManageSchedule frmManageSchedule = new frmManageSchedule(a);
            frmManageSchedule.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmScheduleDetail frmScheduleDetail = new frmScheduleDetail();
            frmScheduleDetail.Show();
        }
    }
}
