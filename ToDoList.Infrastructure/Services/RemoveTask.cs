using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;
using ToDoList.Application.TaskServices;

namespace ToDoList.Infrastructure.Services
{
    public class RemoveTask : IRemoveTask
    {
        private readonly Context _context;

        public RemoveTask(Context context)
        {
            _context = context;
        }

        public ResultDto Remove(string taskId)
        {
            var taskToRemove = _context.Tasks.Find(taskId);
            if (taskToRemove == null) return new ResultDto(false, TaskResults.NotFound);

            _context.Tasks.Remove(taskToRemove);

            var stateChanges = _context.SaveChanges();
            if (stateChanges > 0)
                return new ResultDto(true, TaskResults.RemoveFromDatabase);
            else
                return new ResultDto(false, TaskResults.NotFound);
        }
    }
}
