using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementWinApp
{
    public partial class frmBookTicketDetail : Form
    {
        MoviewScheduleDetailRepository msdRepo = new MoviewScheduleDetailRepository();
        MemberAccountRepository memRepo = new MemberAccountRepository();
        MovieTicketRepository movieTickerRepo = new MovieTicketRepository();

        int checkedFirst = 0;
        string datveFirst = "";
        int movSdid;
        int memAccid;
        DateTime ticketDate;
        public frmBookTicketDetail(int MovSdid, int MemAccId, DateTime TicketDate)
        {
            InitializeComponent();
            movSdid = MovSdid;
            memAccid = MemAccId;
            ticketDate = TicketDate;
            MoviewScheduleDetail m = msdRepo.getAll().FirstOrDefault(x => x.MovSdid == MovSdid);
            txtID.Text = movieTickerRepo.countID().ToString();
            txtMemID.Text = memRepo.GetAll().FirstOrDefault(x => x.MemAccId == MemAccId).MemName.ToString();
            txtPhim.Text = m.Movie.MovieName.ToString();
            txtDate.Text = m.Date.Date.ToString();
            txtCa.Text = m.MovieSche.TimeSlot.ToString();
            splitString(m.EmptySlot.ToString());

            List<CheckBox> checkBoxList = new List<CheckBox>();
            checkBoxList.Add(cb1);
            checkBoxList.Add(cb2);
            checkBoxList.Add(cb3);
            checkBoxList.Add(cb4);
            checkBoxList.Add(cb5);
            checkBoxList.Add(cb6);
            checkBoxList.Add(cb7);
            checkBoxList.Add(cb8);
            checkBoxList.Add(cb9);
            checkBoxList.Add(cb10);
            checkBoxList.Add(cb11);
            checkBoxList.Add(cb12);
            checkBoxList.Add(cb13);
            checkBoxList.Add(cb14);
            checkBoxList.Add(cb15);
            checkBoxList.Add(cb16);
            checkBoxList.Add(cb17);
            checkBoxList.Add(cb18);
            checkBoxList.Add(cb19);
            checkBoxList.Add(cb20);
            checkBoxList.Add(cb21);
            checkBoxList.Add(cb22);
            checkBoxList.Add(cb23);
            checkBoxList.Add(cb24);
            checkBoxList.Add(cb25);

            foreach (CheckBox checkBox in checkBoxList)
            {
                if (checkBox.Checked)
                {
                    // Kiểm tra nếu chuỗi datve đã có phần tử, nếu có thêm dấu phẩy
                    if (datveFirst != "")
                        datveFirst += ",";

                    // Thêm số ghế vào chuỗi
                    datveFirst += checkBox.Text;
                    checkedFirst++;
                }
            }

        }

        private void frmBookTicketDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            List<CheckBox> checkBoxList = new List<CheckBox>();
            checkBoxList.Add(cb1);
            checkBoxList.Add(cb2);
            checkBoxList.Add(cb3);
            checkBoxList.Add(cb4);
            checkBoxList.Add(cb5);
            checkBoxList.Add(cb6);
            checkBoxList.Add(cb7);
            checkBoxList.Add(cb8);
            checkBoxList.Add(cb9);
            checkBoxList.Add(cb10);
            checkBoxList.Add(cb11);
            checkBoxList.Add(cb12);
            checkBoxList.Add(cb13);
            checkBoxList.Add(cb14);
            checkBoxList.Add(cb15);
            checkBoxList.Add(cb16);
            checkBoxList.Add(cb17);
            checkBoxList.Add(cb18);
            checkBoxList.Add(cb19);
            checkBoxList.Add(cb20);
            checkBoxList.Add(cb21);
            checkBoxList.Add(cb22);
            checkBoxList.Add(cb23);
            checkBoxList.Add(cb24);
            checkBoxList.Add(cb25);

            int checkedCount = 0;
            string datve = "";
            string EmptySlot = "";
            foreach (CheckBox checkBox in checkBoxList)
            {
                // Kiểm tra trạng thái của checkbox và thêm vào chuỗi kết quả tương ứng
                EmptySlot += checkBox.Checked ? "1" : "0";

                // Thêm dấu "-" nếu chưa phải là checkbox cuối cùng trong danh sách
                if (checkBox != checkBoxList.Last())
                    EmptySlot += "-";

                if (checkBox.Checked)
                {
                    // Kiểm tra nếu chuỗi datve đã có phần tử, nếu có thêm dấu phẩy
                    if (datve != "")
                        datve += ",";

                    // Thêm số ghế vào chuỗi
                    datve += checkBox.Text;
                    checkedCount++;
                }
            }

            string[] firstArray = datveFirst.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = datve.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Tìm các phần tử chỉ xuất hiện trong chuỗi thứ hai mà không có trong chuỗi thứ nhất
            var difference = secondArray.Except(firstArray);

            // Gộp các phần tử lại thành chuỗi
            string result = string.Join(", ", difference);

            checkedCount = checkedCount - checkedFirst;
            txtSoGhe.Text = result.ToString();
            txtSoVe.Text = checkedCount.ToString();

            int giatien = checkedCount * 50;
            txtSoTien.Text = giatien.ToString() + " K";

            int TicketId = int.Parse(txtID.Text);
            int? MovSdid = movSdid;
            int? MemAccId = memAccid;
            DateTime TicketDate = ticketDate;
            int Quantity = int.Parse(txtSoVe.Text);
            decimal TotalTicketPrice = decimal.Parse(giatien.ToString());
            string SitDetail = result;
            //luu ticket
            MovieTicket ticket = new MovieTicket()
            {
                TicketId = TicketId,
                MovSdid = MovSdid,
                MemAccId = MemAccId,
                TicketDate = TicketDate,
                Quantity = Quantity,
                TotalTicketPrice = TotalTicketPrice,
                SitDetail = SitDetail
            };

            if(ticket != null)
            {
                DialogResult d = MessageBox.Show("Bạn có muốn đặt vé ko?", "Đặt vé", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    msdRepo.updateEmptySlot(movSdid, EmptySlot);
                    movieTickerRepo.addTicket(ticket);
                    splitString(EmptySlot);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn vé");
                return;
            }
        }

        public void splitString(string s)
        {
            List<CheckBox> checkBoxList = new List<CheckBox>();
            checkBoxList.Add(cb1);
            checkBoxList.Add(cb2);
            checkBoxList.Add(cb3);
            checkBoxList.Add(cb4);
            checkBoxList.Add(cb5);
            checkBoxList.Add(cb6);
            checkBoxList.Add(cb7);
            checkBoxList.Add(cb8);
            checkBoxList.Add(cb9);
            checkBoxList.Add(cb10);
            checkBoxList.Add(cb11);
            checkBoxList.Add(cb12);
            checkBoxList.Add(cb13);
            checkBoxList.Add(cb14);
            checkBoxList.Add(cb15);
            checkBoxList.Add(cb16);
            checkBoxList.Add(cb17);
            checkBoxList.Add(cb18);
            checkBoxList.Add(cb19);
            checkBoxList.Add(cb20);
            checkBoxList.Add(cb21);
            checkBoxList.Add(cb22);
            checkBoxList.Add(cb23);
            checkBoxList.Add(cb24);
            checkBoxList.Add(cb25);

            string[] parts = s.Split('-');

            for (int i = 0; i < checkBoxList.Count && i < parts.Length; i++)
            {
                if (parts[i].Trim() == "1")
                {
                    checkBoxList[i].Checked = true;
                    checkBoxList[i].Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
