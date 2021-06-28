namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.mtm_users_tasks_view")]
    public partial class mtm_users_tasks_view
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long user_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string user_name { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "varchar")]
        [StringLength(65535)]
        public string task_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long task_id { get; set; }
    }
}
