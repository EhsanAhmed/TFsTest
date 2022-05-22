using Day2_assi.Models;
using Day2_assi.View_Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Day2_assi.Controllers
{
    public class TraineeController : Controller
    {
        ITI_Structur context = new ITI_Structur();
        public IActionResult SetCookie()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddDays(1);
            Response.Cookies.Append("name", "Assiut");//session cookie
            Response.Cookies.Append("Department", "SD", cookieOptions);//persisiten cookie
            return Content("Cookie saved");

        }
        public IActionResult getCookie()
        {
            string name = Request.Cookies["name"];
            return Content($"Cookie {name}");

        }

        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("name", "Intake42");
            HttpContext.Session.SetInt32("age", 22);
            return Content("session saved");

        }

        public IActionResult GetSession()
        {
            string name = HttpContext.Session.GetString("name");
            int age = HttpContext.Session.GetInt32("age").Value;
            return Content($"Get from Session {name}  {age}");
        }
        public IActionResult Index(int id)
        {
            CourseResult courseResult = context.CourseResults.Where(t => t.Trainee_id == id && t.Course_id == 1)
                                      .Include(trainee => trainee.Trainee)
                                      .Include(c => c.Course).FirstOrDefault();
                                      
            Trainee trainee = courseResult.Trainee;
            Course course = courseResult.Course;

            TraineeListViewModel traineeVM = new TraineeListViewModel();
            traineeVM.TrianeeName = trainee.Name;
            traineeVM.CouresName = course.Name;
            traineeVM.CoureDegree = courseResult.Degree;

            if (traineeVM.CoureDegree < int.Parse(course.MinDegree))
            {
                traineeVM.Color = "red";
                traineeVM.CourseState = "Failler";
            }
            else
            {
                traineeVM.Color = "green";
                traineeVM.CourseState = "Success";
            }



            return View("Index", traineeVM);
        }
    }
}
