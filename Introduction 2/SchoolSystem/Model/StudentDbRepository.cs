using DataBase;
using Model;

public class StudentDbRepository : IRepository<Student>
{
    protected DBSqlSrv<Student> db;

    public StudentDbRepository()
    {
        db = new DBSqlSrv<Student>(
       "CA-C-0065H/SQLEXPRESS",
       "CSharp"
   );
    }
    public List<Student> All => db.All;

    public void Add(Student obj)
    {
        db.Save(obj);
    }
}
