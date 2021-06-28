using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLog;
using TaskManagementLibrary.DataModel;
using TaskManagementWinForm.Clases;
using TaskManagementWinForm.UI.Group;
using TaskManagementWinForm.UI.Task;
using TaskManagementWinForm.UI.Projects;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.Data;

namespace TaskManagementWinForm.UI
{
    public partial class MainForm : Telerik.WinControls.UI.RadRibbonForm
    {
        Logger logger;
        public users CurrentUsers { get; set; }
        public List<Panel> pages = new List<Panel>(); // Список страниц
        public TaskModel taskModel = new TaskModel();
        public AddGroupForm addGroupFrom = new AddGroupForm();
        public AddTaskForm addTaskForm;
        public AddProjectForm addProjectForm;
        public RegisterForm registerForm;
        public List<String> StatusNames = new List<String>();
        public List<Color> RowColors = new List<Color>(); // Цвета фона различных статусов

        public MainForm(users user)
        {
            InitializeComponent();
            CurrentUsers = user;
            RadGridLocalizationProvider.CurrentProvider = new RussianRadGridLocalizationProvider();
            logger = LogManager.GetLogger("MainForm");
            registerForm = new RegisterForm(taskModel);
            addProjectForm = new AddProjectForm(this);
            addTaskForm = new AddTaskForm(this);
            BodyPanel.Controls.Clear();
            AppendPage(tabPage1); AppendPage(tabPage3); AppendPage(tabPage2); AppendPage(tabPage4);
            Invalidate();
            SetDictionary();
            ShowPage(1);
        }

