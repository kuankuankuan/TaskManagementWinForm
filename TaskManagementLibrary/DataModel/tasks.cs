namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tasks")]
    public partial class tasks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tasks()
        {
            mtm_users_tasks = new HashSet<mtm_users_tasks>();
        }

        public long id { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(65535)]
        public string task_name { get; set; }

        public long project_id { get; set; }

        [Column(TypeName = "timestamptz")]
        public DateTime dedline { get; set; }

        public long status_id { get; set; }

        public long priority_id { get; set; }
        [Column(TypeName = "timestamptz")]
        public DateTime start_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mtm_users_tasks> mtm_users_tasks { get; set; }

        public virtual priorities priorities { get; set; }

        public virtual projects projects { get; set; }

        public virtual status status { get; set; }
    }
}
