internal class CourseRepository : ICourseRepository
{
    public Course Find(int id)
    {
        return new Course();
    }

    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}