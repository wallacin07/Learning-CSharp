namespace DataBase.Exceptions;

public class CustomNotDefinedException : Exception{
    public override string Message => "O arquivo custom não esta definido corretamente";
}