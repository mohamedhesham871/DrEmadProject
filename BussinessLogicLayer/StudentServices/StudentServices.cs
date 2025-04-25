using BussinessLogicLayer.StudentDtos;
using DataAccessLayer.Models;
using DataAccessLayer.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.StudentServices
{
    public  class StudentServices(IStudentRepo _studentRepo) : IStudentServices
    {
        // IStudentRepo _studentRepo  [USing Dependency Injection]

        //List All Student 
        public IEnumerable<Student> GetAllStudents()
        {
            var Students = _studentRepo.GetAll();
            
            return Students;
        
         }
        //Get Student By ID
        public StudentDto? GetStudentById(int id)
        {
            var Students = _studentRepo.GetById(id);
            if (Students == null) return null;

            var StudentDetails = new StudentDetails()
            {
               Id = Students.Id,
                Name = Students.Name,
                Age = Students.Age,
                Email = Students.Email,
                Course = Students.Course
            };
            return StudentDetails;
        }
        //Create New Student
        public int AddStudent(StudentDto student)
        {
            var NewStudent = new Student()
            {
                Name = student.Name,
                Age = student.Age,
                Email = student.Email,
                Course = student.Course

            };
           
            return _studentRepo.Add(NewStudent);
        }

        //Update Student Details
        public int UpdateStudent(int id, StudentDto student)
        {

            var UpdatedStudent = new Student()
            {
                Id = id,
                Name = student.Name,
                Age = student.Age,
                Email = student.Email,
                Course = student.Course
            };
            return _studentRepo.Update(UpdatedStudent);
        }
        //Delete Student 
        public bool DeleteStudent(int id)
        {

            if (id == 0) return false;

            var student = _studentRepo.GetById(id);
            if (student == null) return false;

            else
            {
                var res =_studentRepo.Delete(student);
                return res > 0 ? true : false;
            }
        }



    }
}
