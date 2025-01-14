using games;
public static class Program{
     static void Main(string[]args){
        Game newGame = new(0);
        Console.WriteLine("Press Space to Start");
        newGame.rungame();
    }
}