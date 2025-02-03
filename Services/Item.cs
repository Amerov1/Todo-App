using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618
namespace BlazorApp_Mon_.Services
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Unkown";
        public string Description { get; set; } = string.Empty;
        public Priority _priority { get; set; } = Priority.Low;

        public List<SubToDo> subTodo { get; set; } = new List<SubToDo>();
        public bool IsDone { get; set; } = false;
        public DateTime? DeadLine { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
