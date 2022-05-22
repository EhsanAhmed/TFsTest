using Day2_assi.Models;
using System.Collections.Generic;

namespace Day2_assi.Repository
{
    public interface ICourseRepository
    {
        int Delete(int id);
        List<Course> GetAll();
        Course GetById(int id);
        int Insert(Course inst);
        int Update(int id, Course course);
    }
}