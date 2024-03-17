namespace MovieTicketManagementWinApp
{
    partial class frmManageSchedule
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
            dgvSchedule = new DataGridView();
            label1 = new Label();
            btnCreate = new Button();
            txtCa = new TextBox();
            txtTime = new TextBox();
            label2 = new Label();
            Ca = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(282, 61);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(301, 188);
            dgvSchedule.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 1;
            label1.Text = "New schedule";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(60, 147);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtCa
            // 
            txtCa.Location = new Point(60, 61);
            txtCa.Name = "txtCa";
            txtCa.Size = new Size(184, 27);
            txtCa.TabIndex = 3;
            txtCa.TextChanged += txtCa_TextChanged;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(60, 100);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(184, 27);
            txtTime.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 107);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 5;
            label2.Text = "Giờ";
            // 
            // Ca
            // 
            Ca.AutoSize = true;
            Ca.Location = new Point(22, 68);
            Ca.Name = "Ca";
            Ca.Size = new Size(26, 20);
            Ca.TabIndex = 6;
            Ca.Text = "Ca";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(129, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmManageSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(btnBack);
            Controls.Add(Ca);
            Controls.Add(label2);
            Controls.Add(txtTime);
            Controls.Add(txtCa);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(dgvSchedule);
            Name = "frmManageSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManageSchedule";
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSchedule;
        private Label label1;
        private Button btnCreate;
        private TextBox txtCa;
        private TextBox txtTime;
        private Label label2;
        private Label Ca;
        private Button btnBack;
    }
}