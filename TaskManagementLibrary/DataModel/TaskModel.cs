namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class TaskModel : DbContext
    {
        public TaskModel()
            : base("name=TaskModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<groups> groups { get; set; }
        public virtual DbSet<mtm_users_groups> mtm_users_groups { get; set; }
        public virtual DbSet<mtm_users_tasks> mtm_users_tasks { get; set; }
        public virtual DbSet<priorities> priorities { get; set; }
        public virtual DbSet<projects> projects { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<tasks> tasks { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<admin_tasks_view> admin_tasks_view { get; set; }
        public virtual DbSet<mtm_users_groups_view> mtm_users_groups_view { get; set; }
        public virtual DbSet<mtm_users_tasks_view> mtm_users_tasks_view { get; set; }
        public virtual DbSet<projects_view> projects_view { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<groups>()
                .HasMany(e => e.mtm_users_groups)
                .WithRequired(e => e.groups)
                .HasForeignKey(e => e.group_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<groups>()
                .HasMany(e => e.projects)
                .WithRequired(e => e.groups)
                .HasForeignKey(e => e.group_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<priorities>()
                .HasMany(e => e.tasks)
                .WithRequired(e => e.priorities)
                .HasForeignKey(e => e.priority_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<projects>()
                .HasMany(e => e.tasks)
                .WithRequired(e => e.projects)
                .HasForeignKey(e => e.project_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.users)
                .WithRequired(e => e.roles)
                .HasForeignKey(e => e.role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<status>()
                .HasMany(e => e.projects)
                .WithOptional(e => e.status)
                .HasForeignKey(e => e.status_id);

            modelBuilder.Entity<status>()
                .HasMany(e => e.tasks)
                .WithRequired(e => e.status)
                .HasForeignKey(e => e.status_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tasks>()
                .HasMany(e => e.mtm_users_tasks)
                .WithRequired(e => e.tasks)
                .HasForeignKey(e => e.task_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.groups)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.mtm_users_groups)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.mtm_users_tasks)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.projects)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.project_admin);

            modelBuilder.Entity<admin_tasks_view>()
                .Property(e => e.dedline)
                .HasPrecision(0);
        }

        /// <summary>
        /// Добавить пользователя в базу
        /// </summary>
        /// <param name="user">Экземпляр класса <see cref="users"></param>
        public void InsertUser(users user)
        {
            try
            {
                Database.Connection.Open();
                users.Add(user);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Добавить пользователя в базу
        /// </summary>
        /// <param name="user">Экземпляр класса <see cref="users"></param>
        public void InsertTask(tasks task)
        {
            try
            {
                Database.Connection.Open();
                tasks.Add(task);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Добавить группу в базу
        /// </summary>
        /// <param name="user">Экземпляр класса <see cref="groups"></param>
        public void InsertGroups(groups group)
        {
            try
            {
                Database.Connection.Open();
                groups.Add(group);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Добавить проект в базу
        /// </summary>
        /// <param name="user">Экземпляр класса <see cref="groups"></param>
        public void InsertProject(projects project)
        {
            try
            {
                Database.Connection.Open();
                projects.Add(project);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        /// Добавить пользователя в базу
        /// </summary>
        /// <param name="user">Экземпляр класса <see cref="mtm_users_groups"></param>
        public void InsertMtmUserGroup(mtm_users_groups user_group)
        {
            try
            {
                Database.Connection.Open();
                mtm_users_groups.Add(user_group);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Добавить связку пользователь-задача
        /// </summary>
        /// <param name="user">Экземпляр класса <see cref="mtm_users_tasks"></param>
        public void InsertMtmUserGroup(mtm_users_tasks user_task)
        {
            try
            {
                Database.Connection.Open();
                mtm_users_tasks.Add(user_task);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }

        }
        /// <summary>
        /// Получить пользователя по логину
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public users GetUserByLogin(string login)
        {
            try
            {
                Database.Connection.Open();
                return (from d in users
                        where d.login == login
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить пользователя по логину
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public users GetUserByLoginAsNoTracking(string login)
        {
            try
            {
                Database.Connection.Open();
                return (from d in users
                        where d.login == login
                        select d).AsNoTracking().FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        /// Получить всех пользователей
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<users> GetUsers()
        {
            try
            {
                Database.Connection.Open();
                return (from d in users
                        select d).OrderByDescending(x => x.id).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        /// Получить всех администаторов
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<users> GetAdminUsers()
        {
            try
            {
                Database.Connection.Open();
                return (from d in users
                        where d.role_id != (int)UserRoles.user
                        select d).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить всех пользователей
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<users> GetUsersAsNoTracking()
        {
            try
            {
                Database.Connection.Open();
                return (from d in users
                        select d).AsNoTracking().OrderByDescending(x => x.id).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        /// Получить всех пользователей
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<users> GetUsersNotLockedAsNoTracking()
        {
            try
            {
                Database.Connection.Open();
                return (from d in users
                        where d.lockout_enabled == false
                        select d).AsNoTracking().OrderByDescending(x => x.id).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить пользователя по идентификатору
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public users GetUserById(long id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in users
                        where d.id == id
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить связку пользователь-группа
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public mtm_users_groups GetMtmUserGroup(long id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in mtm_users_groups
                        where d.id == id
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Обновить таблицу <see cref="groups">
        /// </summary>
        /// <param name="group">Экземпляр класса <see cref="groups"></param>
        public void UpdateGroup(groups group)
        {
            try
            {
                if (group == null) return;
                Database.Connection.Open();
                var oldgroup = GetGroupById(group.id);
                oldgroup.user_id = group.user_id;
                oldgroup.group_name = group.group_name;
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Обновить таблицу <see cref="users">
        /// </summary>
        /// <param name="group">Экземпляр класса <see cref="users"></param>
        public void UpdateUser(users user)
        {
            try
            {
                if (user == null) return;
                Database.Connection.Open();
                var olduser = GetUserById(user.id);
                olduser.user_name = user.user_name;
                olduser.role_id = user.role_id;
                olduser.login = user.login;
                olduser.lockout_enabled = user.lockout_enabled;
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }

        }

        /// <summary>
        /// Обновить таблицу <see cref="tasks">
        /// </summary>
        /// <param name="group">Экземпляр класса <see cref="tasks"></param>
        public void UpdateMTMUsersTask(mtm_users_tasks mtm_users_task)
        {
            try
            {
                if (mtm_users_task == null) return;
                Database.Connection.Open();
                var oldmtm_users_task = GetMtmUsersTaskById(mtm_users_task.id);
                oldmtm_users_task.user_id = mtm_users_task.user_id;
                oldmtm_users_task.task_id = mtm_users_task.task_id;
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Обновить таблицу <see cref="tasks">
        /// </summary>
        /// <param name="group">Экземпляр класса <see cref="tasks"></param>
        public void UpdateTask(tasks task)
        {
            try
            {
                if (task == null) return;
                Database.Connection.Open();
                var oldtask = GetTasksById(task.id);
                oldtask.dedline = task.dedline;
                oldtask.priority_id = task.priority_id;
                oldtask.start_date = task.start_date;
                oldtask.project_id = task.project_id;
                oldtask.status_id = task.status_id;
                oldtask.task_name = task.task_name;
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }


        /// <summary>
        /// Обновить таблицу <see cref="projects">
        /// </summary>
        /// <param name="group">Экземпляр класса <see cref="projects"></param>
        public void UpdateProject(projects project)
        {
            try
            {
                Database.Connection.Open();
                var oldproject = GetProjectById(project.id);
                oldproject.status_id = project.status_id;
                oldproject.group_id = project.group_id;
                oldproject.project_name = project.project_name;
                oldproject.project_admin = project.project_admin;
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }

        }
        /// <summary>
        /// Получить список групп
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<groups> GetGroups()
        {
            try
            {
                Database.Connection.Open();
                return (from d in groups
                        select d).OrderBy(x => x.id).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить список групп
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<groups> GetGroupsAsNoTracking()
        {
            try
            {
                Database.Connection.Open();
                return (from d in groups
                        orderby d.id
                        select d).AsNoTracking().OrderBy(x => x.id).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        /// Получить список групп
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public groups GetGroupByName(string name)
        {
            try
            {
                Database.Connection.Open();
                return (from d in groups
                        where d.group_name == name
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить список групп
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public groups GetGroupById(long id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in groups
                        where d.id == id
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить список групп
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public projects GetProjectByName(string name)
        {
            try
            {
                Database.Connection.Open();
                return (from d in projects
                        where d.project_name == name
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        /// Получить список групп
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public projects GetProjectByNameAsNoTracking(string name)
        {
            try
            {
                Database.Connection.Open();
                return (from d in projects
                        where d.project_name == name
                        select d).AsNoTracking().FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        /// Получить список статусов
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<status> GetStatus()
        {
            try
            {
                Database.Connection.Open();
                return (from d in status
                        select d).OrderBy(x=>x.id).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить список статусов
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<priorities> GetPriorities()
        {
            try
            {
                Database.Connection.Open();
                return (from d in priorities
                        select d).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить связку пользователь-группа по идентификатору группы
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<mtm_users_groups> GetMtmUsersGroups(long group_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in mtm_users_groups
                        where d.group_id == group_id
                        select d).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить связку пользователь-задача по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public mtm_users_tasks GetMtmUsersTaskById(long id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in mtm_users_tasks
                        where d.id == id
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить связку пользователь-задача по идентификатору
        /// </summary>
        /// <param name="task_id">Идентификатор задачи</param>
        /// <returns></returns>
        public mtm_users_tasks GetMtmUsersTaskByTaskId(long task_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in mtm_users_tasks
                        where d.task_id == task_id
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить связку пользователь-задача по идентификатору
        /// </summary>
        /// <param name="task_id">Идентификатор задачи</param>
        /// <returns></returns>
        public List<mtm_users_tasks> GetMtmUsersTasksByTaskId(long task_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in mtm_users_tasks
                        where d.task_id == task_id
                        select d).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }

        }
        /// <summary>
        /// Получить связку пользователь-задача по идентификатору
        /// </summary>
        /// <param name="task_id">Идентификатор задачи</param>
        /// <returns></returns>
        public mtm_users_tasks GetMtmUsersTaskByTaskIdAsNoTracking(long task_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in mtm_users_tasks
                        where d.task_id == task_id
                        select d).AsNoTracking().FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }

        }
        /// <summary>
        /// Удалить проект и все задачи к данному проекту
        /// </summary>
        /// <param name="project"></param>
        public void DeleteProject(projects project)
        {
            try
            {
                Database.Connection.Open();
                if (project == null) return;
                var tasks = GetTasksByProjectId(project.id);
                foreach (var task in tasks)
                {
                    this.tasks.Attach(task);
                    this.tasks.Remove(task);
                    SaveChanges();
                }
                this.projects.Attach(project);
                this.projects.Remove(project);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Удалить задачу
        /// </summary>
        /// <param name="project"></param>
        public void DeleteTask(tasks task)
        {
            try
            {
                Database.Connection.Open();
                if (task == null) return;
                foreach (var item in GetMtmUsersTasksByTaskId(task.id))
                    DeleteMtmUserTasks(item);

                this.tasks.Attach(task);
                this.tasks.Remove(task);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Удалить группу
        /// </summary>
        /// <param name="project"></param>
        public void DeleteGroup(groups group)
        {
            try
            {
                Database.Connection.Open();
                if (group == null) return;
                foreach (var mtmgroup in GetMtmUsersGroups(group.id))
                    DeleteMtmUserGroup(mtmgroup);

                foreach (var project in GetProjectsByGroupId(group.id))
                    DeleteProject(project);

                this.groups.Attach(group);
                this.groups.Remove(group);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }

        }
        /// <summary>
        /// Получить пользователей не привязанных к данной группе
        /// </summary>
        /// <param name="group_id"></param>
        /// <returns></returns>
        public List<users> GetNotMtmUsersGroups(long group_id)
        {
            try
            {
                List<users> returnusers = new List<users>();
                Database.Connection.Open();
                return (from d in users
                        join user_group in this.mtm_users_groups on d.id equals user_group.user_id into user
                        from user_id in user.DefaultIfEmpty()
                        where (/*user_id.user_id == null || */user_id.group_id != group_id) && d.lockout_enabled == false
                        select d).AsNoTracking().GroupBy(x => x.id).Select(x => x.FirstOrDefault()).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить связку пользователь-группа по идентификатору группы
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<mtm_users_groups_view> GetMtmUsersGroupsViewAsNoTracking(long group_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in mtm_users_groups_view
                        where d.group_id == group_id
                        select d).AsNoTracking().ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Удалить связку user-group из таблицы <see cref="mtm_users_groups">
        /// </summary>
        /// <param name="mtm_user_group"></param>
        public void DeleteMtmUserGroup(mtm_users_groups mtm_user_group)
        {
            try
            {
                Database.Connection.Open();
                if (mtm_user_group == null) return;
                this.mtm_users_groups.Attach(mtm_user_group);
                this.mtm_users_groups.Remove(mtm_user_group);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Удалить связку user-group из таблицы <see cref="mtm_users_tasks">
        /// </summary>
        /// <param name="mtm_users_tasks"></param>
        public void DeleteMtmUserTasks(mtm_users_tasks mtm_user_task)
        {
            try
            {
                Database.Connection.Open();
                if (mtm_user_task == null) return;
                this.mtm_users_tasks.Attach(mtm_user_task);
                this.mtm_users_tasks.Remove(mtm_user_task);
                SaveChanges();
            }
            finally
            {
                Database.Connection.Close();
            }

        }
        /// <summary>
        /// Получить идентификатор указанного роля
        /// </summary>
        /// <param name="role_name"></param>
        /// <returns></returns>
        public long GetRoleIdByName(string role_name)
        {
            try
            {
                Database.Connection.Open();
                return (from d in roles
                        where d.name == role_name
                        select d.id).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        /// Получить роли
        /// </summary>
        /// <returns>Список ролей</returns>
        public List<roles> GetRoles()
        {
            try
            {
                Database.Connection.Open();
                return (from d in roles
                        select d).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить все проекты
        /// </summary>
        /// <returns>Список проектов</returns>
        public List<projects> GetProjects()
        {
            try
            {
                Database.Connection.Open();
                return (from d in projects
                        select d).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }


        /// <summary>
        /// Получить все проекты
        /// </summary>
        /// <returns>Список проектов</returns>
        public List<projects> GetProjectsAsNoTracking()
        {
            try
            {
                Database.Connection.Open();
                return (from d in projects
                        select d).AsNoTracking().ToList();
            }
            finally
            {
                Database.Connection.Close();
            }

        }
        /// <summary>
        /// Получить проекты
        /// </summary>
        /// <returns>Список проектов</returns>
        public List<projects> GetProjectsByGroupId(long group_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in projects
                        where d.group_id == group_id
                        select d).AsNoTracking().ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }


        /// <summary>
        /// Получить задачи по проекту
        /// </summary>
        /// <returns>Список проектов</returns>
        public List<tasks> GetTasksByProjectId(long project_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in tasks
                        where d.project_id == project_id
                        select d).AsNoTracking().ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        ///  Получить все задачи
        /// </summary>
        /// <param name="task_id">Идентификатор</param>
        /// <returns></returns>
        public tasks GetTasks()
        {
            try
            {
                Database.Connection.Open();
                return (from d in tasks
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        /// <summary>
        ///  Получить задачу по идентификатору
        /// </summary>
        /// <param name="task_id">Идентификатор</param>
        /// <returns></returns>
        public tasks GetTasksById(long task_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in tasks
                        where d.id == task_id
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить проекты по идентификатору
        /// </summary>
        /// <returns>Список проектов</returns>
        public projects GetProjectById(long id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in projects
                        where d.id == id
                        select d).FirstOrDefault();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить проекты относящие в группу
        /// </summary>
        /// <param name="group_id">Идентификатор группы</param>
        /// <returns>Список проектов в группе</returns>
        public List<projects_view> GetProjectsViewByGroup(long group_id)
        {
            try
            {
                Database.Connection.Open();
                return (from d in projects_view
                        where d.group_id == group_id
                        select d).AsNoTracking().ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить представление по задачам
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<admin_tasks_view> GetAdminTasksViewAsNoTracking()
        {
            try
            {
                Database.Connection.Open();
                return (from d in admin_tasks_view
                        select d).AsNoTracking().ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        /// <summary>
        /// Получить задачи пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public List<admin_tasks_view> GetAdminTasksViewAsNoTracking(long user_id)
        {
            try
            {
                Database.Connection.Open();
                var user_groups = (from d in mtm_users_groups
                                   where d.user_id == user_id
                                   select d.group_id).ToList();
                return (from d in admin_tasks_view
                        where user_groups.Contains(d.group_id) || d.user_id == user_id
                        select d).AsNoTracking().ToList();


            }
            finally
            {
                Database.Connection.Close();
            }
        }
    }

    public enum UserRoles
    {
        admin = 1,
        admin_project = 2,
        user = 3
    }
}