using Day2_assi.Models;
using System.Collections.Generic;

namespace Day2_assi.Repository
{
    public interface ITraineerepository
    {
        int Delete(int id);
        List<Trainee> GetAll();
        Trainee GetById(int id);
        int Insert(Trainee trainee);
        int Update(int id, Trainee trainee);
    }
}