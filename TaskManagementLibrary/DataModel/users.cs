namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.users")]
    public partial class users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users()
        {
            groups = new HashSet<groups>();
            mtm_users_groups = new HashSet<mtm_users_groups>();
            mtm_users_tasks = new HashSet<mtm_users_tasks>();
            projects = new HashSet<projects>();
        }

        public long id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(65535)]
        public string login { get; set; }

        [Required]
        public string password_hash { get; set; }

        [Required]
        [StringLength(256)]
        public string user_name { get; set; }

        public bool lockout_enabled { get; set; }

        public long role_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<groups> groups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mtm_users_groups> mtm_users_groups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mtm_users_tasks> mtm_users_tasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projects> projects { get; set; }

        public virtual roles roles { get; set; }
    }
}
