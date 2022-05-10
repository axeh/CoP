// See https://aka.ms/new-console-template for more information
internal class CourseRepository : ICourseRepository
{
    public Course Find(int id)
    {
        return new Course();
    }

    public Task SaveAsync()
    {
       return Task.CompletedTask;
    }
}