namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.mtm_users_tasks")]
    public partial class mtm_users_tasks
    {
        public long id { get; set; }

        public long user_id { get; set; }

        public long task_id { get; set; }

        public virtual tasks tasks { get; set; }

        public virtual users users { get; set; }
    }
}
