using System.Reflection.Metadata;
using  DataBase.Exceptions;

namespace DataBase;

public class DB<T>
    where T : DataBaseObject, new()
{
    private string basePath;

    private DB(string basePath)
    => this.basePath = basePath;

    public string DBPath
    {
        get
        {
            var filename = typeof(T).Name;
            var path = this.basePath + filename + ".csv";
            return path;
        }
    }

    public List<string> openFIle()
    {
        List<string> lines = new();
        StreamReader reader = null;
        var path = this.DBPath;
        if (!File.Exists(path))
        {
            File.Create(path).Close();
        }
        try
        {
            reader = new StreamReader(path);
            while (!reader.EndOfStream)
                lines.Add(reader.ReadLine());
        }
        catch
        {
            lines = null;
        }
        finally
        {
            reader?.Close();
        }
        return lines;
    }

    private bool saveFile(List<string> lines)
    {
        StreamWriter writer = null;
        bool sucess = true;
        var path = this.DBPath;

        if (!File.Exists(path))
            File.Create(path).Close();

        try
        {
            writer = new StreamWriter(path);
            for (int i = 0; i < lines.Count; i++)
            {
                var line = lines[i];
                writer.WriteLine(line);
            }
        }
        catch
        {

            sucess = false;
        }
        finally
        {
            writer.Close();
        }
        return sucess;

    }

    public List<T> All
    {
        get
        {


            var lines = openFIle();
            if (lines is null)
                throw new DataCannotBeOpenedException(this.DBPath);
            var all = new List<T>();

            try
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    var line = lines[i];
                    var obj = new T();
                    var data = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    obj.LoadFrom(data);
                    all.Add(obj);
                }

            }
            catch
            {
                throw new ConvertObjectException();
            }
            return all;
        }
    }

    public void Save(List<T> all){

        List<string> lines= new List<string>();
        for (int i = 0; i < all.Count; i++)
        {
            var data = all[i].SaveTo();
            string line = string.Empty;

            for (int j = 0; i < data.Length; i++)
                line += data[j] + ",";
    
            lines.Add(line);
        }

        if (saveFile(lines))
            return;

        throw new DataCannotBeOpenedException(this.DBPath);
    }

    private static DB<T> temp = null;

    public static DB<T> Temp{

        get {

            if (temp == null)
                temp = new DB<T>(Path.GetTempPath());
            return temp;
            }
    }

    private static DB<T> app = null;

    public static DB<T> App{

        get {

            if (app == null)
                app = new DB<T>(Path.GetTempPath());
            return app;
            }
    }

    public static DB<T> custom = null;

    public static DB<T> Custom{
        get {

            if (custom == null)
                throw new CustomNotDefinedException();
                return custom;
        }

    }

    public static void SetCustom(string path)
        => custom = new DB<T>(path);   
}