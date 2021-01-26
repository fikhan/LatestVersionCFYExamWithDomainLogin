using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CFY_Exam.Models
{
    public partial class CFYExamContext : DbContext
    {
        public CFYExamContext()
        {
        }

        public CFYExamContext(DbContextOptions<CFYExamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GroupPrivilige> GroupPriviliges { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=10.202.242.57\\SQL2016;Initial Catalog=CFYExam;user id=sa; password=@dm1n$a123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<GroupPrivilige>(entity =>
            {
                entity.Property(e => e.GroupPriviligeId).HasColumnName("GroupPriviligeID");

                entity.Property(e => e.PriviligesId).HasColumnName("PriviligesID");

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            });

            modelBuilder.Entity<Privilege>(entity =>
            {
                entity.HasKey(e => e.PriviligesId);

                entity.Property(e => e.PriviligesId).HasColumnName("PriviligesID");

                entity.Property(e => e.FirstTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.FirstUserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.LastUserName).HasMaxLength(50);

                entity.Property(e => e.PriviligeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PriviligeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.Property(e => e.FirstTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.FirstUserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.LastUserName).HasMaxLength(50);

                entity.Property(e => e.UserGroupCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
