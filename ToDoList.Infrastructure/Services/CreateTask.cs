using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;
using ToDoList.Application.TaskServices;
using ToDoList.Domain.Entities;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Infrastructure.Services
{
    public class CreateTask : ICreateTask
    {
        private readonly Context _context;

        public CreateTask(Context context)
        {
            _context = context;
        }

        public ResultDto Create(TaskDto task)
        {
            Task taskToCreate = new Task()
            {
                TaskId = Guid.NewGuid().ToString(),
                TaskTitle = task.TaskTitle,
                Created = DateTime.Now,
                State = task.State.ToString(),
                TaskPriority = task.TaskPriority
            };

            _context.Tasks.Add(taskToCreate);

            int stateChanges=_context.SaveChanges();

            if(stateChanges > 0)
            {
                return new ResultDto(true, TaskResults.Created);
            }
            else
            {
                return new ResultDto(false,TaskResults.DatabaseError);
            }
        }
    }
}
