using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;
using ToDoList.Application.TaskServices;

namespace ToDoList.Infrastructure.Services
{
    public class EditTask : IEditTask
    {
        private readonly Context _context;

        public EditTask(Context context)
        {
            _context = context;
        }

        public ResultDto Edit(TaskDto task)
        {
            var foundTask = _context.Tasks.Find(task.TaskId);
            if (foundTask == null) return new ResultDto(false, TaskResults.NotFound);

            foundTask.TaskTitle = task.TaskTitle;
            foundTask.TaskPriority = task.TaskPriority;

            var stateChanges = _context.SaveChanges();

            if (stateChanges > 0)
                return new ResultDto(true, TaskResults.Updated);
            else
                return new ResultDto(false,TaskResults.DatabaseError);
        }
    }
}
