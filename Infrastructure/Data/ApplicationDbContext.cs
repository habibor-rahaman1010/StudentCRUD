using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<StudentTable>? Students { get; set; }
        public DbSet<ClassTable>? Classes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=HABIBOR-RAHAMAN\\SQLEXPRESS;Database=studentscurd;User Id=habibor144369;Password=c++c++c#;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("StudentCURD"));
        }

        //We here built a relationship using fluent API.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentTable>()
                .HasOne(s => s.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId);

            modelBuilder.Entity<ClassTable>().HasData(
                new ClassTable { Id = 1, Name = "One", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 2, Name = "Two", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 3, Name = "Three", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 4, Name = "Four", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 5, Name = "Five", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 6, Name = "Six", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 7, Name = "Seven", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 8, Name = "Eight", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 9, Name = "Nine", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 10, Name = "Ten", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 11, Name = "Colleage First Year", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 12, Name = "Colleg Second Year", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 13, Name = "BSc In CSE", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 14, Name = "BSc In EEE", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 15, Name = "BSc In CS", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new ClassTable { Id = 16, Name = "BSc In Civil", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now }
            );
        }
    }
}
