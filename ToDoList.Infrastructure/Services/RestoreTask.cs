using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;
using ToDoList.Application.TaskServices;

namespace ToDoList.Infrastructure.Services
{
    public class RestoreTask : IRestoreTask
    {
        private readonly Context _context;

        public RestoreTask(Context context)
        {
            _context = context;
        }

        public ResultDto Restore(string taskId)
        {
            var foundTask = _context.Tasks.Find(taskId);
            if (foundTask == null) return new ResultDto(false, TaskResults.NotFound);

            foundTask.IsDeleted = false;

            var stateChanges = _context.SaveChanges();

            if (stateChanges > 0)
                return new ResultDto(true, TaskResults.Restored);
            else
                return new ResultDto(false, TaskResults.DatabaseError);
        }
    }
}
