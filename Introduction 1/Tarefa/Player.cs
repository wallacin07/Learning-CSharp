
namespace games;
public class Player(int? moneyStart, int? vanillaCookiesMachineStart, int? bakerStart, int? furniture){
    public int? cookieOwned{get;set;} = moneyStart;
    public int? vanillaCookiesMachineOwned{get;set;} = vanillaCookiesMachineStart;
    public int? bakerOwned{get;set;} = bakerStart;
    public int? furnitureOwned{get;set;} = furniture;
}