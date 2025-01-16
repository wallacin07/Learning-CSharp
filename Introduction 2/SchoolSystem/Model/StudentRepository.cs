
using DataBase;

namespace Model;

public class StudentRepository : IRepository<Student>
{
    DB<Student> dbStudent = DB<Student>.App;
    public List<Student> All => dbStudent.All;

    public void Add(Student obj)
    {
        var studentList = All;
        studentList.Add(obj);
        dbStudent.Save(studentList);
    }
}