        private void SetDictionary()
        {
            // загружаем справочные значения
            var groupsitem = taskModel.GetGroupsAsNoTracking();
            var usersitem = taskModel.GetUsersNotLockedAsNoTracking();
            var rolesitem = taskModel.GetRoles();
            var statusitem = taskModel.GetStatus();
            var priorityitem = taskModel.GetPriorities();
            var projectitem = taskModel.GetProjectsAsNoTracking();

            foreach (var item in statusitem)
            {
                if (!String.IsNullOrWhiteSpace(item.color) && item.color.Split(',').Length == 3)
                {
                    StatusNames.Add(item.id.ToString());
                    RowColors.Add(Color.FromArgb(Int32.Parse(item.color.Split(',')[0]), Int32.Parse(item.color.Split(',')[1]), Int32.Parse(item.color.Split(',')[2])));
                }
            }

            // Загружаем таблицы
            TasksUpdateButton_Click(null, null);

            ProjectsGridView.DataSource = projectitem;
            GroupsGridView.DataSource = groupsitem;
            UsersGridView.DataSource = usersitem;

            addTaskForm.GroupsDropDownList.DataSource = groupsitem;
            addTaskForm.GroupsDropDownList.ValueMember = "id";
            addTaskForm.GroupsDropDownList.DescriptionTextMember = "group_name";

            addTaskForm.StatusDropDownList.DataSource = statusitem;
            addTaskForm.StatusDropDownList.ValueMember = "id";
            addTaskForm.StatusDropDownList.DescriptionTextMember = "name";

            addTaskForm.UsersDropDownList.DataSource = usersitem;
            addTaskForm.UsersDropDownList.ValueMember = "id";
            addTaskForm.UsersDropDownList.DescriptionTextMember = "user_name";

            addTaskForm.ProjectsDropDownList.DataSource = projectitem;
            addTaskForm.ProjectsDropDownList.ValueMember = "id";
            addTaskForm.ProjectsDropDownList.DescriptionTextMember = "project_name";

            addTaskForm.PriorityDropDownList.DataSource = priorityitem;
            addTaskForm.PriorityDropDownList.ValueMember = "id";
            addTaskForm.PriorityDropDownList.DescriptionTextMember = "name";

            addProjectForm.GroupsDropDownList.DataSource = groupsitem;
            addProjectForm.GroupsDropDownList.ValueMember = "id";
            addProjectForm.GroupsDropDownList.DescriptionTextMember = "group_name";

            addProjectForm.StatusDropDownList.DataSource = statusitem;
            addProjectForm.StatusDropDownList.ValueMember = "id";
            addProjectForm.StatusDropDownList.DescriptionTextMember = "name";

            addProjectForm.UsersDropDownList.DataSource = taskModel.GetAdminUsers();
            addProjectForm.UsersDropDownList.ValueMember = "id";
            addProjectForm.UsersDropDownList.DescriptionTextMember = "user_name";

            // Добавляем справочные значения
            GridViewComboBoxColumn projectadmincomboBoxColumn = this.ProjectsGridView.Columns["project_admin"] as GridViewComboBoxColumn;
            projectadmincomboBoxColumn.DataSource = usersitem;
            projectadmincomboBoxColumn.ValueMember = "id";
            projectadmincomboBoxColumn.DisplayMember = "user_name";

            GridViewComboBoxColumn projectidcomboBoxColumn = this.TasksGridView.Columns["project_id"] as GridViewComboBoxColumn;
            projectidcomboBoxColumn.DataSource = projectitem;
            projectidcomboBoxColumn.ValueMember = "id";
            projectidcomboBoxColumn.DisplayMember = "project_name";

            GridViewComboBoxColumn groupcomboBoxColumn = this.TasksGridView.Columns["group_id"] as GridViewComboBoxColumn;
            groupcomboBoxColumn.DataSource = groupsitem;
            groupcomboBoxColumn.ValueMember = "id";
            groupcomboBoxColumn.DisplayMember = "group_name";

            GridViewComboBoxColumn rolecomboBoxColumn = this.TasksGridView.Columns["role_id"] as GridViewComboBoxColumn;
            rolecomboBoxColumn.DataSource = rolesitem;
            rolecomboBoxColumn.ValueMember = "id";
            rolecomboBoxColumn.DisplayMember = "name";

            GridViewComboBoxColumn statuscomboBoxColumn = this.TasksGridView.Columns["status_id"] as GridViewComboBoxColumn;
            statuscomboBoxColumn.DataSource = statusitem;
            statuscomboBoxColumn.ValueMember = "id";
            statuscomboBoxColumn.DisplayMember = "name";

            GridViewComboBoxColumn prioritycomboBoxColumn = this.TasksGridView.Columns["priority_id"] as GridViewComboBoxColumn;
            prioritycomboBoxColumn.DataSource = priorityitem;
            prioritycomboBoxColumn.ValueMember = "id";
            prioritycomboBoxColumn.DisplayMember = "name";

            GridViewComboBoxColumn userrolecomboBoxColumn = this.UsersGridView.Columns["role_id"] as GridViewComboBoxColumn;
            userrolecomboBoxColumn.DataSource = rolesitem;
            userrolecomboBoxColumn.ValueMember = "id";
            userrolecomboBoxColumn.DisplayMember = "name";

            GridViewComboBoxColumn projectsgroupcomboBoxColumn = this.ProjectsGridView.Columns["group_id"] as GridViewComboBoxColumn;
            projectsgroupcomboBoxColumn.DataSource = groupsitem;
            projectsgroupcomboBoxColumn.ValueMember = "id";
            projectsgroupcomboBoxColumn.DisplayMember = "group_name";

            GridViewComboBoxColumn projectsstatuscomboBoxColumn = this.ProjectsGridView.Columns["status_id"] as GridViewComboBoxColumn;
            projectsstatuscomboBoxColumn.DataSource = statusitem;
            projectsstatuscomboBoxColumn.ValueMember = "id";
            projectsstatuscomboBoxColumn.DisplayMember = "name";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            switch (CurrentUsers.role_id)
            {
                case (int)UserRoles.admin:
                    radRibbonBar1.CommandTabs["GroupsRibbonTab"].Visibility = ElementVisibility.Visible;
                    radRibbonBar1.CommandTabs["UsersRibbonTab"].Visibility = ElementVisibility.Visible;
                    radRibbonBar1.CommandTabs["ProjectsRibbonTab"].Visibility = ElementVisibility.Visible;
                    radRibbonBar1.CommandTabs["StatisticRibbonTab"].Visibility = ElementVisibility.Visible;
                    break;

                case (int)UserRoles.admin_project:
                    radRibbonBar1.CommandTabs["ProjectsRibbonTab"].Visibility = ElementVisibility.Visible;
                    break;

                case (int)UserRoles.user:
                    TasksAddButton.Enabled = false;
                    TasksDeleteButton.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// Обновить таблицу пользователи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersUpdateButton_Click(object sender, EventArgs e)
        {
            UsersGridView.DataSource = taskModel.GetUsersAsNoTracking();
        }
        /// <summary>
        /// Обновить таблицу Проекты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ProjectsUpdateButton_Click(object sender, EventArgs e)
        {
            ProjectsGridView.DataSource = taskModel.GetProjectsAsNoTracking();
        }

        /// <summary>
        /// Обновить таблицу группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GroupsUpdateButton_Click(object sender, EventArgs e)
        {
            GroupsGridView.DataSource = taskModel.GetGroupsAsNoTracking();
        }
        /// <summary>
        /// Обновить таблицу задач
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (CurrentUsers.role_id)
                {
                    case (int)UserRoles.admin:
                        TasksGridView.DataSource = taskModel.GetAdminTasksViewAsNoTracking();
                        break;

                    case (int)UserRoles.admin_project:
                        TasksGridView.DataSource = taskModel.GetAdminTasksViewAsNoTracking();
                        break;

                    case (int)UserRoles.user:
                        TasksGridView.DataSource = taskModel.GetAdminTasksViewAsNoTracking(CurrentUsers.id);
                        break;
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex, "Ошибка при загрузке задачи");
                UCMessageBox.Error($"Непредвиденная ошибка при загрузке таблицы Задач.{Environment.NewLine}О ней зафиксированы в log файле.");
            }
        }

