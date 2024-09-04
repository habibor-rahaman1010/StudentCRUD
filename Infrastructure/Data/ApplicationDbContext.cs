using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Core.Interface;


namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<StudentTable>? Students { get; set; }
        public DbSet<ClassTable>? Classes { get; set; }
        public DbSet<CategoryTable>? Categories { get; set; }
        public DbSet<BlogPostTable>? BlogPosts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        //We here built a relationship using fluent API.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Roles
            var superAdminRoleId = Guid.NewGuid().ToString();
            var adminRoleId = Guid.NewGuid().ToString();
            var userRoleId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = superAdminRoleId,
                    Name = "SUPERADMIN",
                    NormalizedName = "SUPERADMIN"
                },
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "ADMIN",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = userRoleId,
                    Name = "USER",
                    NormalizedName = "USER"
                }
            );


            // Seed Users
            var superAdminUserId = Guid.NewGuid().ToString();
             var hasher = new PasswordHasher<ApplicationUser>();
             var passwordHash = hasher.HashPassword(null, "superAdmin123@");

             modelBuilder.Entity<ApplicationUser>().HasData(
                 new ApplicationUser
                 {
                     Id = superAdminUserId,
                     FirstName = "Habibor",
                     LastName = "Rahaman",
                     UserName = "habibor.rahaman1010@gmail.com",
                     NormalizedUserName = "HABIBOR.RAHAMAN1010@GMAIL.COM",
                     Email = "habibor.rahaman1010@gmail.com",
                     NormalizedEmail = "HABIBOR.RAHAMAN1010@GMAIL.COM",
                     EmailConfirmed = true,
                     PhoneNumber = "01768280237",
                     PhoneNumberConfirmed = true,
                     PasswordHash = passwordHash
                 }
             );

             // Seed UserRoles
             modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                 new IdentityUserRole<string> { UserId = superAdminUserId, RoleId = superAdminRoleId }
             );


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

            modelBuilder.Entity<StudentTable>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasDefaultValue(0);
                    
                entity.Property(e => e.DOB)
                    .IsRequired()
                    .HasDefaultValueSql("GETDATE()")
                    .HasColumnType("date")
                    .HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc))
                    .HasAnnotation("Comment", "Date of Birth");

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasDefaultValue(1);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.ModificationDate)
                    .IsRequired()
                    .HasDefaultValueSql("GETDATE()");
            });

            modelBuilder.Entity<CategoryTable>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.Property(c => c.CategoryName)
                      .IsRequired()
                      .HasMaxLength(100);
            });

            modelBuilder.Entity<BlogPostTable>(entity =>
            {
                entity.HasKey(b => b.Id);

                entity.Property(b => b.Title)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(b => b.Content)
                      .IsRequired();

                entity.Property(b => b.Author)
                      .HasMaxLength(100); 

                entity.Property(b => b.Created)
                      .HasDefaultValueSql("GETDATE()");

                entity.Property(b => b.Updated)
                      .HasDefaultValueSql("GETDATE()");

                entity.HasOne(b => b.Category)
                      .WithMany(c => c.BlogPosts)
                      .HasForeignKey(b => b.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade); 
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
