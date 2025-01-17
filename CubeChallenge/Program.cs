public class Program
{
    public static void Main(string[] args)
    {
        int i = 0;
        string[] colors = ["Red", "Blue", "Yellow", "Green"];

        //TODO [Top,     Bottom,    Left,    Right,    Front,    Back   ]
        Cubo cubo1 = new([colors[0], colors[1], colors[2], colors[3], colors[2], colors[2]]);
        Cubo cubo2 = new([colors[0], colors[2], colors[0], colors[3], colors[2], colors[1]]);
        Cubo cubo3 = new([colors[3], colors[3], colors[0], colors[1], colors[1], colors[2]]);
        Cubo cubo4 = new([colors[0], colors[3], colors[0], colors[1], colors[2], colors[3]]);

        var allConnectionsCube1 = cubo1.getLines();

        foreach (var connectionList in allConnectionsCube1)
        {
            connectionList.ForEach(x => Console.Write(x.ToString()));
            Console.WriteLine();
            // Console.WriteLine($"[ {string.Join("", connectionList)} ]");
            i++;
        }

        Console.WriteLine(i);


        // Console.WriteLine("\n\n");
        // var allConnectionsCube2 = cubo2.getLines();

        // foreach (var connectionList in allConnectionsCube2)
        // {
        //     Console.WriteLine($"[ {string.Join(", ", connectionList)} ]");
        // }
        // Console.WriteLine("\n\n");
        // var allConnectionsCube3 = cubo3.getLines();

        // foreach (var connectionList in allConnectionsCube3)
        // {
        //     Console.WriteLine($"[ {string.Join(", ", connectionList)} ]");
        // }
        // Console.WriteLine("\n\n");
        // var allConnectionsCube4 = cubo4.getLines();

        // foreach (var connectionList in allConnectionsCube4)
        // {
        //     Console.WriteLine($"[ {string.Join(", ", connectionList)} ]");
        // }

    }

    //cubo 1 (red,blue,green,yellow)
    // [[blue],[red],[yellow],[green,yellow]]
}
