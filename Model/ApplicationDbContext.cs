using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamYolo.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Object> Objects { get; set; }
        public DbSet<StudentObjectHistory> StudentObjectHistories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Usar LocalDB de Visual Studio
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Escuela;Integrated Security=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Relación entre StudentObjectHistory y Student
            modelBuilder.Entity<StudentObjectHistory>()
                .HasOne(soh => soh.Student)
                .WithMany(student => student.StudentObjectHistories)
                .HasForeignKey(soh => soh.StudentId);
        }
        public void InsertStudentObjectHistory(int studentId, int objectId, DateTime fechaInicio, DateTime fechaFin)
        {
            var history = new StudentObjectHistory
            {
                StudentId = studentId,
                //ObjectId = objectId,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };

            StudentObjectHistories.Add(history);
            SaveChanges();
        }
    }
}
