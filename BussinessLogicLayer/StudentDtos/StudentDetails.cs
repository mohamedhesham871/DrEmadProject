using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.StudentDtos
{
    public class StudentDetails:StudentDto
    {
        //Contain ID To Make User Can See ID
        // I make Protection For ID
        public int Id { get; set; }
    }
}
