namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.admin_tasks_view")]
    public partial class admin_tasks_view
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long? user_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string user_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool? lockout_enabled { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long? role_id { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long group_id { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "varchar")]
        [StringLength(65535)]
        public string project_name { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "varchar")]
        [StringLength(65535)]
        public string task_name { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "timestamptz")]
        public DateTime dedline { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long status_id { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long priority_id { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long project_id { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "timestamptz")]
        public DateTime start_date { get; set; }
    }
}
