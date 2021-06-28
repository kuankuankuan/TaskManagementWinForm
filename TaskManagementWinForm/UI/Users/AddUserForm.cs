using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementLibrary.DataModel;
using TaskManagementWinForm.Clases;

namespace TaskManagementWinForm.UI
{
    public partial class RegisterForm : Telerik.WinControls.UI.RadForm
    {
        TaskModel taskModel;
        users user;
        public RegisterForm(TaskModel taskModel)
        {
            InitializeComponent();
            this.taskModel = taskModel;
            RoleComboBox.DataSource = taskModel.GetRoles();
        }

        /// <summary>
        /// Очищаем форму
        /// </summary>
        public void Clear()
        {
            FIOTextBox.Text = String.Empty;
            LoginTextBox.Text = String.Empty;
            PasswordTextBox.Text = String.Empty;
            RoleComboBox.SelectedIndex = -1 ;
        }

        /// <summary>
        /// Устанавливаем данные пользователя
        /// </summary>
        /// <param name="user"></param>
        public void SetData(users user)
        {
            if (user == null) return;
            this.user = user;
            FIOTextBox.Text = user.user_name;
            LoginTextBox.Text = user.login;
            PasswordTextBox.Text = String.Empty;
            RoleComboBox.SelectedValue = user.role_id;
            lockout_enabledCheckBox.Checked = user.lockout_enabled;
        }
        /// <summary>
        /// Добавить/Обновить пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(FIOTextBox.Text) || String.IsNullOrWhiteSpace(LoginTextBox.Text)) { UCMessageBox.Error("Заполните все поля."); return; }

                if (RegisterButton.Text != "Изменить" && taskModel.GetUserByLogin(LoginTextBox.Text.Trim()) != null) { UCMessageBox.Error("Пользователь с таким логином уже зарегистрирован."); return; }

                if(user == null) user = new users();
                user.user_name = UCStr.NormalizeFIO(FIOTextBox.Text);
                user.login = LoginTextBox.Text;
                if(PasswordPanel.Visible) user.password_hash = Crypto.ComputeHash(PasswordTextBox.Text, "SHA256", null);
                user.lockout_enabled = lockout_enabledCheckBox.Checked;
                user.role_id = RoleComboBox.SelectedIndex != -1 ? Int64.Parse(RoleComboBox.SelectedValue.ToString()) : 3;
                if (user.id == 0) taskModel.InsertUser(user);
                else taskModel.UpdateUser(user);
                //this.Hide();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }
        /// <summary>
        /// Скрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            //this.Hide();
        }
        /// <summary>
        /// Генерируем пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = UCStr.GenerateRandomPassword();
        }

        /// <summary>
        /// Обработка событии нажатие на клавишу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) CancelButton_Click(sender, e);
            else if (e.KeyCode == Keys.F2) RegisterButton_Click(sender, e);
        }
    }
}
