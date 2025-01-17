using System.Data;
using DataBase;
namespace Model;

public class Student : DataBaseObject
{

    public string UUID { get; private set; }
    public string Name { get; set; }

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

    protected override void LoadFromSqlRow(DataRow data)
    {
        this.UUID = data[0].ToString();
        this.Name = data[1].ToString();
        this.Age= int.Parse(data[2].ToString());
    }

    protected override string SaveToSql()
    => $"INSERT INTO [Student] VALUES ('{UUID}', '{Name}' {Age})";
}