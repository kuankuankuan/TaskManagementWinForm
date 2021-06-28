namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.projects")]
    public partial class projects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public projects()
        {
            tasks = new HashSet<tasks>();
        }

        public long id { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(65535)]
        public string project_name { get; set; }

        public long group_id { get; set; }

        public long? status_id { get; set; }

        public long? project_admin { get; set; }

        public virtual groups groups { get; set; }

        public virtual status status { get; set; }

        public virtual users users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tasks> tasks { get; set; }
    }
}
