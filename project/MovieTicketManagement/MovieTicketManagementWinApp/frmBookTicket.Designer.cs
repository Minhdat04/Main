namespace MovieTicketManagementWinApp
{
    partial class frmBookTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFind = new TextBox();
            label1 = new Label();
            btnFind = new Button();
            dgvPhim = new DataGridView();
            btnDatVe = new Button();
            btnCancel = new Button();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhim).BeginInit();
            SuspendLayout();
            // 
            // txtFind
            // 
            txtFind.Location = new Point(60, 28);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(251, 27);
            txtFind.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Phim";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(317, 28);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 2;
            btnFind.Text = "Tìm kiếm ";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // dgvPhim
            // 
            dgvPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhim.Location = new Point(12, 110);
            dgvPhim.Name = "dgvPhim";
            dgvPhim.RowHeadersWidth = 51;
            dgvPhim.RowTemplate.Height = 29;
            dgvPhim.Size = new Size(399, 184);
            dgvPhim.TabIndex = 3;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(417, 110);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(157, 29);
            btnDatVe.TabIndex = 4;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(417, 145);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(157, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(61, 61);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 7;
            label2.Text = "Ngày";
            // 
            // frmBookTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 336);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(btnCancel);
            Controls.Add(btnDatVe);
            Controls.Add(dgvPhim);
            Controls.Add(btnFind);
            Controls.Add(label1);
            Controls.Add(txtFind);
            Name = "frmBookTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookTicket";
            ((System.ComponentModel.ISupportInitialize)dgvPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFind;
        private Label label1;
        private Button btnFind;
        private DataGridView dgvPhim;
        private Button btnDatVe;
        private Button btnCancel;
        private DateTimePicker dtpDate;
        private Label label2;
    }
}