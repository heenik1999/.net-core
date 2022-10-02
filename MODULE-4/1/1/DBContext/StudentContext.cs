using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace _1.DBContext
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Stud> Studs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SHRITOOL\\SQLEXPRESS;Database=Student;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.ToTable("Stud");

                entity.Property(e => e.StudId).HasColumnName("Stud_Id");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CityId)
                    .HasMaxLength(50)
                    .HasColumnName("City_Id");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("F_Name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.IsDelete).HasColumnName("Is_Delete");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .HasColumnName("L_Name");

                entity.Property(e => e.MobileNumber).HasColumnName("Mobile_Number");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.StateId)
                    .HasMaxLength(50)
                    .HasColumnName("State_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
