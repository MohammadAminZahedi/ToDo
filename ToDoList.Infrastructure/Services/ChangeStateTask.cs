using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;
using ToDoList.Application.TaskServices;

namespace ToDoList.Infrastructure.Services
{
    public class ChangeStateTask : IChangeStateTask
    {
        private readonly Context _context;

        public ChangeStateTask(Context context)
        {
            _context = context;
        }

        public ResultDto ChangeState(string taskId, TaskState state)
        {
            var foundTask = _context.Tasks.Find(taskId);
            if (foundTask == null) return new ResultDto(false, TaskResults.NotFound);

            foundTask.State = state.ToString();

            var stateChanges = _context.SaveChanges();

            if (stateChanges > 0)
                return new ResultDto(true, TaskResults.Deleted);
            else
                return new ResultDto(false, TaskResults.DatabaseError);
        }
    }
}
