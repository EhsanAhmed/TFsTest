using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_assi.Models
{
    public class CourseResult
    {
        public int ID { get; set; }

        [ForeignKey("Course")]
        public int Course_id { get; set; }

        [ForeignKey("Trainee")]
        public int Trainee_id { get; set; }

        public int Degree { get; set; }
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }

    }
}
