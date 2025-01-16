using DataBase;
namespace Model;

public class Student : DataBaseObject
{

    public string? UUID { get; private set; }
    public string? Name { get; set; }

    public int? Age{ get; set; }

    public Student(){
        this.UUID = Guid.NewGuid().ToString() + "stu";
    }
    protected override void LoadFrom(string[] data)
    {
        this.UUID = data[0];
        this.Name = data[1];
        this.Age = int.Parse(data[2]);
    }

    protected override string[] SaveTo()
    => new string[]
    {
        this.UUID,
        this.Name,
        this.Age.ToString()
    };
}