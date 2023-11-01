using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudentsManage_Funcs
{
    public partial class StuModel : DbContext
    {
        public StuModel()
            : base("name=StuDB")
        {
        }

        public virtual DbSet<classroom> classroom { get; set; }
        public virtual DbSet<school> school { get; set; }
        public virtual DbSet<student> student { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<classroom>()
                .HasMany(e => e.student)
                .WithRequired(e => e.classroom)
                .HasForeignKey(e => e.class_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<school>()
                .HasMany(e => e.classroom)
                .WithRequired(e => e.school)
                .HasForeignKey(e => e.school_id)
                .WillCascadeOnDelete(false);
        }
    }
}
