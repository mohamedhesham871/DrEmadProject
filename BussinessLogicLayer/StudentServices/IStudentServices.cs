using BussinessLogicLayer.StudentDtos;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.StudentServices
{
    public interface IStudentServices
    {
        public IEnumerable<Student> GetAllStudents();
		public StudentDto? GetStudentById(int id);
		public int AddStudent(StudentDto student);
		public int UpdateStudent(int id, StudentDto student);
		public bool DeleteStudent(int id);
	}
}
