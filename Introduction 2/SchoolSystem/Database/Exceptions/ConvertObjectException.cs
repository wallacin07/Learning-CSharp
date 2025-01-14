namespace DataBase.Exceptions;

public class ConvertObjectException : Exception
{
    public override string Message => """Algum elemento do banco esta mal formatado e nao pode ser convertido""";
}