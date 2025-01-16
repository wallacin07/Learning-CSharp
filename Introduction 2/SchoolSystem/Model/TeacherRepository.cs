using DataBase;

namespace Model;

public class TeacherRepository : IRepository<Teacher>
{

    DB<Teacher> dbTeacher = DB<Teacher>.App;

    public List<Teacher> All => dbTeacher.All;
    public void Add(Teacher obj)
    {
        var teacherList = All;
        teacherList.Add(obj);
        dbTeacher.Save(teacherList);
    }
}