using Microsoft.AspNetCore.Mvc;
using Day2_assi.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Day2_assi.Repository;

namespace Day2_assi.Controllers
{
    public class InstractorController : Controller
    {

        IInstractorsRepository InstractorsRepository;
        IDepartmentRepository departmentRepository;
        ICourseRepository courseRepository;
        public InstractorController(IInstractorsRepository Instr, IDepartmentRepository depar, ICourseRepository course)
        {
            InstractorsRepository = Instr;
            departmentRepository = depar;
            courseRepository = course;
        }
      //  ITI_Structur context= new ITI_Structur();
        public IActionResult Index()
        {
            List<Instractor> instractors = InstractorsRepository.GetAll();//context.instractors.ToList();
            return View("Index",instractors);
        }

        public IActionResult Details(int id)
        {
            Instractor instractor = InstractorsRepository.GetWithCourse(id); //context.instractors.Include(c => c.Course).FirstOrDefault(p => p.Id == id);
            return View("Details",instractor);
        }
        public IActionResult Edit(int id)
        {
            Instractor std = InstractorsRepository.GetById(id); //context.instractors.FirstOrDefault(s => s.Id == id);
            List<Department> deptList = departmentRepository.GetAll(); //context.Department.ToList();
            ViewData["Depts"] = deptList;
            List<Course> CourseList = courseRepository.GetAll(); //context.Courses.ToList();
            ViewData["Courses"] = CourseList;
            return View("Edit", std);
        }
        [HttpPost]
        public IActionResult SaveEdit([FromRoute] int id, Instractor newStd)
        {
            if (newStd.Name != null)
            {
                //save
                //Instractor student = context.instractors.FirstOrDefault(s => s.Id == id);
                //student.Name = newStd.Name;
                //student.Course_ID = newStd.Course_ID;
                //student.Image = newStd.Image;
                //student.Address = newStd.Address;
                //student.Dept_ID = newStd.Dept_ID;
                //student.Salary = newStd.Salary;
                //context.SaveChanges();
                InstractorsRepository.Update(id,newStd);
                return RedirectToAction("Index");
            }
            //not saved
            List<Department> deptList = departmentRepository.GetAll(); //context.Department.ToList();
            ViewData["Depts"] = deptList;
            return View("Edit", newStd);
        }

        public IActionResult New()
        {
            List<Department> deptList = departmentRepository.GetAll(); //context.Department.ToList();
            ViewData["Depts"] = deptList;
            List<Course> CourseList = courseRepository.GetAll(); //context.Courses.ToList();
            ViewData["Courses"] = CourseList;
            return View(new Instractor());//view=New &model=null
        }
        //Save db 
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult SaveNEw(Instractor inst)
        {
            if (inst.Name != null && inst.Name != null)
            {
                //context.instractors.Add(inst);
                //context.SaveChanges();
                InstractorsRepository.Insert(inst);

                return RedirectToAction("Index");//, new{id=5,name="asd" });
            }
            return View("New", inst);
        }
    }
}
