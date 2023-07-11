using Course.Application;
using Course.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Infrastructure
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CourseDbContext _courseDbContext;

        public CourseRepository(CourseDbContext courseDbContext)
        {
            _courseDbContext = courseDbContext;
        }
        public Coursee CreateCourse(Coursee course) 
        {
            _courseDbContext.Courses.Add(course);
            _courseDbContext.SaveChanges();
            return course;
        }
        public List<Coursee>GetAllCourses()
        {
            return _courseDbContext.Courses.ToList();
        }
    }
}
