using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;
using ToDoList.Application.TaskServices;

namespace ToDoList.Infrastructure.Services
{
    public class GetTasks : IGetTasks
    {
        private readonly Context _context;

        public GetTasks(Context context)
        {
            _context = context;
        }

        public IEnumerable<TaskDto> GetTasksByState(TaskState state)
        {
            var tasks = _context.Tasks
                .Where(t => t.State == state.ToString() && t.IsDeleted == false)
                .Select(t => new TaskDto()
                {
                    TaskId = t.TaskId,
                    TaskTitle = t.TaskTitle,
                    TaskDescription = t.TaskDescription,
                    Created = t.Created,
                    Modified = t.Modified,
                    State=Enum.Parse<TaskState>(t.State),
                    TaskPriority = t.TaskPriority
                })
                .AsNoTracking();

            return tasks;

        }
    }
}
