using Microsoft.AspNetCore.Mvc;
using Day2_assi.Models;
using System.Linq;
using System.Collections.Generic;
using Day2_assi.View_Model;

namespace Demo.Controllers
{
    public class CourseController : Controller
    {
        ITI_Structur context = new ITI_Structur();

        public IActionResult New()
        {
            List<Department> DeptList = context.Department.ToList();
            ViewData["Dept"] = DeptList;
            return View(new Course());//view=New &model=null
        }
        //Save db 
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public IActionResult SaveNEw(Course cour)
        {
            if (cour.Name != null && cour.Name != null && ModelState.IsValid == true)
            {
                Course course = new Course();
                course.Name = cour.Name;
                course.Degree = cour.Degree;
                course.Dept_ID = cour.Dept_ID;
                course.department = context.Department.FirstOrDefault(d => d.Id == cour.Dept_ID);
                context.Courses.Add(course);
                context.SaveChanges();
                List<Course> courses = context.Courses.ToList();
                return View("SaveNEw",courses);//, new{id=5,name="asd" });
            }
            List<Department> DeptList = context.Department.ToList();
            ViewData["Dept"] = DeptList;
            return View("New", cour);
        }
        public IActionResult CheckDegree(int MinDegree, int Degree)
        {
           // Course course = context.Courses.FirstOrDefault(s => s.Name == Name);
            if (MinDegree > Degree)
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }
    }
}
