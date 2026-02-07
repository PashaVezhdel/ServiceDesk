namespace ServiceDesk_Connect
{
    partial class Menu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.ComboBox cmbHardware;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Button btnSend;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblHardware = new System.Windows.Forms.Label();
            this.cmbHardware = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();

            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblUser);
            this.pnlMain.Controls.Add(this.txtUser);
            this.pnlMain.Controls.Add(this.lblHardware);
            this.pnlMain.Controls.Add(this.cmbHardware);
            this.pnlMain.Controls.Add(this.lblPriority);
            this.pnlMain.Controls.Add(this.cmbPriority);
            this.pnlMain.Controls.Add(this.lblIssue);
            this.pnlMain.Controls.Add(this.txtIssue);
            this.pnlMain.Controls.Add(this.btnSend);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(25);
            this.pnlMain.Size = new System.Drawing.Size(380, 500);
            this.pnlMain.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Створити заявку";

            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.ForeColor = System.Drawing.Color.Gray;
            this.lblUser.Location = new System.Drawing.Point(22, 70);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 15);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Ваше ім'я:";

            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUser.Location = new System.Drawing.Point(25, 90);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(330, 25);
            this.txtUser.TabIndex = 2;

            this.lblHardware.AutoSize = true;
            this.lblHardware.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHardware.ForeColor = System.Drawing.Color.Gray;
            this.lblHardware.Location = new System.Drawing.Point(22, 135);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(134, 15);
            this.lblHardware.TabIndex = 3;
            this.lblHardware.Text = "Обладнання (Верстат):";

            this.cmbHardware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHardware.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHardware.FormattingEnabled = true;
            this.cmbHardware.Location = new System.Drawing.Point(25, 155);
            this.cmbHardware.Name = "cmbHardware";
            this.cmbHardware.Size = new System.Drawing.Size(330, 25);
            this.cmbHardware.TabIndex = 4;

            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPriority.ForeColor = System.Drawing.Color.Gray;
            this.lblPriority.Location = new System.Drawing.Point(22, 200);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(81, 15);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.Text = "Терміновість:";

            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(25, 220);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(330, 25);
            this.cmbPriority.TabIndex = 6;

            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssue.ForeColor = System.Drawing.Color.Gray;
            this.lblIssue.Location = new System.Drawing.Point(22, 265);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(99, 15);
            this.lblIssue.TabIndex = 7;
            this.lblIssue.Text = "Опис проблеми:";

            this.txtIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIssue.Location = new System.Drawing.Point(25, 285);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIssue.Size = new System.Drawing.Size(330, 80);
            this.txtIssue.TabIndex = 8;

            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(25, 390);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(330, 40);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Відправити заявку";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 480);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceDesk Terminal";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}