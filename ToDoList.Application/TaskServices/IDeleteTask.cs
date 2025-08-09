using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;

namespace ToDoList.Application.TaskServices
{
    public interface IDeleteTask
    {
        /// <summary>
        /// Move the task to deleted section, so then it could be restored.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        ResultDto Delete(string taskId);
    }
}
