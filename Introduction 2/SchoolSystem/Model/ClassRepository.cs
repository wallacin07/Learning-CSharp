using DataBase;

namespace Model;

public class ClassRepository : IRepository<Class>
{

    DB<Class> dbClass = DB<Class>.App;
    private IRepository<Subject> subjectsRepo;
    private IRepository<Student> studentsRepo;


    public ClassRepository(IRepository<Subject> subjectsRepo, IRepository<Student> studentsRepo)
    {
        this.subjectsRepo = subjectsRepo;
        this.studentsRepo = studentsRepo;
    }

    public List<Class> All => dbClass.All; 
    public void Add(Class obj)
        {
            var classList = All;
        System.Console.WriteLine("All: "+classList);
            classList.Add(obj);
            System.Console.WriteLine("ta passando aqui");
            dbClass.Save(classList);
        }
}