
namespace games;
public class Player(int? moneyStart, int? vanillaCookiesMachineStart, int? bakerStart){

    public int? moneyOwned{get;set;} = moneyStart;

    public int? vanillaCookiesMachineOwned{get;set;} = vanillaCookiesMachineStart;

    public int? bakerOwned{get;set;} = bakerStart;


}