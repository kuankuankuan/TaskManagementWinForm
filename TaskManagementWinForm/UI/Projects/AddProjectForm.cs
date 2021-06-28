using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagementLibrary.DataModel;
using TaskManagementWinForm.Clases;
using Telerik.WinControls;

namespace TaskManagementWinForm.UI.Projects
{
    public partial class AddProjectForm : Telerik.WinControls.UI.RadForm
    {
        MainForm mainform;
        projects projects;
        public AddProjectForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        public void LoadData(projects projects)
        {
            Clear();
            this.projects = projects;
            if (projects != null) SetData();
        }
        /// <summary>
        /// Очистка формы
        /// </summary>
        private void Clear()
        {
            ProjectNameTextBox.Text = String.Empty;
            StatusDropDownList.SelectedIndex = -1;
            GroupsDropDownList.SelectedIndex = -1;
        }
        /// <summary>
        /// Устанавливаем данные
        /// </summary>
        private void SetData()
        {
            ProjectNameTextBox.Text = projects.project_name;
            StatusDropDownList.SelectedValue = projects.status_id;
            GroupsDropDownList.SelectedValue = projects.group_id;
            UsersDropDownList.SelectedValue = projects.project_admin;
        }
        /// <summary>
        /// Добавляем или изменяем данные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(ProjectNameTextBox.Text) || StatusDropDownList.SelectedValue == null || GroupsDropDownList.SelectedValue == null || UsersDropDownList.SelectedValue == null) { UCMessageBox.Error("Заполните все поля."); return; }
                if (projects == null) projects = new projects();
                projects.project_name = ProjectNameTextBox.Text;
                projects.status_id = long.Parse(StatusDropDownList.SelectedValue.ToString());
                projects.group_id = long.Parse(GroupsDropDownList.SelectedValue.ToString());
                projects.project_admin = long.Parse(UsersDropDownList.SelectedValue.ToString());
                if (projects.id == 0) mainform.taskModel.InsertProject(projects);
                else mainform.taskModel.UpdateProject(projects);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
                UCMessageBox.Error($"Ошибка при сохранении данных.{Environment.NewLine}О ней зафиксированы в log файле.");
            }
        }

        /// <summary>
        /// Скрываем форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            DialogResult = DialogResult.Cancel;
        }

        private void AddProjectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) CancelButton_Click(sender, e);
            else if (e.KeyCode == Keys.F2) AddProjectButton_Click(sender, e);
        }
    }
}
