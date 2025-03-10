using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    internal class Tasks
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.Threading.Tasks.TaskStatus Status { get; set; }
        public int AssignedUserId { get; set; }
    }
}
