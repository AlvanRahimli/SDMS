using Microsoft.EntityFrameworkCore;
using SDMS.Models;
using SDMS.Utilities;

namespace SDMS.Data
{
    public class SDMSContext : DbContext
    {
        public SDMSContext(DbContextOptions<SDMSContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Seed data:
            builder.Seed();

            // Configuring relationships between many-to-many
            // relationships. (Course - Student):
            builder.Entity<TakenCourseStudent>()
                .HasKey(t => new { t.CourseId, t.StudentId });

            builder.Entity<TakenCourseStudent>()
                .HasOne(t => t.Course)
                .WithMany(c => c.TakenCourseStudents)
                .HasForeignKey(t => t.CourseId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TakenCourseStudent>()
                .HasOne(t => t.Student)
                .WithMany(c => c.TakenCourseStudents)
                .HasForeignKey(t => t.StudentId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring many-to-many
            // relationships. (Course - Student):
            builder.Entity<CurrentCourseStudent>()
                .HasKey(t => new { t.CourseId, t.StudentId });

            builder.Entity<CurrentCourseStudent>()
                .HasOne(t => t.Course)
                .WithMany(c => c.CurrentCourseStudents)
                .HasForeignKey(t => t.CourseId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CurrentCourseStudent>()
                .HasOne(t => t.Student)
                .WithMany(s => s.CurrentCourseStudents)
                .HasForeignKey(t => t.StudentId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring relationship one-to-many
            // (Course - Course)
            builder.Entity<Course>()
                .HasOne(c => c.RequiredBy)
                .WithMany(c => c.Prerequisites)
                .HasForeignKey(c => c.RequiredById)
                .IsRequired(false);

            // Configuring many-to-many
            // relationships. (Course - Teacher):
            builder.Entity<TeacherCourse>()
                .HasKey(tc => new { tc.CourseId, tc.TeacherId });

            builder.Entity<TeacherCourse>()
                .HasOne(tc => tc.Teacher)
                .WithMany(t => t.TeacherCourses)
                .HasForeignKey(tc => tc.TeacherId);

            builder.Entity<TeacherCourse>()
                .HasOne(tc => tc.Course)
                .WithMany(c => c.TeacherCourses)
                .HasForeignKey(tc => tc.CourseId);

            // Configuring many-to-many relationship
            // (Course - Speciality)
            builder.Entity<CourseSpeciality>()
                .HasKey(cs => new { cs.SpecialityId, cs.CourseId });

            builder.Entity<CourseSpeciality>()
                .HasOne(cs => cs.Course)
                .WithMany(c => c.CourseSpecialities)
                .HasForeignKey(cs => cs.CourseId);

            builder.Entity<CourseSpeciality>()
                .HasOne(cs => cs.Speciality)
                .WithMany(s => s.CourseSpecialities)
                .HasForeignKey(cs => cs.SpecialityId);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<CourseSpeciality> CourseSpecialities { get; set; }
        public DbSet<TakenCourseStudent> TakenCourseStudents { get; set; }
        public DbSet<CurrentCourseStudent> CurrentCourseStudents { get; set; }
    }
}