using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using ServiceDesk_Connect.Services;

namespace ServiceDesk_Connect
{
    public partial class authorization : Form
    {
        private readonly DatabaseService _db = new DatabaseService();

        public authorization()
        {
            InitializeComponent();
            SetupEvents();
        }

        private void SetupEvents()
        {
            txtLogin.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtPassword.Focus(); };
            txtPassword.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btnLogin.PerformClick(); };
        }

        private void authorization_Load(object sender, EventArgs e)
        {
            if (!IsInternetAvailable())
            {
                MessageBox.Show("Відсутнє інтернет-з'єднання!\nРобота програми неможлива.", "Помилка мережі", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string savedId = Properties.Settings.Default.SavedTelegramId;
            if (!string.IsNullOrEmpty(savedId))
            {
                txtLogin.Text = savedId;
                chkRemember.Checked = true;
                this.ActiveControl = txtPassword;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string idText = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (!long.TryParse(idText, out long telegramId))
            {
                MessageBox.Show("Telegram ID має складатися тільки з цифр!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введіть пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Перевірка...";

            bool success = await _db.AuthenticateAsync(telegramId, pass);

            if (success)
            {
                if (chkRemember.Checked)
                {
                    Properties.Settings.Default.SavedTelegramId = idText;
                }
                else
                {
                    Properties.Settings.Default.SavedTelegramId = "";
                }
                Properties.Settings.Default.Save();

                Menu main = new Menu(idText);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірний Telegram ID або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLogin.Enabled = true;
                btnLogin.Text = "УВІЙТИ";
            }
        }

        private bool IsInternetAvailable()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send("8.8.8.8", 3000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}