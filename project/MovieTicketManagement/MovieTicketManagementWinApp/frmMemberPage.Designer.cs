namespace MovieTicketManagementWinApp
{
    partial class frmMemberPage
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
            label2 = new Label();
            lbCusName = new Label();
            btnDatVe = new Button();
            lbVeCuaToi = new Label();
            btnTimKiemPhim = new Button();
            grbPhim = new GroupBox();
            moviePic4 = new PictureBox();
            moviePic3 = new PictureBox();
            moviePic2 = new PictureBox();
            moviePic1 = new PictureBox();
            searchBox = new TextBox();
            grbPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moviePic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviePic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviePic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviePic1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(813, 13);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "K/H:";
            // 
            // lbCusName
            // 
            lbCusName.AutoSize = true;
            lbCusName.Location = new Point(851, 13);
            lbCusName.Name = "lbCusName";
            lbCusName.Size = new Size(91, 15);
            lbCusName.TabIndex = 1;
            lbCusName.Text = "CustomerName";
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(642, 10);
            btnDatVe.Margin = new Padding(3, 2, 3, 2);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(82, 22);
            btnDatVe.TabIndex = 2;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // lbVeCuaToi
            // 
            lbVeCuaToi.AutoSize = true;
            lbVeCuaToi.Location = new Point(730, 13);
            lbVeCuaToi.Name = "lbVeCuaToi";
            lbVeCuaToi.Size = new Size(58, 15);
            lbVeCuaToi.TabIndex = 3;
            lbVeCuaToi.Text = "Vé của tôi";
            lbVeCuaToi.DoubleClick += lbVeCuaToi_DoubleClick;
            // 
            // btnTimKiemPhim
            // 
            btnTimKiemPhim.Location = new Point(478, 9);
            btnTimKiemPhim.Margin = new Padding(3, 2, 3, 2);
            btnTimKiemPhim.Name = "btnTimKiemPhim";
            btnTimKiemPhim.Size = new Size(82, 22);
            btnTimKiemPhim.TabIndex = 4;
            btnTimKiemPhim.Text = "Tìm kiếm";
            btnTimKiemPhim.UseVisualStyleBackColor = true;
            btnTimKiemPhim.Click += btnTimKiemPhim_Click;
            // 
            // grbPhim
            // 
            grbPhim.Controls.Add(moviePic4);
            grbPhim.Controls.Add(moviePic3);
            grbPhim.Controls.Add(moviePic2);
            grbPhim.Controls.Add(moviePic1);
            grbPhim.Location = new Point(23, 60);
            grbPhim.Margin = new Padding(3, 2, 3, 2);
            grbPhim.Name = "grbPhim";
            grbPhim.Padding = new Padding(3, 2, 3, 2);
            grbPhim.Size = new Size(976, 264);
            grbPhim.TabIndex = 6;
            grbPhim.TabStop = false;
            grbPhim.Text = "Phim";
            // 
            // moviePic4
            // 
            moviePic4.Location = new Point(699, 21);
            moviePic4.Name = "moviePic4";
            moviePic4.Size = new Size(220, 224);
            moviePic4.TabIndex = 3;
            moviePic4.TabStop = false;
            // 
            // moviePic3
            // 
            moviePic3.Location = new Point(473, 21);
            moviePic3.Name = "moviePic3";
            moviePic3.Size = new Size(220, 224);
            moviePic3.TabIndex = 2;
            moviePic3.TabStop = false;
            // 
            // moviePic2
            // 
            moviePic2.Location = new Point(247, 21);
            moviePic2.Name = "moviePic2";
            moviePic2.Size = new Size(220, 224);
            moviePic2.TabIndex = 1;
            moviePic2.TabStop = false;
            // 
            // moviePic1
            // 
            moviePic1.Location = new Point(20, 21);
            moviePic1.Name = "moviePic1";
            moviePic1.Size = new Size(220, 224);
            moviePic1.TabIndex = 0;
            moviePic1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(182, 9);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(291, 23);
            searchBox.TabIndex = 7;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // frmMemberPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 346);
            Controls.Add(searchBox);
            Controls.Add(grbPhim);
            Controls.Add(btnTimKiemPhim);
            Controls.Add(lbVeCuaToi);
            Controls.Add(btnDatVe);
            Controls.Add(lbCusName);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMemberPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberPage";
            Load += frmMemberPage_Load;
            grbPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)moviePic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviePic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviePic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviePic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbCusName;
        private Button btnDatVe;
        private Label lbVeCuaToi;
        private Button btnTimKiemPhim;
        private GroupBox grbPhim;
        private TextBox searchBox;
        private PictureBox moviePic4;
        private PictureBox moviePic3;
        private PictureBox moviePic2;
        private PictureBox moviePic1;
    }
}