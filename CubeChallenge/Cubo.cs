using System.Diagnostics;

public class Cubo
{


    // //! São todos referentes as posições do cubo, e o valor armazenado corresponde as cores
    //? [top,bottom,left,right,front,back]
    public string[] PositionsCube { get; private set; } = new string[6];

    public Cubo(string[] Colors)
    {
        this.PositionsCube = Colors;
    }

    public List<List<string>> getLines()
    {

        List<string> redConections = [];
        List<string> blueConections = [];
        List<string> greenConections = [];
        List<string> yellowConections = [];

        for (int i = 0; i < 6; i++)
        {
            switch (PositionsCube[i])
            {
                case "Red":
                    redConections.Add(PositionsCube[i + 1]);

                    if (PositionsCube[i + 1] == "Blue")
                        blueConections.Add(PositionsCube[i]);

                    if (PositionsCube[i + 1] == "Yellow")
                        yellowConections.Add(PositionsCube[i]);

                    if (PositionsCube[i + 1] == "Green")
                        greenConections.Add(PositionsCube[i]);

                    break;

                case "Blue":
                    blueConections.Add(PositionsCube[i + 1]);

                    if (PositionsCube[i + 1] == "Red")
                        redConections.Add(PositionsCube[i]);

                    if (PositionsCube[i + 1] == "Yellow")
                        yellowConections.Add(PositionsCube[i]);

                    if (PositionsCube[i + 1] == "Green")
                        greenConections.Add(PositionsCube[i]);

                    break;

                case "Yellow":
                    yellowConections.Add(PositionsCube[i + 1]);

                    if (PositionsCube[i + 1] == "Red")
                        redConections.Add(PositionsCube[i]);

                    if (PositionsCube[i + 1] == "Blue")
                        blueConections.Add(PositionsCube[i]);

                    if (PositionsCube[i + 1] == "Green")
                        greenConections.Add(PositionsCube[i]);

                    break;
                case "Green":
                    greenConections.Add(PositionsCube[i + 1]);

                    if (PositionsCube[i + 1] == "Red")
                        redConections.Add(PositionsCube[i]);

                    if (PositionsCube[i + 1] == "Blue")
                        blueConections.Add(PositionsCube[i]);

                    if (PositionsCube[i + 1] == "Yellow")
                        yellowConections.Add(PositionsCube[i]);
                    break;
            }
            i++;
        }
        return new List<List<string>> { redConections, blueConections, greenConections, yellowConections };
    }

}

//cubo 1 (red,blue,green,yellow)
// [[blue],[red],[yellow],[green,yellow]]

//cubo 2 (red,blue,green,yellow)
// [[green,yellow],[yellow],[red],[red,blue]]
