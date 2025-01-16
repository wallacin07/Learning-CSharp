using DataBase;
namespace Model;

public class Subject : DataBaseObject
{

    public string UUID { get; private set; }
    public string Name { get; set; }

    public string teacher_id { get; set; }

    public Subject(){
        this.UUID = Guid.NewGuid().ToString() + "sub";
    }
    protected override void LoadFrom(string[] data)
    {
        this.UUID = data[0];
        this.Name = data[1];
        this.teacher_id = data[2];
    }

    protected override string[] SaveTo()
    => new string[]
    {
        this.UUID,
        this.Name,
        this.teacher_id.ToString()
    };
}