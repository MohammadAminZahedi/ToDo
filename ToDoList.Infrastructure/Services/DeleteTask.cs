using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;
using ToDoList.Application.TaskServices;
using ToDoList.Domain.Entities;

namespace ToDoList.Infrastructure.Services
{
    public class DeleteTask : IDeleteTask
    {
        private readonly Context _context;

        public DeleteTask(Context context)
        {
            _context = context;
        }

        public ResultDto Delete(string taskId)
        {
            var foundTask = _context.Tasks.Find(taskId);
            if (foundTask == null) return new ResultDto(false, TaskResults.NotFound);

            foundTask.IsDeleted = true;

            var stateChanges = _context.SaveChanges();

            if (stateChanges > 0)
                return new ResultDto(true, TaskResults.Deleted);
            else
                return new ResultDto(false, TaskResults.DatabaseError);
        }
    }
}
