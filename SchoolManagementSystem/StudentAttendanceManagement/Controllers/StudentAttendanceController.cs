using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;
namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            var obj1 = new StudentAttendanceDetailsModel { StudentId=1, StudentName = "Vivek",  AttendancePercentage=90.45 };
            var obj2 = new StudentAttendanceDetailsModel { StudentId = 2, StudentName = "Mohan",  AttendancePercentage=78.55};

            return new List<StudentAttendanceDetailsModel> { obj1, obj2 };
        }
    }
}