        /// <summary>
        /// Отображаем страницу задач
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksRibbonTab_Click(object sender, EventArgs e)
        {
            ShowPage(1);
        }

        /// <summary>
        /// Отображаем страницу групп
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupsRibbonTab_Click(object sender, EventArgs e)
        {
            ShowPage(3);
        }

        /// <summary>
        /// Отображаем страницу пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersRibbonTab_Click(object sender, EventArgs e)
        {
            ShowPage(4);
        }
        /// <summary>
        /// Отображаем страницу проектов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectsRibbonTab_Click(object sender, EventArgs e)
        {
            ShowPage(2);
        }
        /// <summary>
        /// Очистить фильтр по задачам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksClearFilterButton_Click(object sender, EventArgs e)
        {
            TasksGridView.FilterDescriptors.Clear();
        }

        /// <summary>
        /// Очистка фильтра по группам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupsClearFilterButton_Click(object sender, EventArgs e)
        {
            GroupsGridView.FilterDescriptors.Clear();
        }
        /// <summary>
        /// Обрабатывает нажатие на клавишу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (pages[0].Visible)
                    switch (e.KeyCode)
                    {
                        
                        case Keys.F1: TasksInformationButton_Click(sender, e); break;
                        case Keys.F2: TasksAddButton_Click(sender, e); break;
                        case Keys.F3: TasksEditButton_Click(sender, e); break;
                        case Keys.F4: TasksDeleteButton_Click(sender, e); break;
                        case Keys.F5: TasksUpdateButton_Click(sender, e); break;
                        case Keys.F9: TasksClearFilterButton_Click(sender, e); break;
                    }
                else if (pages[2].Visible)
                    switch (e.KeyCode)
                    {
                        case Keys.F1: GroupsInformationButton_Click(sender, e); break;
                        case Keys.F2: GroupsAddButton_Click(sender, e); break;
                        case Keys.F3: GroupsEditButton_Click(sender, e); break;
                        case Keys.F4: GroupsDeleteButton_Click(sender, e); break;
                        case Keys.F5: GroupsUpdateButton_Click(sender, e); break;
                        case Keys.F9: GroupsClearFilterButton_Click(sender, e); break;
                    }
                else if (pages[1].Visible)
                    switch (e.KeyCode)
                    {
                        case Keys.F1: ProjectsInformationButton_Click(sender, e); break;
                        case Keys.F2: ProjectsAddButton_Click(sender, e); break;
                        case Keys.F3: ProjectsEditButton_Click(sender, e); break;
                        case Keys.F4: ProjectsDeleteButton_Click(sender, e); break;
                        case Keys.F5: ProjectsUpdateButton_Click(sender, e); break;
                        case Keys.F9: ProjectsClearFilterButton_Click(sender, e); break;
                    }
                else if (pages[3].Visible)
                    switch (e.KeyCode)
                    {
                        //case Keys.F1: ProjectsInformationButton_Click(sender, e); break;
                        case Keys.F2: UsersAddButton_Click(sender, e); break;
                        case Keys.F3: UsersEditButton_Click(sender, e); break;
                        case Keys.F5: UsersUpdateButton_Click(sender, e); break;
                        //case Keys.F4: ProjectsDeleteButton_Click(sender, e); break;
                        case Keys.F9: ProjectsClearFilterButton_Click(sender, e); break;
                    }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Информация по задаче
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksInformationButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Добавить задачу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUsers.role_id == (int)UserRoles.user) return;
                addTaskForm.LoadData(null);
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    //TasksUpdateButton_Click(sender, e);
                    SetDictionary();
                }
            }
            catch { }
        }
        
        /// <summary>
        /// Редактировать задачу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                addTaskForm.LoadData(GetSelectTask());
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    SetDictionary();
                    //TasksUpdateButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex, "Ошибка при редактировании задачи");
                UCMessageBox.Error($"Непредвиденная ошибка при загрузке страницы.{Environment.NewLine}О ней зафиксированы в log файле.");
            }
        }

        /// <summary>
        /// Удалить задачу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUsers.role_id == (int)UserRoles.user) return;
                if (TasksGridView.SelectedRows.Count > 0 && UCMessageBox.Question("Вы действительно хотите удалить выбранную задачу?") == DialogResult.Yes)
                {
                    taskModel.DeleteTask(GetSelectTask());
                    //TasksUpdateButton_Click(sender, e);
                    SetDictionary();
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex, "Ошибка при редактировании задачи");
                UCMessageBox.Error($"Непредвиденная ошибка при удалении записи.{Environment.NewLine}О ней зафиксированы в log файле.");
            }
        }

        /// <summary>
        /// Информация по группе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupsInformationButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Добавить группу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupsAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                addGroupFrom.LoadData(this, null);
                if(addGroupFrom.ShowDialog() == DialogResult.OK)
                {
                    //GroupsUpdateButton_Click(sender, e);
                    SetDictionary();
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex, "Ошибка при добавлении группы");
                UCMessageBox.Error($"Непредвиденная ошибка при загрузке страницы.{Environment.NewLine}О ней зафиксированы в log файле.");
            }
        }

        /// <summary>
        /// Редактировать группу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupsEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                addGroupFrom.LoadData(this, GetSelectGroup());
                if (addGroupFrom.ShowDialog() == DialogResult.OK)
                {
                    //GroupsUpdateButton_Click(sender, e);
                    SetDictionary();
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex, "Ошибка при добавлении группы");
                UCMessageBox.Error($"Непредвиденная ошибка при загрузке страницы.{Environment.NewLine}О ней зафиксированы в log файле.");
            }
        }

        /// <summary>
        /// Удалить группу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверить доступ и удалить может только тот кто создал
                if (GroupsGridView.SelectedRows.Count > 0 && UCMessageBox.Question("Вы действительно хотите удалить выбранную группу и все связанные проекты и задачи?") == DialogResult.Yes)
                {
                    taskModel.DeleteGroup(GetSelectGroup());
                    //GroupsUpdateButton_Click(sender, e);
                    SetDictionary();
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex, "Ошибка при добавлении группы");
                UCMessageBox.Error($"Непредвиденная ошибка при удалении записи.{Environment.NewLine}О ней зафиксированы в log файле.");
            }
        }

        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                registerForm.Clear();
                registerForm.RegisterButton.Text = "Добавить";
                registerForm.Text = "Добавление пользователя";
                registerForm.lockout_enabledPanel.Visible = true;
                if (registerForm.ShowDialog() == DialogResult.OK)
                {
                    //UsersUpdateButton_Click(sender, e);
                    SetDictionary();
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Редактирование польователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsersGridView.SelectedRows.Count > 0)
                {
                    registerForm.Clear();
                    registerForm.SetData(GetSelectUser());
                    registerForm.Text = "Редактирование пользователя";
                    registerForm.RegisterButton.Text = "Изменить";
                    registerForm.PasswordPanel.Visible = false;
                    registerForm.lockout_enabledPanel.Visible = true;
                    if (registerForm.ShowDialog() == DialogResult.OK)
                    {
                        SetDictionary();
                    //UsersUpdateButton_Click(sender, e);
                    }
                }
                else
                {
                    UCMessageBox.Error("Выберите пользователя!");
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Выводим нумерацую строк
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterTemplate_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridRowHeaderCellElement && e.Row is GridViewDataRowInfo)
            {
                GridDataView dataView = this.TasksGridView.MasterTemplate.DataView as GridDataView;
                e.CellElement.Text = (dataView.Indexer.Items.IndexOf(e.Row) + 1).ToString();
                e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.TextImageRelationProperty, ValueResetFlags.Local);
            }

            this.TasksGridView.TableElement.RowHeaderColumnWidth = 50;
        }

        /// <summary>
        /// Выводим нумерацую строк
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupsGridView_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridRowHeaderCellElement && e.Row is GridViewDataRowInfo)
            {
                GridDataView dataView = this.GroupsGridView.MasterTemplate.DataView as GridDataView;
                e.CellElement.Text = (dataView.Indexer.Items.IndexOf(e.Row) + 1).ToString();
                e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.TextImageRelationProperty, ValueResetFlags.Local);
            }

            this.GroupsGridView.TableElement.RowHeaderColumnWidth = 50;
        }

        /// <summary>
        /// Выводим нумерацую строк
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersGridView_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridRowHeaderCellElement && e.Row is GridViewDataRowInfo)
            {
                GridDataView dataView = this.UsersGridView.MasterTemplate.DataView as GridDataView;
                e.CellElement.Text = (dataView.Indexer.Items.IndexOf(e.Row) + 1).ToString();
                e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.TextImageRelationProperty, ValueResetFlags.Local);
            }

            this.UsersGridView.TableElement.RowHeaderColumnWidth = 50;
        }
        /// <summary>
        /// Выводим нумерацую строк
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectsGridView_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridRowHeaderCellElement && e.Row is GridViewDataRowInfo)
            {
                GridDataView dataView = this.ProjectsGridView.MasterTemplate.DataView as GridDataView;
                e.CellElement.Text = (dataView.Indexer.Items.IndexOf(e.Row) + 1).ToString();
                e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.TextImageRelationProperty, ValueResetFlags.Local);
            }

            this.ProjectsGridView.TableElement.RowHeaderColumnWidth = 50;
        }
        private void ProjectsInformationButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Добавить проект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectsAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProjectsGridView.SelectedRows.Count > 0)
                {
                    addProjectForm.LoadData(null);
                    addProjectForm.Text = "Добавление проекта";
                    addProjectForm.AddProjectButton.Text = "Добавить";
                    if (addProjectForm.ShowDialog() == DialogResult.OK)
                    {
                        SetDictionary();
                    }
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }
        /// <summary>
        /// Редактировать проект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectsEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProjectsGridView.SelectedRows.Count > 0)
                {
                    addProjectForm.LoadData(GetSelectProject());
                    addProjectForm.Text = "Редактирование проекта";
                    addProjectForm.AddProjectButton.Text = "Изменить";
                    if (addProjectForm.ShowDialog() == DialogResult.OK)
                    {
                        SetDictionary();
                        //ProjectsUpdateButton_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }
        /// <summary>
        /// Удалить проект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProjectsGridView.SelectedRows.Count > 0 && UCMessageBox.Question("Вы действительно хотите удалить выбранный проект и все задачи привязанные к данному проекту?") == DialogResult.Yes)
                {
                    taskModel.DeleteProject(GetSelectProject());
                    SetDictionary();
                    //ProjectsUpdateButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Очистка фильтра по проектам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectsClearFilterButton_Click(object sender, EventArgs e)
        {
            ProjectsGridView.FilterDescriptors.Clear();
        }
        
        #region functions
        #region pages
        /// <summary>
        /// Добавляе страницу к списку страниц
        /// </summary>
        /// <param name="panel"></param>
        private void AppendPage(Panel panel)
        {
            try
            {
                panel.Visible = false;
                BodyPanel.Controls.Add(panel);
                pages.Add(panel);
            }
            catch (Exception ex) { UCStr.SaveLog(logger, ex, "MainForm.cs - AppendPage"); }
        }
        /// <summary>
        /// Отображает страницу
        /// </summary>
        /// <param name="page_index">Номер страницы с 1</param>
        public void ShowPage(int page_index)
        {
            try
            {
                for (int i = 0; i < pages.Count; i++)
                    pages[i].Visible = i + 1 == page_index;
            }
            catch (Exception ex) { UCStr.SaveLog(logger, ex, "MainForm.cs - ShowPage"); }
        }
        #endregion pages

        private users GetSelectUser()
        {
            try
            {
                return UsersGridView.SelectedRows[0].Cells["id"].Value != null ? taskModel.GetUserById(Int64.Parse(UsersGridView.SelectedRows[0].Cells["id"].Value.ToString())) : null;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
            return null;
        }
        private projects GetSelectProject()
        {
            try
            {
                return ProjectsGridView.SelectedRows[0].Cells["id"].Value != null ? taskModel.GetProjectById(Int64.Parse(ProjectsGridView.SelectedRows[0].Cells["id"].Value.ToString())) : null;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
            return null;
        }
        private groups GetSelectGroup()
        {
            try
            {
                return GroupsGridView.SelectedRows[0].Cells["id"].Value != null ? taskModel.GetGroupById(Int64.Parse(GroupsGridView.SelectedRows[0].Cells["id"].Value.ToString())) : null;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
            return null;
        }
        private tasks GetSelectTask()
        {
            try
            {
                return TasksGridView.SelectedRows[0].Cells["id"].Value != null ? taskModel.GetTasksById(Int64.Parse(TasksGridView.SelectedRows[0].Cells["id"].Value.ToString())) : null;
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
            return null;
        }

        #endregion functions
        /// <summary>
        /// Цвета фона различных статусов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksGridView_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            try
            {
                int i = StatusNames.IndexOf(e.RowElement.RowInfo.Cells["status_id"].Value.ToString());
                if (i != -1)
                {
                    e.RowElement.DrawFill = true;
                    e.RowElement.BackColor = RowColors[i];
                    e.RowElement.GradientStyle = GradientStyles.Solid;
                }
                if(e.RowElement.RowInfo.Cells["dedline"].Value != null)
                {
                    DateTime dedline = DateTime.Parse(e.RowElement.RowInfo.Cells["dedline"].Value.ToString());
                    if(dedline < DateTime.Now)
                    {
                        e.RowElement.DrawFill = true;
                        e.RowElement.BackColor = Color.FromArgb(255, 192, 192);
                        e.RowElement.GradientStyle = GradientStyles.Solid;
                    }
                }
            }
            catch (Exception ex)    
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Устанавливаем фильтр. Задачи которые должны быть начаты на следующей неделе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksNextWeekButton_Click(object sender, EventArgs e)
        {
            try
            {
                TasksGridView.FilterDescriptors.Clear();
                FilterDescriptor filterDate = new FilterDescriptor();
                filterDate.PropertyName = "start_date";
                filterDate.Operator = FilterOperator.IsGreaterThanOrEqualTo;
                filterDate.Value = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday).AddDays(7);
                filterDate.IsFilterEditor = true;
                this.TasksGridView.FilterDescriptors.Add(filterDate);
            }
            catch (Exception ex)
            {
                UCStr.SaveLog(ex);
            }
        }

        /// <summary>
        /// Завершаем программу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}