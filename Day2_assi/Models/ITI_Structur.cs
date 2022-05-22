using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Day2_assi.Models
{
    public class ITI_Structur: DbContext
    {
        public ITI_Structur():base()
        {

        }
        public ITI_Structur (DbContextOptions options):base(options)
        {

        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseResult> CourseResults { get; set; }
        public DbSet<Instractor> instractors { get; set; }
        public DbSet<Trainee> trainees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Intake42Assiut;Integrated Security=True");
        }
    }
}
