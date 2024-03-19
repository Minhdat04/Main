namespace MovieTicketManagementWinApp
{
    partial class frmMyTicket
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
            dgvTicket = new DataGridView();
            Ticket = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            SuspendLayout();
            // 
            // dgvTicket
            // 
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Location = new Point(12, 46);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.RowHeadersWidth = 51;
            dgvTicket.RowTemplate.Height = 29;
            dgvTicket.Size = new Size(430, 166);
            dgvTicket.TabIndex = 0;
            // 
            // Ticket
            // 
            Ticket.AutoSize = true;
            Ticket.Location = new Point(12, 23);
            Ticket.Name = "Ticket";
            Ticket.Size = new Size(50, 20);
            Ticket.TabIndex = 1;
            Ticket.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(348, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 11);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmMyTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Ticket);
            Controls.Add(dgvTicket);
            Name = "frmMyTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMyTicket";
            ((System.ComponentModel.ISupportInitialize)dgvTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTicket;
        private Label Ticket;
        private Button button1;
        private Button button2;
    }
}