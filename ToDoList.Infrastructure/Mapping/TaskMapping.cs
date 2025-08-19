using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;
using ToDoList.Domain.Entities;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Infrastructure.Mapping
{
    internal class TaskMapping : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(t => t.TaskPriority).HasDefaultValue(3);
            builder.Property(t => t.State).HasDefaultValue(TaskState.ToDo.ToString());
        }
    }
}
