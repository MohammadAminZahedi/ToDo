using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Mapping;

namespace ToDoList.Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; initial catalog=Test_ToDoListDB; integrated security=true; trust server certificate = true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
