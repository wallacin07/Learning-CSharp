using DataBase;
namespace Model;

public class Teacher : DataBaseObject
{

    public string UUID { get; private set; }
    public string Name { get; set; }

    public string Graduated { get; set; }

    public Teacher(){
        this.UUID = Guid.NewGuid().ToString() + "tea";
    }
    protected override void LoadFrom(string[] data)
    {
        this.UUID = data[0];
        this.Name = data[1];
        this.Graduated = data[2];
    }

    protected override string[] SaveTo()
    => new string[]
    {
        this.UUID,
        this.Name,
        this.Graduated
    };
}