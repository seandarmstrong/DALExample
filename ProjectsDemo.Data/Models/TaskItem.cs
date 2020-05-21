using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsDemo.Data.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual TaskUser User { get; set; }
    }
}
