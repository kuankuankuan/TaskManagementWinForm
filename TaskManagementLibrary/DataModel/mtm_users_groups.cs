namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.mtm_users_groups")]
    public partial class mtm_users_groups
    {
        public long id { get; set; }

        public long? user_id { get; set; }

        public long? group_id { get; set; }

        public virtual groups groups { get; set; }

        public virtual users users { get; set; }
    }
}
