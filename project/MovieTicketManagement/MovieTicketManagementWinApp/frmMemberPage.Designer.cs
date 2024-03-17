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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(985, 16);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 0;
            label2.Text = "K/H:";
            // 
            // lbCusName
            // 
            lbCusName.AutoSize = true;
            lbCusName.Location = new Point(1029, 16);
            lbCusName.Name = "lbCusName";
            lbCusName.Size = new Size(112, 20);
            lbCusName.TabIndex = 1;
            lbCusName.Text = "CustomerName";
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(790, 12);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 2;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // lbVeCuaToi
            // 
            lbVeCuaToi.AutoSize = true;
            lbVeCuaToi.Location = new Point(890, 16);
            lbVeCuaToi.Name = "lbVeCuaToi";
            lbVeCuaToi.Size = new Size(74, 20);
            lbVeCuaToi.TabIndex = 3;
            lbVeCuaToi.Text = "Vé của tôi";
            lbVeCuaToi.DoubleClick += lbVeCuaToi_DoubleClick;
            // 
            // btnTimKiemPhim
            // 
            btnTimKiemPhim.Location = new Point(546, 12);
            btnTimKiemPhim.Name = "btnTimKiemPhim";
            btnTimKiemPhim.Size = new Size(94, 29);
            btnTimKiemPhim.TabIndex = 4;
            btnTimKiemPhim.Text = "Tìm kiếm";
            btnTimKiemPhim.UseVisualStyleBackColor = true;
            // 
            // grbPhim
            // 
            grbPhim.Location = new Point(26, 80);
            grbPhim.Name = "grbPhim";
            grbPhim.Size = new Size(1115, 352);
            grbPhim.TabIndex = 6;
            grbPhim.TabStop = false;
            grbPhim.Text = "Phim";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 27);
            textBox1.TabIndex = 7;
            // 
            // frmMemberPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 462);
            Controls.Add(textBox1);
            Controls.Add(grbPhim);
            Controls.Add(btnTimKiemPhim);
            Controls.Add(lbVeCuaToi);
            Controls.Add(btnDatVe);
            Controls.Add(lbCusName);
            Controls.Add(label2);
            Name = "frmMemberPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberPage";
            Load += frmMemberPage_Load;
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
        private TextBox textBox1;
    }
}