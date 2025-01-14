
namespace games;
public  class Menu(Player actualPlayer, Machine vanillaCookieMachine, Machine baker, Machine Furniture)
{
    public  void PrintStore()
    {
        Console.Clear();
        string asciiArt = $@"
 __      __       .__                                  __             __  .__                       __                         
/  \    /  \ ____ |  |   ____  ____   _____   ____   _/  |_  ____   _/  |_|  |__   ____     _______/  |_  ___________   ____   
\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \  \   __\/  _ \  \   __\  |  \_/ __ \   /  ___/\   __\/  _ \_  __ \_/ __ \  
 \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/   |  | (  <_> )  |  | |   Y  \  ___/   \___ \  |  | (  <_> )  | \/\  ___/  
  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >  |__|  \____/   |__| |___|  /\___  > /____  > |__|  \____/|__|    \___  > 
       \/       \/          \/            \/     \/                            \/     \/       \/                          \/  
       

    A - Vanilla Cookie Machine  ${vanillaCookieMachine.cost}
    B - Baker  ${baker.cost}
    C - Furniture ${Furniture.cost}

    Vanilla machine Owned {actualPlayer.vanillaCookiesMachineOwned}
    Baker Owned {actualPlayer.bakerOwned}
    Furniture Owned {actualPlayer.furnitureOwned}

    Cookie Owned {actualPlayer.cookieOwned}

    Press SPACE to go back.
    ";
        Console.Clear();
        Console.WriteLine(asciiArt);
    }

    
    public void actions()
    {
        var yes = true;
        while (yes)
        {
            PrintStore();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.A:
                    if (actualPlayer.cookieOwned >= vanillaCookieMachine.cost)
                    {
                        actualPlayer.cookieOwned = actualPlayer.cookieOwned - (int?)vanillaCookieMachine.cost;
                        actualPlayer.vanillaCookiesMachineOwned = actualPlayer.vanillaCookiesMachineOwned + 1;
                        vanillaCookieMachine.cost = vanillaCookieMachine.cost + (6 * actualPlayer.vanillaCookiesMachineOwned * 1.2);
                        PrintStore();
                    }
                    break;

                case ConsoleKey.B:
                    if (actualPlayer.cookieOwned >= vanillaCookieMachine.cost)
                    {
                        actualPlayer.cookieOwned = actualPlayer.cookieOwned - (int?)baker.cost;
                        actualPlayer.bakerOwned = actualPlayer.bakerOwned + 1;
                        baker.cost = baker.cost + (600 * actualPlayer.bakerOwned * 1.6);
                        PrintStore();
                    }
                    break;

                case ConsoleKey.C:
                    if (actualPlayer.cookieOwned >= vanillaCookieMachine.cost)
                    {
                        actualPlayer.cookieOwned = actualPlayer.cookieOwned - (int?)Furniture.cost;
                        actualPlayer.furnitureOwned = actualPlayer.furnitureOwned + 1;
                        Furniture.cost = Furniture.cost + (600 * actualPlayer.furnitureOwned * 1.6);
                        PrintStore();
                    }
                    break;

                case ConsoleKey.Spacebar:
                    yes = false;
                    break;
            }
        }
    }
}