using BusinessObjects.Models;
using Repositories;
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
    public partial class frmManageSchedule : Form
    {
        MovieScheduleRepository movieScheduleRepo = new MovieScheduleRepository();
        EmployeeAccount a = new EmployeeAccount();
        public frmManageSchedule(EmployeeAccount employeeAccount)
        {
            InitializeComponent();
            a = employeeAccount;
            loadSchedule();
        }

        private void txtCa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string id = txtCa.Text;
            string slot = txtTime.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please input");
                return;
            }

            if (string.IsNullOrEmpty(slot))
            {
                MessageBox.Show("Please input time");
                return;
            }

            MovieSchedule movieSchedule = new MovieSchedule()
            {
                MovieScheId = id,
                TimeSlot = slot,
            };

            if (movieSchedule != null)
            {
                DialogResult d = MessageBox.Show("Do you want to create schedule", "Create schedule", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    movieScheduleRepo.Add(movieSchedule);
                    loadSchedule();
                    txtCa.Clear();
                    txtTime.Clear();
                }
            }
        }

        public void loadSchedule()
        {
            dgvSchedule.DataSource = movieScheduleRepo.GetAll().ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEmployeePage frmEmployeePage = new frmEmployeePage(a);
            frmEmployeePage.ShowDialog();
            this.Close();
        }
    }
}
