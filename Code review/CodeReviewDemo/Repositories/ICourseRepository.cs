internal interface ICourseRepository
{
    Course Find(int id);
    Task SaveAsync();
    
}