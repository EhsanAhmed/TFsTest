using Day2_assi.Models;
using System.Collections.Generic;

namespace Day2_assi.Repository
{
    public interface IInstractorsRepository
    {
        int Delete(int id);
        List<Instractor> GetAll();
        Instractor GetById(int id);
        int Insert(Instractor inst);
        int Update(int id, Instractor inst);
        Instractor GetWithCourse(int id);
    }
}