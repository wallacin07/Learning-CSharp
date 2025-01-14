
namespace games;
public class Game(int? cookieStart)
{

    Player player = new(cookieStart, 0, 0, 0);
    public Machine vanillaCookieMachine = new(10, 1.5);
    public Machine baker = new(2000, 5);
    public Machine Furniture = new(100000, 15);
    public void rungame()
    {

        while (true)
        {
            Menu menu = new(player, vanillaCookieMachine, baker, Furniture);
            Getcookie(menu);
        }
    }

    public void Getcookie(Menu menu)
    {
        var keyPressed = Console.ReadKey().Key;
        if (keyPressed == ConsoleKey.Spacebar)
        {
            Console.Clear();
            player.cookieOwned = player.cookieOwned + 1 + (1 * player.vanillaCookiesMachineOwned * (int?)vanillaCookieMachine.multiplier) + (1 * (int?)baker.multiplier * player.bakerOwned);
            Console.WriteLine("cookie owned: " + player.cookieOwned);
            if (player.vanillaCookiesMachineOwned > 0)
                Console.WriteLine("Vanilla cookie machine owned: " + player.vanillaCookiesMachineOwned);

            if (player.bakerOwned > 0)
                Console.WriteLine("baker owned: " + player.bakerOwned);

            Console.WriteLine("Press Enter to open the Store");
        }

        if (keyPressed == ConsoleKey.Enter)
        {
            Console.Clear();
            menu.actions();
        }

    }

}