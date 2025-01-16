using DataBase;

namespace Model;

public class SubjectRepository : IRepository<Subject>
{

    DB<Subject> dbTeacher = DB<Subject>.App;

    public List<Subject> All => dbTeacher.All;
    public void Add(Subject obj)
        {
            var subjectList = All;
            subjectList.Add(obj);
            dbTeacher.Save(subjectList);
        }

  
}