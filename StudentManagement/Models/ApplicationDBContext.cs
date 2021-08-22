using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Course>()
                .HasMany<Subject>(s => s.Subjects)
                .WithOne(g => g.course)
                .HasForeignKey(d => d.CourseId);

            builder.Entity<Course>()
                .HasMany<ApplicationUser>(s => s.ApplicationUsers)
                .WithOne(g => g.course)
                .HasForeignKey(d => d.CourseId);


            //any guid
            string ADMIN_ID = Guid.NewGuid().ToString();
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string STUDENT_ROLE_ID = Guid.NewGuid().ToString();
            string COURSE_ID = Guid.NewGuid().ToString();
            string SUBJECT_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ADMIN_ROLE_ID,
                Name = "Administrator",
                NormalizedName = "Administrator".ToUpper()
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = STUDENT_ROLE_ID,
                Name = "Student",
                NormalizedName = "Student".ToUpper()
            });

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "MAIN_ADMIN",
                UserType = "Administrator",
                NormalizedUserName = "MAIN_ADMIN".ToUpper(),
                FirstName = "Gilbert",
                LastName = "Adu",
                Gender = "Male",
                Email = "main@admin.com",
                NormalizedEmail = "main@admin.com".ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "mainAdminPassword"),
                SecurityStamp = string.Empty,
                CourseId = COURSE_ID
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            });

            builder.Entity<Course>().HasData(new Course
            {
                CourseId = COURSE_ID,
                Name = "Psychology"
            });

            builder.Entity<Subject>().HasData(new Subject
            {
                SubjectId = SUBJECT_ID,
                Name = "Introduction To Human Brain",
                CourseId = COURSE_ID,
            });
        }
    }
}
