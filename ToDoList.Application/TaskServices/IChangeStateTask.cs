using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Common;

namespace ToDoList.Application.TaskServices
{
    public interface IChangeStateTask
    {
        ResultDto ChangeState(string taskId,TaskState state);
    }
}
