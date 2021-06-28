namespace TaskManagementLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskManagementLibrary.DataModel.TaskModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            this.SetSqlGenerator("Devart.Data.PostgreSql", new Devart.Data.PostgreSql.Entity.Migrations.PgSqlEntityMigrationSqlGenerator());
        }

        protected override void Seed(TaskManagementLibrary.DataModel.TaskModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
