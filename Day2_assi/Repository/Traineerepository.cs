using Day2_assi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_assi.Repository
{
    public class Traineerepository : ITraineerepository
    {
        ITI_Structur context;//= new ITIEntitiy();
        public Traineerepository(ITI_Structur _context)
        {
            context = _context;
        }
        public List<Trainee> GetAll()
        {
            return context.trainees.ToList();
        }

        public Trainee GetById(int id)
        {
            return context.trainees.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Trainee trainee)
        {
            context.trainees.Add(trainee);
            return context.SaveChanges();
        }

        public int Update(int id, Trainee trainee)
        {
            Trainee oldtrainee = GetById(id);
            if (trainee != null)
            {
                oldtrainee.Name = trainee.Name;
                oldtrainee.Image = trainee.Image;
                oldtrainee.Grade = trainee.Grade;
                oldtrainee.Address = trainee.Address;
                oldtrainee.department = trainee.department;
                return context.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {
            Trainee oldtrainee = GetById(id);
            context.trainees.Remove(oldtrainee);
            return context.SaveChanges();
        }
    }
}
