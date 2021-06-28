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

namespace TaskManagementWinForm.UI.Group
{
    public partial class AddGroupForm : Telerik.WinControls.UI.RadForm
    {
        groups group;
        MainForm mainform;
        public AddGroupForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Считываем необходимые данные
        /// </summary>
        /// <param name="mainform">Экзеспляр главной формы</param>
        /// <param name="group">Группа для редактирования</param>
        public void LoadData(MainForm mainform, groups group)
        {
            Clear();
            this.mainform = mainform;
            this.group = group;
            GroupNameTextBox.Text = group?.group_name;
            if (!String.IsNullOrWhiteSpace(GroupNameTextBox.Text))
            {
                UploadUsersGridView();
                UploadProjectsGridView();
                EditUsersAndGroupsPanel.Enabled = true;
                AddGroupButton.Text = "Изменить";
            }
            else
                EditUsersAndGroupsPanel.Enabled = false;
        }

        /// <summary>
        /// Очистка данных формы
        /// </summary>
        private void Clear()
        {
            UsersDropDownList.DataSource = null;
            UsersInGroupGridView.DataSource = null;
            ProjectsInGroupGridView.DataSource = null;
            GroupNameTextBox.Text = String.Empty;
            ProjectNameTextBox.Text = String.Empty;
        }
        /// <summary>
        /// Обрабатываем события по кнопке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buttons_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(sender is Telerik.WinControls.UI.RadButton button)) return;

