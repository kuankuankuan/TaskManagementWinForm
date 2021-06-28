namespace TaskManagementLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.projects_view")]
    public partial class projects_view
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long group_id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "varchar")]
        [StringLength(65535)]
        public string group_name { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "varchar")]
        [StringLength(65535)]
        public string project_name { get; set; }

        public long? project_id { get; set; }
    }
}
