using Microsoft.EntityFrameworkCore;
using ProjectsDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsDemo.Data
{
    public class ProjectsDemoContext : DbContext
    {
        public ProjectsDemoContext()
        {

        }

        public ProjectsDemoContext(DbContextOptions<ProjectsDemoContext> options) : base(options)
        {

        }

        public virtual DbSet<TaskUser> Users { get; set; }
        public virtual DbSet<TaskItem> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LAPTOP-0FFESSLQ\\SQLEXPRESS;Initial Catalog=ProjectTasks;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>()
                .HasOne<TaskUser>(e => e.User)
                .WithMany(s => s.Tasks)
                .HasForeignKey(e => e.UserId);
        }
    }
}
