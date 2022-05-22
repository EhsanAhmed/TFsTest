using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_assi.Models
{
    public class Instractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Salary { get; set; }

        public string Address { get; set; }
        [ForeignKey ("Course")]
        public int Course_ID { get; set; }
        [ForeignKey("department")]
        public int Dept_ID { get; set; }
        public virtual Department department { get; set; }
        public virtual Course Course { get; set; }



    }
}
