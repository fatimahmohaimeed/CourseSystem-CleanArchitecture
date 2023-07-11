using Course.Domain;


namespace Course.Application
{
    //This is a use case
    public interface ICourseService
    {
        List<Coursee> GetAllCourses();
        Coursee CreateCourse(Coursee course);
    }
}
