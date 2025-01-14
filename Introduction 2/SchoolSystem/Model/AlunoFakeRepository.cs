namespace Model;

public class AlunoFakeRepository : IRepository<Student>
{

    List<Student> students;
    public AlunoFakeRepository(){
        students.Add(new (){
            Name = "Wallace",
            Age = 21
        });
        students.Add(new (){
            Name = "Nikolas",
            Age = 21
        });
    }
  
    public List<Student> All => students;
    public void Add(Student obj)
        => this.students.Add(obj); 
}