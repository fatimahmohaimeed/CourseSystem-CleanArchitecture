using Course.Application;
using Course.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Courses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public ActionResult<List<Coursee>> Get()
        {
            var coursesFromService = _courseService.GetAllCourses();
            return Ok(coursesFromService);
        }
        [HttpPost]
        public ActionResult<Coursee> PostCourse(Coursee course)
        {
            var Course = _courseService.CreateCourse(course);
            return Ok(Course);
        }
    }

}