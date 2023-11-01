namespace StudentsManage_Funcs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("student")]
    public partial class student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string student_id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string student_name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string gender { get; set; }

        public int grade { get; set; }

        public int class_id { get; set; }

        public virtual classroom classroom { get; set; }
    }
}
