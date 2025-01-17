public class Solver
{

    List<List<string>> lineCube1;
    List<List<string>> lineCube2;
    List<List<string>> lineCube3;
    List<List<string>> lineCube4;

    public Solver(List<List<string>> lineCube1, List<List<string>> lineCube2, List<List<string>> lineCube3, List<List<string>> lineCube4)
    {
        this.lineCube1 = lineCube1;
        this.lineCube2 = lineCube2;
        this.lineCube3 = lineCube3;
        this.lineCube4 = lineCube4;
    }

    public List<List<string>> getGraph()
    {
        int interable1 = 0;
        int interable2 = 0;
        int interable3 = 0;
        int interable4 = 0;
        List<string> RedWithBlue = [];
        List<string> RedWithYellow = [];
        List<string> RedWithGreen = [];
        List<string> YellowWithGreen = [];
        List<string> YellowWithBlue = [];
        List<string> BlueWithGreen = [];



        foreach (var connectionList in lineCube1)
        {
            connectionList.ForEach(x =>
            {

                if (interable1 == 0)
                {
                    if (x.ToString() == "Blue")
                        RedWithBlue.Add(x.ToString());

                    if (x.ToString() == "Yellow")
                        RedWithYellow.Add(x.ToString());

                    if (x.ToString() == "Green")
                        RedWithGreen.Add(x.ToString());
                }

                if (interable1 == 1)
                    if (x.ToString() == "Blue")
                        BlueWithGreen.Add(x.ToString());

                if (interable1 == 3)
                {
                    if (x.ToString() == "Blue")
                        YellowWithBlue.Add(x.ToString());

                    if (x.ToString() == "Green")
                        YellowWithGreen.Add(x.ToString());
                }
            });
            interable1++;
        }



        foreach (var connectionList in lineCube2)
        {
            connectionList.ForEach(x =>
            {

                if (interable2 == 0)
                {
                    if (x.ToString() == "Blue")
                        RedWithBlue.Add(x.ToString());

                    if (x.ToString() == "Yellow")
                        RedWithYellow.Add(x.ToString());

                    if (x.ToString() == "Green")
                        RedWithGreen.Add(x.ToString());
                }

                if (interable2 == 1)
                    if (x.ToString() == "Blue")
                        BlueWithGreen.Add(x.ToString());

                if (interable2 == 3)
                {
                    if (x.ToString() == "Blue")
                        YellowWithBlue.Add(x.ToString());

                    if (x.ToString() == "Green")
                        YellowWithGreen.Add(x.ToString());
                }
            });
            interable2++;
        }

    foreach (var connectionList in lineCube3)
        {
            connectionList.ForEach(x =>
            {

                if (interable2 == 0)
                {
                    if (x.ToString() == "Blue")
                        RedWithBlue.Add(x.ToString());

                    if (x.ToString() == "Yellow")
                        RedWithYellow.Add(x.ToString());

                    if (x.ToString() == "Green")
                        RedWithGreen.Add(x.ToString());
                }

                if (interable2 == 1)
                    if (x.ToString() == "Blue")
                        BlueWithGreen.Add(x.ToString());

                if (interable2 == 3)
                {
                    if (x.ToString() == "Blue")
                        YellowWithBlue.Add(x.ToString());

                    if (x.ToString() == "Green")
                        YellowWithGreen.Add(x.ToString());
                }
            });
            interable2++;
        }
        return new List<List<string>> { };
    }
}

// [[1,3,4],[]]