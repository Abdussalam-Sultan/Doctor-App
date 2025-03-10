using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class TaskAssignment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
