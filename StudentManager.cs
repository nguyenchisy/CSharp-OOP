public class StudentManager
{
    private List<Students> students;

    public StudentManager()
    {
        students = new List<Students>();
    }

    public void AddStudent(Students student)
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

    public Students GetStudent(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }

    public List<Students> GetAllStudents()
    {
        return students;
    }
}