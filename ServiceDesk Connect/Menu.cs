using System;
using System.Windows.Forms;

namespace ServiceDesk_Connect
{
    public partial class Menu : Form
    {
        // Конструктор
        public Menu(string userId)
        {
            InitializeComponent();

            // Щоб випадаючі списки не були пустими при запуску (для краси)
            cmbPriority.Items.AddRange(new string[] { "Низький", "Середній", "Високий", "Критичний" });
            cmbPriority.SelectedIndex = 1;

            cmbHardware.Items.Add("Тестовий Верстат 1");
            cmbHardware.SelectedIndex = 0;
        }

        // Подія натискання кнопки (пуста заглушка)
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Тут потім допишемо логіку відправки
            MessageBox.Show("Кнопка працює! Тут буде відправка.", "Тест");
        }
    }
}