using Microsoft.AspNetCore.Mvc;
using Day2_assi.Models;
using Day2_assi.View_Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Day2_assi.Controllers
{
    public class CourseResultController : Controller
    {
        ITI_Structur context =new ITI_Structur();
        public IActionResult Index(int id)
        {
            var courseResult = context.CourseResults.Where(c => c.Course_id == id)
                                        .Include(trainee => trainee.Trainee)
                                        .Include(c => c.Course);
            List<CourseResultViewModel> model= new List<CourseResultViewModel>();  
            foreach (var CR in courseResult)
            {
                CourseResultViewModel modelItem = new CourseResultViewModel();
                modelItem.StudentName = CR.Trainee.Name;
                modelItem.CourseName= CR.Course.Name;
                modelItem.Degree = CR.Degree;
                if (modelItem.Degree < int.Parse(CR.Course.MinDegree))
                {
                    modelItem.CourseStatus = "Failler";
                    modelItem.Color = "Red";
                }
                else
                {
                    modelItem.CourseStatus = "Success";
                    modelItem.Color = "green";
                }
                model.Add(modelItem);
               
            }                           

            return View("Index", model);
        }
    }
}
