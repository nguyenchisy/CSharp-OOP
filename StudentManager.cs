public class StudentManager
{
    private List<Student> students;

    public StudentManager()
    {
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void RemoveStudent(int id)
    {
        var studentToRemove = students.FirstOrDefault(s => s.Id == id);
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
        }
    }

    public Student GetStudent(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }
}