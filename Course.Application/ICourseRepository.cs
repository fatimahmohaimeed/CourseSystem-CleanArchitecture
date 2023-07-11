using Course.Domain;

namespace Course.Application
{
    // will be concerned with data access
    public interface ICourseRepository
    {
        List<Coursee> GetAllCourses();
        Coursee CreateCourse(Coursee course);

    }
}
