namespace DataBase.Exceptions;

public class DataCannotBeOpenedException : Exception{

    private string file;
    public DataCannotBeOpenedException(string file)
        => this.file = file;
    public override string Message => $" os dados não puderam ser lidos/escritos no arquivo {this.file}";
}