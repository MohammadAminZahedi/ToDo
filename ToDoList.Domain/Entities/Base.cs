using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Entities
{
    public class Base
    {
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
