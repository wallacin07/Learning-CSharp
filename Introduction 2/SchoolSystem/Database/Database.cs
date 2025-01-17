namespace DataBase;

public abstract class Database<T>
{

    private string basePath;

    public string DBPath;

    public List<T> All;

    protected static Database<T> app = null;

    protected abstract List<string> openFIle();

    protected abstract bool saveFile(List<string> lines);

    public abstract void Save(List<T> all);
}