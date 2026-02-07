using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using ServiceDesk_Connect.Models;
using ServiceDesk_Connect.Services;

namespace ServiceDesk_Connect
{
    public partial class Menu : Form
    {
        private readonly DatabaseService _db = new DatabaseService();
        private readonly TelegramService _tg = new TelegramService();
        private readonly string _currentUserId;

        public Menu(string userId)
        {
            InitializeComponent();
            _currentUserId = userId;
            this.Load += Menu_Load;
            this.FormClosed += (s, e) => Application.Exit();
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            cmbPriority.Items.Clear();
            cmbPriority.Items.AddRange(new string[] { "Низький", "Середній", "Високий", "Критичний" });
            cmbPriority.SelectedIndex = 1;

            await LoadMachines();
        }

        private async Task LoadMachines()
        {
            try
            {
                var machines = await _db.GetActiveMachinesAsync();
                cmbHardware.Items.Clear();

                if (machines.Count > 0)
                {
                    cmbHardware.Items.AddRange(machines.ToArray());
                    cmbHardware.SelectedIndex = 0;
                }
                else
                {
                    cmbHardware.Items.Add("Список порожній");
                    cmbHardware.SelectedIndex = 0;
                }
            }
            catch
            {
                cmbHardware.Items.Add("Помилка БД");
                cmbHardware.SelectedIndex = 0;
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string machine = cmbHardware.SelectedItem?.ToString() ?? "Не вказано";
            string priority = cmbPriority.SelectedItem?.ToString() ?? "Середній";
            string userName = txtUser.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string issue = txtIssue.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(issue))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля:\n- Ім'я\n- Телефон\n- Опис проблеми",
                                "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (machine == "Помилка БД" || machine == "Список порожній" || machine == "Не вказано")
            {
                MessageBox.Show("Неможливо відправити заявку: не обрано коректний верстат.\nПеревірте з'єднання з базою.",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phone.Length < 10)
            {
                MessageBox.Show("Введіть коректний номер телефону!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSend.Enabled = false;
            btnSend.Text = "Відправка...";
            Cursor = Cursors.WaitCursor;

            try
            {
                var ticket = new Ticket
                {
                    UserName = userName,
                    DeviceName = machine,
                    Priority = priority,
                    Description = issue + $"\n\n📞 {phone}",
                    CreatedAt = DateTime.Now
                };

                await _db.InsertTicketAsync(ticket);

                string emoji = GetPriorityEmoji(priority);

                string message = $"<b>🚨 Нова заявка</b>\n\n" +
                                 $"{emoji} <b>Пріоритет:</b> {priority}\n" +
                                 $"🖥 <b>Об'єкт:</b> {machine}\n" +
                                 $"👤 <b>Від:</b> {userName}\n" +
                                 $"📞 <b>Телефон:</b> {phone}\n\n" +
                                 $"📝 <b>Опис:</b> {issue}";

                long chatId = long.Parse(_currentUserId);
                await _tg.SendNotificationAsync(message, chatId);

                MessageBox.Show("Заявку успішно прийнято!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при відправці: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSend.Enabled = true;
                btnSend.Text = "Відправити заявку";
                Cursor = Cursors.Default;
            }
        }

        private void ResetForm()
        {
            if (cmbHardware.Items.Count > 0) cmbHardware.SelectedIndex = 0;
            cmbPriority.SelectedIndex = 1;
            txtIssue.Clear();
            txtUser.Clear();
            txtPhone.Clear();
        }

        private string GetPriorityEmoji(string priority)
        {
            return priority switch
            {
                "Критичний" => "🔴",
                "Високий" => "🟠",
                "Середній" => "🟡",
                "Низький" => "🟢",
                _ => "⚪️"
            };
        }
    }
}