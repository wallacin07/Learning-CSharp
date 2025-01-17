public class Program
{
    public static void Main(string[] args)
    {
        // int i = 0;
        string[] colors = ["Red", "Blue", "Yellow", "Green"];

        //TODO [Top,     Bottom,    Left,    Right,    Front,    Back   ]
        Cubo cubo1 = new([colors[0], colors[1], colors[2], colors[3], colors[2], colors[2]]);
        Cubo cubo2 = new([colors[0], colors[2], colors[0], colors[3], colors[2], colors[1]]);
        Cubo cubo3 = new([colors[3], colors[3], colors[0], colors[1], colors[1], colors[2]]);
        Cubo cubo4 = new([colors[0], colors[3], colors[0], colors[1], colors[2], colors[3]]);

        var allConnectionsCube1 = cubo1.getLines();
        var allConnectionsCube2 = cubo2.getLines();
        var allConnectionsCube3 = cubo3.getLines();
        var allConnectionsCube4 = cubo4.getLines();

        Solver solver = new(allConnectionsCube1,allConnectionsCube2,allConnectionsCube3,allConnectionsCube4);
        var giantGraph = solver.getGraph();
         foreach (var connectionList in giantGraph)
        {
            connectionList.ForEach(x => Console.Write(x.ToString()+","));
            Console.WriteLine();
        }

    }

    //cubo 1 (red,blue,green,yellow)
    // [[blue],[red],[yellow],[green,yellow]]
}
