using Day2_assi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_assi.Repository
{
    public class InstractorsRepository : IInstractorsRepository
    {
        ITI_Structur context;  //= new ITI_Structur();
        public InstractorsRepository(ITI_Structur _context)
        {
            context = _context;
        }
        public List<Instractor> GetAll()
        {
            return context.instractors.ToList();
        }

        public Instractor GetById(int id)
        {
            return context.instractors.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Instractor inst)
        {
            context.instractors.Add(inst);
            return context.SaveChanges();
        }

        public int Update(int id, Instractor inst)
        {
            Instractor oldinst = GetById(id);
            if (oldinst != null)
            {
                oldinst.Name = inst.Name;
                oldinst.Address = inst.Address;
                oldinst.Course_ID = inst.Course_ID;
                oldinst.Dept_ID = inst.Dept_ID;
                oldinst.Image = inst.Image;
                oldinst.Salary = inst.Salary;

                return context.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {
            Instractor oldDept = GetById(id);
            context.instractors.Remove(oldDept);
            return context.SaveChanges();
        }
        public Instractor GetWithCourse(int id)
        {
           return context.instractors.Include(c => c.Course).FirstOrDefault(p => p.Id == id);

        }


}
}
