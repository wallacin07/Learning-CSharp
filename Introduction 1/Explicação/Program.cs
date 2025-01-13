using System.Globalization;
using System.Text.RegularExpressions;
using NewSystem;
public static class Program{
    public static void Main(string[] args){
        
        // string a = "a";
        // string b = "a";
        // NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;

        // Console.WriteLine(Regex.Match(a,b).Success);
        // Pessoa Irineu = new Pessoa("Irineu");
        // Console.WriteLine(100_000.00F.ToString("C2"));
        // Console.WriteLine(Irineu.Name);

        var a = NewConsole.readLineInt();
        NewConsole.Print("Tecla Pressionada: " + a);
        var b = NewConsole.readLineInt();
        NewConsole.Print("Tecla Pressionada: " + a);

        if(a is null || b is null){
            NewConsole.Print("algum numero invalido");
        }
        else
            NewConsole.Print(a + b);        

    }
}
