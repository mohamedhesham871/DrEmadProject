using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.StudentDtos
{
	public class StudentDto
	{
	   // public int Id { get; set; }  User Can't Set ID  
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
		[MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
		public string Name { get; set; } = null!;
		[DataType(DataType.EmailAddress)]
		[EmailAddress(ErrorMessage = "Invalid email address")]
		public string Email { get; set; } = null!;
		[Required(ErrorMessage = "Age is required")]
		[Range(18, 32, ErrorMessage = "Age must be between 18 and 32")]
		public int Age { get; set; }
        public string? Course { get; set; } = null!;
    }
}
