using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Application.Common
{
    public class TaskDto
    {
        public string? TaskId { get; set; }
        public string? TaskTitle { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int TaskPriority { get; set; }
        public TaskState State { get; set; }
    }

    public enum TaskState
    {
        Completed,
        Postponed,
        NotCompleted,
        Deleted
    }
}
