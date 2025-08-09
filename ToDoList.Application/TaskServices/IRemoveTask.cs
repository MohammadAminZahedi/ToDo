using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;

namespace ToDoList.Application.TaskServices
{
    public interface IRemoveTask
    {
        /// <summary>
        /// Remove task hardly from database.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        ResultDto Remove(string taskId);
    }
}
