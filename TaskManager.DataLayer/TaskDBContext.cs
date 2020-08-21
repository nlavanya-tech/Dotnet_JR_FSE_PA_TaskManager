using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.DataLayer
{
   public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> dbContextOptions)
            : base(dbContextOptions)
        {
           
        }
        /// <summary>
        //    /// Creating DbSet for Table
        //    /// </summary>
        public DbSet<TaskGroup> taskGroups { get; set; }
        public DbSet<TaskItem>  taskItems { get; set; }
        /// <summary>
        //    /// While Model or Table creating Applaying Primary key to Table
        //    /// </summary>
        //    /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskGroup>()
                .HasKey(x => x.GroupID);
            modelBuilder.Entity<TaskItem>()
                .HasKey(x => x.TaskId);
        }
    }
}

