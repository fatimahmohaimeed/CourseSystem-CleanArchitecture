using Course.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Application
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Coursee CreateCourse(Coursee course)
        {
            _courseRepository.CreateCourse(course);
            return course;
        }
        public List<Coursee>GetAllCourses()
        {
            var courseList = _courseRepository.GetAllCourses();
            return courseList;
        }
    }
}
