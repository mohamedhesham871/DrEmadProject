using DataAccessLayer.DbContexts;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repo
{
    public class StudentRepo :  IStudentRepo
    {
        private readonly ApplicationDbContext Context;

        public StudentRepo(ApplicationDbContext _Context)
        {
            Context = _Context;
        }

        public IEnumerable<Student> GetAll()
        {
            return Context.Students.ToList();
        }

        public Student? GetById(int id)
        {
            return Context.Students.Find(id);
        }

        public int Add(Student model)
        {
            Context.Students.Add(model);
            return Context.SaveChanges();
        }

        public int Delete(Student model)
        {
            Context.Students.Remove(model);
            return Context.SaveChanges();
        }

        public int Update(Student model)
        {
            Context.Students.Update(model);
            return Context.SaveChanges();
        }
    }


}
