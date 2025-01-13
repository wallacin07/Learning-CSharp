
namespace games;
public class Game(int? moneyStart)
{

    Player player = new(moneyStart, 0, 0);
    public void rungame()
    {
        while (true)
        {
            GetMoney();
        }
    }

    public void GetMoney()
    {
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        {
            Console.Clear();
            player.moneyOwned = player.moneyOwned + 1;
            Console.WriteLine("Money owned: " + player.moneyOwned);
            Console.WriteLine("Press B to open the Store");
        }

        if (Console.ReadKey().Key == ConsoleKey.B)
        {
            Menu menu = new(player);
            menu.PrintStore();

        }

    }

}