using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public int Age { get; set; }
		public string Email { get; set; }
	}
}
