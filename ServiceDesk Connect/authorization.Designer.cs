namespace ServiceDesk_Connect
{
    partial class authorization
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorization));
            pnlMain = new Panel();
            lblTitle = new Label();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            btnLogin = new Button();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(lblLogin);
            pnlMain.Controls.Add(txtLogin);
            pnlMain.Controls.Add(lblPassword);
            pnlMain.Controls.Add(txtPassword);
            pnlMain.Controls.Add(chkRemember);
            pnlMain.Controls.Add(btnLogin);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(500, 667);
            pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(60, 50);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Вхід у систему";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 10F);
            lblLogin.ForeColor = Color.Gray;
            lblLogin.Location = new Point(64, 150);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(115, 28);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Telegram ID";
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 11F);
            txtLogin.Location = new Point(64, 192);
            txtLogin.Margin = new Padding(4, 5, 4, 5);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Введіть ID (дізнатись: @userinfobot)";
            txtLogin.Size = new Size(371, 37);
            txtLogin.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(64, 267);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(64, 308);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(371, 37);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.FlatStyle = FlatStyle.Flat;
            chkRemember.Font = new Font("Segoe UI", 10F);
            chkRemember.ForeColor = Color.FromArgb(60, 60, 60);
            chkRemember.Location = new Point(64, 383);
            chkRemember.Margin = new Padding(4, 5, 4, 5);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(194, 32);
            chkRemember.TabIndex = 5;
            chkRemember.Text = "Запам'ятати мене";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 190);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(64, 467);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(371, 75);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Увійти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // authorization
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 667);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизація";
            Load += authorization_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }
    }
}