                if (UsersInGroupGridView.SelectedRows.Count > 0)
                {
                    switch (button.Name)
                    {
                        case "EditUserButton":
                            UsersInGroupGridView.ReadOnly = false;
                            if (UsersInGroupGridView.SelectedRows.Count > 0)
                                UsersInGroupGridView.SelectedRows[0].Cells[0].BeginEdit();
                            break;

                        case "DeleteUserButton":
                            if (UCMessageBox.Question($"Вы действительно хотите удалить пользователя \"{UsersInGroupGridView.SelectedRows[0].Cells["user_name"].Value}\" из группы?") == DialogResult.Yes)
                            {
                                mainform.taskModel.DeleteMtmUserGroup(mainform.taskModel.GetMtmUserGroup(GetSelectUserTableId()));
                                UploadUsersGridView();
                            }
                            break;
                    }
                }
                else
                    UCMessageBox.Error("Выберите гражданина");
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Получить идентификатор выделенной строки
        /// </summary>
        /// <returns></returns>
        private long GetSelectUserTableId()
        {
            try
            {
                return UsersInGroupGridView.SelectedRows[0].Cells["id"].Value != null ? Int64.Parse(UsersInGroupGridView.SelectedRows[0].Cells["id"].Value.ToString()) : -1;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
            return -1;
        }

        /// <summary>
        /// Получить идентификатор выделенной строки
        /// </summary>
        /// <returns></returns>
        private long GetSelectProjectTableId()
        {
            try
            {
                return ProjectsInGroupGridView.SelectedRows[0].Cells["id"].Value != null ? Int64.Parse(ProjectsInGroupGridView.SelectedRows[0].Cells["id"].Value.ToString()) : -1;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
            return -1;

        }
        /// <summary>
        /// Добавление пользователя в группу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(UsersDropDownList.SelectedValue == null ) { UCMessageBox.Error("Выберите пользователя"); return; }
                mtm_users_groups user_group = new mtm_users_groups
                {
                    group_id = group.id,
                    user_id = long.Parse(UsersDropDownList.SelectedValue.ToString())
                };
                mainform.taskModel.InsertMtmUserGroup(user_group);
                UploadUsersGridView();
                UCMessageBox.Info("Пользователь добавлен в группу");
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }
        /// <summary>
        /// Обновляем данные на пользователей
        /// </summary>
        public void UploadUsersGridView()
        {
            try
            {
                UsersInGroupGridView.DataSource = mainform.taskModel.GetMtmUsersGroupsViewAsNoTracking(group.id);
                var items = mainform.taskModel.GetNotMtmUsersGroups(group.id);
                List<users> list_users = new List<users>();
                foreach (var item in items)
                {
                    bool is_contains = false;
                    if (item.mtm_users_groups.Count > 0)
                        foreach (var mtm_user in item.mtm_users_groups)
                        {
                            if(mtm_user.group_id == group.id)
                            {
                                is_contains = true;
                                break;
                            }
                        }
                    if(!is_contains) list_users.Add(item);
                }
                UsersDropDownList.DataSource = list_users;
                UsersDropDownList.ValueMember = "id";
                UsersDropDownList.DisplayMember = "user_name";
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Перезагрузить таблицу по проектам
        /// </summary>
        public void UploadProjectsGridView()
        {
            try
            {
                ProjectsInGroupGridView.DataSource = mainform.taskModel.GetProjectsViewByGroup(group.id);
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Добавление группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainform.taskModel.GetGroupByName(GroupNameTextBox.Text) != null) { UCMessageBox.Error("Группа с таким названием уже существует. Выберите другое название"); return; }
                if (AddGroupButton.Text != "Изменить")
                {
                    if (String.IsNullOrWhiteSpace(GroupNameTextBox.Text)) { UCMessageBox.Error("Ввведите название группы"); return; }

                    groups groups = new groups
                    {
                        group_name = GroupNameTextBox.Text,
                        user_id = mainform.CurrentUsers.id
                    };
                    mainform.taskModel.InsertGroups(groups);
                    group = group ?? groups;
                    EditUsersAndGroupsPanel.Enabled = true;
                    GroupNameTextBox.Text = String.Empty;
                    UploadUsersGridView();
                    UCMessageBox.Info("Группа добавлена");
                }
                else if(group.group_name != GroupNameTextBox.Text && UCMessageBox.Question("Вы действительно хотите изменить наименование группы?") == DialogResult.Yes)
                {
                        group.group_name = GroupNameTextBox.Text;
                        mainform.taskModel.UpdateGroup(group);
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
                UCMessageBox.Error("Ошибка при добавлении группы...");
            }
        }
        /// <summary>
        /// Добавление нового проекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProjectsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(ProjectNameTextBox.Text)) { UCMessageBox.Error("Ввведите название проекта"); return; }
                if (mainform.taskModel.GetProjectByNameAsNoTracking(ProjectNameTextBox.Text) != null) { UCMessageBox.Error("Проект с таким названием уже существует. Выберите другое название"); return; }

                projects project = new projects
                {
                    project_name = ProjectNameTextBox.Text,
                    status_id = 1,
                    group_id = group.id,
                    project_admin = mainform.CurrentUsers.id
                };
                mainform.taskModel.InsertProject(project);

                //mtm_users_groups mtm_Users_Groups = new mtm_users_groups();
                //mtm_Users_Groups.group_id = groups.id;
                //mtm_Users_Groups.user_id
                EditUsersAndGroupsPanel.Enabled = true;
                UploadProjectsGridView();
                mainform.GroupsUpdateButton_Click(sender, e);
                mainform.ProjectsUpdateButton_Click(sender, e);
                ProjectNameTextBox.Text = String.Empty;
                UCMessageBox.Info("Проект добавлен");
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
                UCMessageBox.Error("Ошибка при добавлении проекта...");
            }
        }

        /// <summary>
        /// Удаление/Изменение группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteOrEditGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(sender is RadioButton button)) return;

                if (ProjectsInGroupGridView.SelectedRows.Count > 0)
                {
                    switch (button.Name)
                    {
                        case "EditGroupButton":
                            ProjectsInGroupGridView.ReadOnly = false;
                            if (ProjectsInGroupGridView.SelectedRows.Count > 0)
                                ProjectsInGroupGridView.SelectedRows[0].Cells[0].BeginEdit();
                            break;

                        case "DeleteGroupButton":
                            if (UCMessageBox.Question($"Вы действительно хотите удалить проект \"{ProjectsInGroupGridView.SelectedRows[0].Cells["user_name"].Value}\" из группы?") == DialogResult.Yes)
                                mainform.taskModel.DeleteProject(mainform.taskModel.GetProjectById(GetSelectProjectTableId()));
                            break;
                    }
                }
                else
                    UCMessageBox.Error("Выберите гражданина");
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
                UCMessageBox.Error($"Непредвиденная ошибка...{Environment.NewLine}О ней зафиксированы в log файле.");
            }
        }
    }
}
