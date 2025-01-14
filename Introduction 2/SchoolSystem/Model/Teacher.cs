using DataBase;
namespace Model;

public class Teacher : DataBaseObject
{


    public string Name { get; set; }

    public string Graduated { get; set; }


    protected override void LoadFrom(string[] data)
    {
        this.Name = data[0];
        this.Graduated = data[1];
    }

    protected override string[] SaveTo()
    => new string[]
    {
        this.Name,
        this.Graduated.ToString()
    };
}