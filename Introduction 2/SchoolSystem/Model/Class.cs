using System.Text;
using DataBase;
namespace Model;

public class Class : DataBaseObject
{

    public string UUID { get; private set; }

    public string Name { get; set; }
    public List<string> subjects_id { get; set; }

    public List<string> students_id { get; set; }

    public Class(){
        this.UUID = Guid.NewGuid().ToString() + "cla";
    }
    protected override void LoadFrom(string[] data)
    {
        System.Console.WriteLine("ta passando aqui2");
        this.UUID = data[0];
        this.Name = data[1];
        for (int i = 2; i < data.Length; i++)
        {
            if (data[i].Substring(data[i].Length - 3) == "stu")
                students_id.Add(data[i]);

            else
                subjects_id.Add(data[i]);
        }
    }
    protected override string[] SaveTo()
      => new string[]
    {
        this.UUID,
        this.Name,
        string.Join(",", students_id),
        string.Join(",", subjects_id)
    };
}