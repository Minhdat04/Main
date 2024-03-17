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
    public partial class frmMemberPage : Form
    {
        MemberAccount m = new MemberAccount();
        public frmMemberPage(MemberAccount memberAccount)
        {
            m = memberAccount;
            InitializeComponent();
            lbCusName.Text = m.MemName.ToString();

        }

        private void frmMemberPage_Load(object sender, EventArgs e)
        {

        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            frmBookTicket frmBookTicket = new frmBookTicket(m.MemAccId);
            frmBookTicket.Show();
        }

        private void lbVeCuaToi_DoubleClick(object sender, EventArgs e)
        {
            frmMyTicket frmMyTicket = new frmMyTicket();
            frmMyTicket.Show();
        }
    }
}
