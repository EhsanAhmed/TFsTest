using System.Collections.Generic;

namespace Day2_assi.Models
{
    public class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Manager { get; set; }
        public virtual ICollection<Trainee> trainee { get; set; }
        public virtual ICollection<Instractor> Instractors { get; set; }
        public virtual ICollection<Course>  Courses { get; set; }



    }
}
