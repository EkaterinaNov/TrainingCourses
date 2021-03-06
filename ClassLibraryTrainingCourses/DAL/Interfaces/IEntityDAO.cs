using ClassLibraryTrainingCourses.DAL.Entities;
using System.Collections.Generic;

namespace ClassLibraryTrainingCourses.DAL.Interfaces
{
    public interface IEntityDAO<T> where T : Entity
    {
        List<T> GetAllByOrder();
        void Add(T t);
        void Update(int id, T t);
        void Delete(int id);
    }
}
