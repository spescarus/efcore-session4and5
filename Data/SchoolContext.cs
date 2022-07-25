﻿using Ef_core_Tutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef_core_Tutorial.Data
{
    public class SchoolContext :DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollments");
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}
