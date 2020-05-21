using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsDemo.Data.Models
{
    public class TaskUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<TaskItem> Tasks { get; set; }
    }
}
