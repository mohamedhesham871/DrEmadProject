using BussinessLogicLayer.StudentDtos;
using BussinessLogicLayer.StudentServices;
using Microsoft.AspNetCore.Mvc;

namespace PresntationLayer.Controllers
{
	public class StudentController(IStudentServices _studentServices) : Controller
	{
        // IStudentServices _studentServices  [USing Dependency Injection]
        public IActionResult Index()
		{
			var Students = _studentServices.GetAllStudents();
			return View(Students);
		}
		#region Create[GET, POST]
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
        public IActionResult Create(StudentDto student)
        {
			if(ModelState.IsValid)
			{
				var CreateStudent = _studentServices.AddStudent(student);
				if(CreateStudent > 0)
                    return RedirectToAction("Index");
                else
					ModelState.AddModelError("", "Failed to create student");


            }
            return View(student);
        }
        #endregion


        #region Details [Get]
        public IActionResult Details(int? id)
        {
			if (!id.HasValue) return BadRequest();
			var Student = _studentServices.GetStudentById(id.Value);
			if (Student is null) return NotFound();
			var StudentDetails = new StudentDetails
			{
				Id= id.Value,
				Name = Student.Name,
				Age = Student.Age,
				Email= Student.Email,
				Course=Student.Course

			};
            return View(StudentDetails);
        }
        #endregion
        #region Edit [GET, POST]
        [HttpGet]
		public IActionResult Edit(int? id)
		{
			if (!id.HasValue) return BadRequest();
			var Student = _studentServices.GetStudentById(id.Value);
			if (Student is null) return NotFound();
			
			return View(Student);
		}
		[HttpPost]
		public IActionResult Edit([FromRoute]int id,StudentDto studentDto)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var EditStudent = _studentServices.UpdateStudent(id, studentDto);

					if (EditStudent > 0) return RedirectToAction("Index");
					else
					{
						ModelState.AddModelError("", "Error Try Again");
					}
				}
				catch(Exception ex)
				{
					ModelState.AddModelError("", "Error Try Again");
                }

            }
			return View(studentDto);
		}
		#endregion

		#region Delete [GEt]
		public IActionResult Delete(int? id)
		{
			if(!id.HasValue) return BadRequest();
            var Student = _studentServices.GetStudentById(id.Value);
            if (Student is null) return NotFound();
            var res =_studentServices.DeleteStudent(id.Value);

			if(res)
            return RedirectToAction("Index");
			 else
                return NotFound();

        }
		#endregion


	}
}
