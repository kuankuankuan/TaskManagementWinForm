using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;
using TaskManagementWinForm.Clases;
using NLog;
using TaskManagementLibrary;
using TaskManagementLibrary.DataModel;

namespace TaskManagementWinForm.UI
{
    public partial class AutorizationForm : Telerik.WinControls.UI.RadForm
    {
        users user;
        TaskModel taskModel = new TaskModel();
        Logger logger;
        string[] users = { };
        string[] passwords = { };
        public AutorizationForm()
        {
            InitializeComponent();
            logger = LogManager.GetLogger("AutorizationForm");
            versionLabel.Text = "версия программы " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // Если пользователь сохранен, то считываем его имя
            string s = Properties.Settings.Default["user_name"].ToString();
            if (!String.IsNullOrWhiteSpace(s))
            {
                string[] buf = UCStr.StringUnLock(s).Split('\r');
                if (buf.Length == 2)
                {
                    users = buf[0].Split('\t');
                    passwords = buf[1].Split('\t');
                    foreach (var item in users)
                        userTextBox.Items.Add(item);
                    userTextBox.SelectedIndex = 0;
                    passwordTextBox.Text = passwords[0];
                    SaveCheckBox.Checked = true;
                }
            }
        }

        /// <summary>
        /// Кнопка Войти в систему по логину и паролю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Загрузка страниц
                NotAutorizedLabel.Visible = false;
                if (!SaveCheckBox.Checked && UCMessageBox.Question("Запомнить логин и пароль?") == DialogResult.Yes) SaveCheckBox.Checked = true;

                //radWaitingBar1.Visible = true;
                //radWaitingBar1.StartWaiting();
                if (AutorizedUser())
                {
                    for (int i = 1; i < 30; i++) { radWaitingBar1.Invalidate(); Application.DoEvents(); }
                    var mainForm = new MainForm(user);
                    mainForm.current_versionLabel.Text = $"Версия: {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
                    mainForm.Text = $"{user.user_name} ({user.login})";
                    for (int i = 1; i < 120; i++) { radWaitingBar1.Invalidate(); Application.DoEvents(); }
                    mainForm.Show();
                    this.Hide();
                }
                else
                    NotAutorizedLabel.Visible = true;
                StopWaiting();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(logger, ex, "Ошибка при прохождении авторизации");
                UCMessageBox.Error($"Ошибка при прохождении авторизации.{Environment.NewLine}Ошибка зафиксирована в log-файле");
            }
        }

        private void StopWaiting()
        {
            //radWaitingBar1.StopWaiting();
            //radWaitingBar1.Visible = false;
        }

        /// <summary>
        /// Проверка имени пользователя и пароля
        /// </summary>
        /// <returns></returns>
        private bool AutorizedUser()
        {
            try
            {
                user = taskModel.GetUserByLoginAsNoTracking(userTextBox.Text);
                ///if (user == null) { UCMessageBox.Error("Пользователь не найден..");  return false; }
                if (user != null && Crypto.VerifyHash(passwordTextBox.Text, "SHA256", user.password_hash) && !user.lockout_enabled)
                {
                    AppendUserToConfig(userTextBox.Text);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
            return false;
        }
        private void AppendUserToConfig(string text)
        {
            try
            {
                List<string> _users = new List<string>();
                List<string> _passwords = new List<string>();

                // Если убрать галочку, то все пользователи и пароли обнулятся
                if (SaveCheckBox.Checked)
                {
                    _users.Add(userTextBox.Text);
                    _passwords.Add(passwordTextBox.Text);

                    for (int i = 0; i < users.Length; i++)
                    {
                        if (users[i] != userTextBox.Text)
                        {
                            _users.Add(users[i]);
                            _passwords.Add(passwords[i]);
                        }
                    }
                }

                string res = "";
                foreach (var item in _users) res += item + "\t";
                if (res != "") res = res.Substring(0, res.Length - 1) + "\r";
                foreach (var item in _passwords) res += item + "\t";
                if (res != "") res = res.Substring(0, res.Length - 1);

                Properties.Settings.Default["user_name"] = UCStr.StringLock(res);
                Properties.Settings.Default.Save();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Если пользователь сохранен, то считываем его имя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            try
            {
               // userTextBox.Text = Properties.Settings.Default["user_name"].ToString();                
            } catch { }
        }

        /// <summary>
        /// Если введено имя пользователя, то фокус переводим на ввод пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutorizationForm_Activated(object sender, EventArgs e)
        {
            if (userTextBox.Text != "")
                passwordTextBox.Focus();
        }

        /// <summary>
        /// Переход на ввод пароля по Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                passwordTextBox.Focus();
        }

        /// <summary>
        /// Проверка пользователя и пароля по Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AutorizationButton_Click(sender, e);
        }

        /// <summary>
        /// Проверка - пользователь является администратором?
        /// </summary>
        /// <returns></returns>
        private bool isAdministrator()
        {

            return true;
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterForm registerForm = new RegisterForm(taskModel);
                registerForm.RegisterButton.Text = "Зарегистрироваться";
                registerForm.RolePanel.Visible = false;
                registerForm.RoleComboBox.SelectedValue = taskModel.GetRoleIdByName("user");

                if (registerForm.ShowDialog() == DialogResult.OK)
                {
                    userTextBox.Text = registerForm.LoginTextBox.Text;
                    passwordTextBox.Text = registerForm.PasswordTextBox.Text;
                    AutorizationButton_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                UCStr.SaveLog(ex, "Ошибка при инициализации формы регистрации");
                UCMessageBox.Error($"Ошибка при инициализации формы регистрации.{Environment.NewLine}Ошибка зафиксирована в log-файле");
            }
        }

        private void userTextBox_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(userTextBox.SelectedIndex != -1)
                passwordTextBox.Text = passwords[userTextBox.SelectedIndex];
        }
    }
}
