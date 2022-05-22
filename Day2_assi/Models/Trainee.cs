namespace Day2_assi.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Grade { get; set; }

        public string Address { get; set; }
        public Department department { get; set; }
    }
}
