using DataAccessLayer.Models;

namespace DataAccessLayer.Repo
{
    public interface IStudentRepo
    {
        int Add(Student model);
        int Delete(Student model);
        IEnumerable<Student> GetAll();
        Student? GetById(int id);
        int Update(Student model);
    }
}