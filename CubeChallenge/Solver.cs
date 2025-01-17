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
                        RedWithBlue.Add("1");

                    if (x.ToString() == "Yellow")
                        RedWithYellow.Add("1");

                    if (x.ToString() == "Green")
                        RedWithGreen.Add("1");
                }

                if (interable1 == 1)
                    if (x.ToString() == "Blue")
                        BlueWithGreen.Add("1");

                if (interable1 == 3)
                {
                    if (x.ToString() == "Blue")
                        YellowWithBlue.Add("1");

                    if (x.ToString() == "Green")
                        YellowWithGreen.Add("1");
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
                        RedWithBlue.Add("2");

                    if (x.ToString() == "Yellow")
                        RedWithYellow.Add("2");

                    if (x.ToString() == "Green")
                        RedWithGreen.Add("2");
                }

                if (interable2 == 1)
                    if (x.ToString() == "Blue")
                        BlueWithGreen.Add("2");

                if (interable2 == 3)
                {
                    if (x.ToString() == "Blue")
                        YellowWithBlue.Add("2");

                    if (x.ToString() == "Green")
                        YellowWithGreen.Add("2");
                }
            });
            interable2++;
        }

        foreach (var connectionList in lineCube3)
        {
            connectionList.ForEach(x =>
            {

                if (interable3 == 0)
                {
                    if (x.ToString() == "Blue")
                        RedWithBlue.Add("3");

                    if (x.ToString() == "Yellow")
                        RedWithYellow.Add("3");

                    if (x.ToString() == "Green")
                        RedWithGreen.Add("3");
                }

                if (interable3 == 1)
                    if (x.ToString() == "Blue")
                        BlueWithGreen.Add("3");

                if (interable3 == 3)
                {
                    if (x.ToString() == "Blue")
                        YellowWithBlue.Add("3");

                    if (x.ToString() == "Green")
                        YellowWithGreen.Add("3");
                }
            });
            interable3++;
        }

        foreach (var connectionList in lineCube4)
        {
            connectionList.ForEach(x =>
            {

                if (interable4 == 0)
                {
                    if (x.ToString() == "Blue")
                        RedWithBlue.Add("4");

                    if (x.ToString() == "Yellow")
                        RedWithYellow.Add("4");

                    if (x.ToString() == "Green")
                        RedWithGreen.Add("4");
                }

                if (interable4 == 1)
                    if (x.ToString() == "Blue")
                        BlueWithGreen.Add("4");

                if (interable4 == 3)
                {
                    if (x.ToString() == "Blue")
                        YellowWithBlue.Add("4");

                    if (x.ToString() == "Green")
                        YellowWithGreen.Add("4");
                }
            });
            interable4++;
        }
        return new List<List<string>> {RedWithBlue,RedWithYellow, RedWithGreen,YellowWithBlue,YellowWithGreen,BlueWithGreen};
    }
}

// [[1,3,4],[]]