using Day2_assi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_assi.Repository
{
    public class CourseRepository : ICourseRepository
    {
        ITI_Structur context;//= new ITIEntitiy();
        public CourseRepository(ITI_Structur _context)
        {
            context = _context;
        }
        public List<Course> GetAll()
        {
            return context.Courses.ToList();
        }

        public Course GetById(int id)
        {
            return context.Courses.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Course inst)
        {
            context.Courses.Add(inst);
            return context.SaveChanges();
        }

        public int Update(int id, Course course)
        {
            Course oldcourse = GetById(id);
            if (course != null)
            {
                oldcourse.Name = course.Name;
                oldcourse.Degree = course.Degree;
                oldcourse.Dept_ID = course.Dept_ID;
                oldcourse.department = context.Department.FirstOrDefault(d => d.Id == course.Dept_ID);
                return context.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {
            Course oldcorse = GetById(id);
            context.Courses.Remove(oldcorse);
            return context.SaveChanges();
        }
    }
}
