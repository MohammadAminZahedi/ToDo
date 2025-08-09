using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Application.Common
{
    public class ResultDto
    {
        public bool State { get; set; }
        public TaskResults Comment { get; set; }

        public ResultDto(bool state, TaskResults comment)
        {
            State = state;
            Comment = comment;
        }
    }

    public enum TaskResults
    {
        Created,
        Updated,
        Deleted,
        PriorityChanged,
        StateChanged,
        DatabaseError,
        NotFound,
        RemoveFromDatabase,
        Restored
    }
}
