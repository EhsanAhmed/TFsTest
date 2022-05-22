using Day2_assi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_assi.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        ITI_Structur context;//= new ITIEntitiy();
        public DepartmentRepository(ITI_Structur _context)
        {
            context= _context;
        }
        public DepartmentRepository()
        {
            id = Guid.NewGuid();
        }
        public Guid id { get ; set ; }

        public List<Department> GetAll()
        {
            return context.Department.ToList();
        }

        public Department GetById(int id)
        {
            return context.Department.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Department dept)
        {
            context.Department.Add(dept);
            return context.SaveChanges();
        }

        public int Update(int id, Department dept)
        {
            Department oldDept = GetById(id);
            if (oldDept != null)
            {
                oldDept.Name = dept.Name;
                oldDept.Manager = dept.Manager;
                return context.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {
            Department oldDept = GetById(id);
            context.Department.Remove(oldDept);
            return context.SaveChanges();
        }
    }
}
