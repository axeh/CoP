internal class CourseService
{
    private readonly ICourseRepository courseRepository;

    public CourseService(ICourseRepository courseRepository)
    {
        this.courseRepository = courseRepository;
    }

    public async Task Add(int id, Student student)
    {
        if (id <= 0)
        {
            throw new ArgumentException(null, nameof(id));
        }

        if (student == null)
        {
            throw new ArgumentNullException(nameof(student));
        }

        var c = courseRepository.Find(id);

        if (c.Students.Any(x => x.Id == student.Id))
        {
            throw new ArgumentException("Student already is enrolled for course.");
        }

        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync("/check-student/" + id);
        response.EnsureSuccessStatusCode();

        c.Students.Add(student);
        await courseRepository.SaveAsync();
    }
}
