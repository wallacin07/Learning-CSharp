
namespace games;
public class Menu(Player actualPlayer)
{

    public Player Buyer = actualPlayer;
    public Machine vanillaCookieMachine = new(10+((2 * actualPlayer.bakerOwned)*1.2), 1.5);
    public Machine baker = new(200+((32 * actualPlayer.bakerOwned)*1.2), 5);

    public Machine Furniture = new(1000+((180 * actualPlayer.bakerOwned)*1.2), 5);

    public void PrintStore()
    {
        string asciiArt = @"
 __      __       .__                                  __             __  .__                       __                         
/  \    /  \ ____ |  |   ____  ____   _____   ____   _/  |_  ____   _/  |_|  |__   ____     _______/  |_  ___________   ____   
\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \  \   __\/  _ \  \   __\  |  \_/ __ \   /  ___/\   __\/  _ \_  __ \_/ __ \  
 \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/   |  | (  <_> )  |  | |   Y  \  ___/   \___ \  |  | (  <_> )  | \/\  ___/  
  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >  |__|  \____/   |__| |___|  /\___  > /____  > |__|  \____/|__|    \___  > 
       \/       \/          \/            \/     \/                            \/     \/       \/                          \/  
       


 _                            _ _ _                              _     _                 _  _  ___  
/ |         /\   /\__ _ _ __ (_) | | __ _   _ __ ___   __ _  ___| |__ (_)_ __   ___     | |/ |/ _ \ 
| |  _____  \ \ / / _` | '_ \| | | |/ _` | | '_ ` _ \ / _` |/ __| '_ \| | '_ \ / _ \   / __) | | | |
| | |_____|  \ V / (_| | | | | | | | (_| | | | | | | | (_| | (__| | | | | | | |  __/   \__ \ | |_| |
|_|           \_/ \__,_|_| |_|_|_|_|\__,_| |_| |_| |_|\__,_|\___|_| |_|_|_| |_|\___|   (   /_|\___/ 
                                                                                        |_|         
 ____              ___       _                  _  ____   ___                                       
|___ \            / __\ __ _| | _____ _ __     | || ___| / _ \                                      
  __) |  _____   /__\/// _` | |/ / _ \ '__|   / __)___ \| | | |                                     
 / __/  |_____| / \/  \ (_| |   <  __/ |      \__ \___) | |_| |                                     
|_____|         \_____/\__,_|_|\_\___|_|      (   /____/ \___/                                      
                                               |_|                                                  

";


        Console.Clear();
        Console.WriteLine(asciiArt);
    }

    public void actions()
    {
        PrintStore();

        if (Console.ReadKey().Key == ConsoleKey.NumPad1 && Buyer.moneyOwned >= 10)
        {
            Buyer.moneyOwned = Buyer.moneyOwned - 10;
            Buyer.vanillaCookiesMachineOwned = Buyer.vanillaCookiesMachineOwned + 1;
        }

        if (Console.ReadKey().Key == ConsoleKey.NumPad2 && Buyer.moneyOwned >= 50)
        {
            Buyer.moneyOwned = Buyer.moneyOwned - 50;
            Buyer.vanillaCookiesMachineOwned = Buyer.vanillaCookiesMachineOwned + 1;
        }
    }


}






