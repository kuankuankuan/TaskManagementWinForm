using System.Windows;
using System.Windows.Forms;

namespace TaskManagementWinForm.Clases
{
    public static class UCMessageBox
    {
        public static void Error(string message, string error_text = "Приложения для управления задачами группы")
        {
            MessageBox.Show(message, error_text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Info(string message, string info_text = "Приложения для управления задачами группы")
        {
            MessageBox.Show(message, info_text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Warning(string message, string attention_text = "Приложения для управления задачами группы")
        {
            MessageBox.Show(message, attention_text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ChooseWarning(string message, string attention_text = "Приложения для управления задачами группы")
        {
            return MessageBox.Show(message, attention_text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static DialogResult Question(string message, string attention_text = "Приложения для управления задачами группы")
        {
            return MessageBox.Show(message, attention_text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
