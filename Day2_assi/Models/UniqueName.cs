using Day2_assi.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApplication2.Models
{
    public class UniqueName: ValidationAttribute
    {
        public string Msg { get; set; }
        ITI_Structur context = new ITI_Structur();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //Student allStudent= (Student)validationContext.ObjectInstance;
            //if(value != null)
            Course course = context.Courses.FirstOrDefault(s => s.Name == value.ToString());
            if (course == null)
                return ValidationResult.Success;//valid
            return new ValidationResult("Name Already Exists");

        }
    }
}
