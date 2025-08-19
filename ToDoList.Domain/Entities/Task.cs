using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Entities
{
    public class Task:Base
    {
        public string TaskId { get; set; }
        public string TaskTitle { get; set; }
        public int TaskPriority { get; set; }
        public string State { get; set; }
    }
}
