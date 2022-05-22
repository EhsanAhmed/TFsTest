using Day2_assi.Models;
using System;
using System.Collections.Generic;

namespace Day2_assi.Repository
{
    public interface IDepartmentRepository
    {
        Guid id { get; set; }
        int Delete(int id);
        List<Department> GetAll();
        Department GetById(int id);
        int Insert(Department dept);
        int Update(int id, Department dept);
    }
}