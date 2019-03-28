using System;
using System.Collections.Generic;
using System.IO;

class ScoreBoard
{
    protected Font font24;

    protected List<Score> scores = new List<Score>();

    public ScoreBoard()
    {
        for (int i = 0; i < 10; i++)
        {
            scores.Add(new Score(100 - 10 * i, "AAAA"));
        }
    }

    public ScoreBoard(List<Score> list)
    {
        scores = list;
    }

    public int GetScore(int position)
    {
        return scores[position - 1].Points;
    }

    public string GetName(int position)
    {
        return scores[position - 1].Name;
    }

    public void Add(string name, int score)
    {
        int i = 9;
        int position = -1;

        while (score > scores[i].Points)
        {
            position = i;
            i--;
        }

        if (position != -1)
        {
            scores.Insert(position, new Score(score, name));
            scores.RemoveAt(10);
        }
    }

    public void Save()
    {
        StreamWriter output = new StreamWriter("scores.dat");

        for (int i = 0; i < 10; i++)
        {
            output.WriteLine(scores[i].Name);
            output.WriteLine(scores[i].Points);
        }

        output.Close();
    }

    public ScoreBoard Load()
    {
        if (File.Exists("scores.dat"))
        {
            List<Score> list = new List<Score>();
            StreamReader input = new StreamReader("scores.dat");

            for (int i = 0; i < 10; i++)
            {
                string name = input.ReadLine();
                int points = Convert.ToInt32(input.ReadLine());

                list.Add(new Score(points, name));
            }

            input.Close();
            return new ScoreBoard(list);
        }
        else
            return new ScoreBoard();
    }

    public void Run()
    {
        SdlHardware.ClearScreen();

        for (int i = 1; i <= 10; i++)
        {
            short fontSize = 40;
            short yPosition = 0;
            byte color1 = 0xC0;
            byte color2 = 0xC0;
            byte color3 = 0xC0;
            string number =  "";

            if (i == 1)
            {
                fontSize = 100;
                yPosition = 10;
                color1 = 0xFF;
                color2 = 0x00;
                color3 = 0x00;
                number = "1st";
            }
            else if(i == 2)
            {
                fontSize = 80;
                yPosition = 120;
                color1 = 0xFD;
                color2 = 0x79;
                color3 = 0x00;
                number = "2nd";
            }
            else if (i == 3)
            {
                fontSize = 60;
                yPosition = 210;
                color1 = 0xFD;
                color2 = 0xC7;
                color3 = 0x00;
                number = "3rd";
            }
            else
            {
                yPosition = (short)(210 + (i - 3) * 60);
                number = i + "th";
            }

            font24 = new Font("data/Joystix.ttf", fontSize);

            SdlHardware.WriteHiddenText(number,
                20, yPosition,
                color1, color2, color3,
                font24);
            SdlHardware.WriteHiddenText(GetName(i),
                270, yPosition,
                color1, color2, color3,
                font24);
            SdlHardware.WriteHiddenText(""+GetScore(i),
                750, yPosition,
                color1, color2, color3,
                font24);
        }

        SdlHardware.ShowHiddenScreen();
        do
        {
            SdlHardware.Pause(100);
        } while (!SdlHardware.KeyPressed(SdlHardware.KEY_R));
    }
}
