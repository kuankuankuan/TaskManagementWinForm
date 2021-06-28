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

namespace TaskManagementWinForm.UI.Task
{
    public partial class AddTaskForm : Telerik.WinControls.UI.RadForm
    {
        MainForm mainform;
        tasks task;
        mtm_users_tasks _mtm_users_tasks;
        public AddTaskForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        public void LoadData(tasks task)
        {
            this.task = task;
            Clear();
            if (task != null)
            {
                SetData();
            }
            else
            {
                StatusDropDownList.SelectedIndex = 1;
                PriorityDropDownList.SelectedIndex = 1;
                ProjectsDropDownList.SelectedIndex = 0;
                this.Text = "Добавить задачу";
                AddProjectButton.Text = "Добавить";
            }
        }

        private void Clear()
        {
            _mtm_users_tasks = null;
            TaskNameTextBox.Text = "";
            StatusDropDownList.SelectedIndex = -1;
            ProjectsDropDownList.SelectedIndex = -1;
            PriorityDropDownList.SelectedIndex = -1;
            DedlineDateTime.Value = DateTime.MinValue;
            StartDateTime.Value = DateTime.MinValue;
        }

        private void SetData()
        {
            _mtm_users_tasks = mainform.taskModel.GetMtmUsersTaskByTaskId(task.id);
            TaskNameTextBox.Text = task.task_name;
            StatusDropDownList.SelectedValue = task.status_id;
            ProjectsDropDownList.SelectedValue = task.project_id;
            PriorityDropDownList.SelectedValue = task.priority_id;
            GroupsDropDownList.SelectedValue = task.projects?.group_id;
            UsersDropDownList.SelectedValue = _mtm_users_tasks?.user_id;
            DedlineDateTime.Value = task.dedline;
            StartDateTime.Value = task.start_date;
            this.Text = "Редактировать задачу";
            AddProjectButton.Text = "Изменить";

            if (mainform.CurrentUsers.role_id == (int)UserRoles.user)
            {
                TaskNameTextBox.ReadOnly = true;
                ProjectsDropDownList.ReadOnly = true;
                PriorityDropDownList.ReadOnly = true;
                GroupsDropDownList.ReadOnly = true;
                UsersDropDownList.ReadOnly = true;
                DedlineDateTime.ReadOnly = true;
                StartDateTime.ReadOnly = true;
            }
        }

        private void CancelRadButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(TaskNameTextBox.Text) || StatusDropDownList.SelectedValue == null || ProjectsDropDownList.SelectedValue == null || PriorityDropDownList.SelectedValue == null
                    || DedlineDateTime.Value == null || DedlineDateTime.Value == DateTime.MinValue || GroupsDropDownList.SelectedValue == null)
                    { UCMessageBox.Error("Необходимо заполнить все поля"); return; }
                if(StartDateTime.Value < DedlineDateTime.Value) { UCMessageBox.Error("Неверные значения для даты начала работы и крайний срок задачи"); return; }
                if (task == null) task = new tasks();
                task.task_name = TaskNameTextBox.Text;
                task.status_id = long.Parse(StatusDropDownList.SelectedValue.ToString());
                task.project_id = long.Parse(ProjectsDropDownList.SelectedValue.ToString());
                task.priority_id = long.Parse(PriorityDropDownList.SelectedValue.ToString());
                task.dedline = DedlineDateTime.Value;
                task.start_date = StartDateTime.Value;
                if (task.id == 0) mainform.taskModel.InsertTask(task);
                else mainform.taskModel.UpdateTask(task);

                if (_mtm_users_tasks?.user_id.ToString() != UsersDropDownList.SelectedValue.ToString())
                {
                    if (_mtm_users_tasks == null) _mtm_users_tasks = new mtm_users_tasks();
                    _mtm_users_tasks.user_id = long.Parse(UsersDropDownList.SelectedValue.ToString());
                    _mtm_users_tasks.task_id = task.id;
                    if(_mtm_users_tasks.id == 0) mainform.taskModel.InsertMtmUserGroup(_mtm_users_tasks);
                    else mainform.taskModel.UpdateMTMUsersTask(_mtm_users_tasks);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex, "Ошибка при сохранении данных на задачу");
            }
        }

        private void AddTaskForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) CancelRadButton_Click(sender, e);
            else if (e.KeyCode == Keys.F2) AddProjectButton_Click(sender, e);
        }

        private void GroupsDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (GroupsDropDownList.SelectedIndex != -1)
                {
                    ProjectsDropDownList.DataSource = mainform.taskModel.GetProjectsByGroupId(mainform.taskModel.GetGroupByName(GroupsDropDownList.Text).id);
                    //ProjectsDropDownList.ValueMember = "id";
                    //ProjectsDropDownList.DescriptionTextMember = "project_name";
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }
    }
}
