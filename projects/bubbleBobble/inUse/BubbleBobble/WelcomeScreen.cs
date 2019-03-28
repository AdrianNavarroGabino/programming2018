using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WelcomeScreen
{
    protected Image welcome;
    protected int option;
    protected Font font24;

    public WelcomeScreen()
    {
        welcome = new Image("data/welcome.png");
        option = 0;
        font24 = new Font("data/Joystix.ttf", 24);
    }

    public int GetChosenOption()
    {
        return option;
    }

    public void Run()
    {
        option = 0;
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(welcome, 100, 0);
        SdlHardware.WriteHiddenText("1. Play",
            30, 290,
            0xC0, 0xC0, 0xC0,
            font24);
        SdlHardware.WriteHiddenText("2. Credits",
            30, 330,
            0xA0, 0xA0, 0xA0,
            font24);
        SdlHardware.WriteHiddenText("3. Help",
            30, 370,
            0x80, 0x80, 0x80,
            font24);
        SdlHardware.WriteHiddenText("4. ScoreBoard",
            30, 410,
            0x80, 0x80, 0x80,
            font24);
        SdlHardware.WriteHiddenText("Q. Quit",
            30, 450,
            0x80, 0x80, 0x80,
            font24);
        SdlHardware.ShowHiddenScreen();

        do
        {
            if (SdlHardware.KeyPressed(SdlHardware.KEY_1))
            {
                option = 1;
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_2))
            {
                option = 2;
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_3))
            {
                option = 3;
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_4))
            {
                option = 4;
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_Q))
            {
                option = 5;
            }
            SdlHardware.Pause(100); // To avoid using 100% CPU
        }
        while (option == 0);
    }
}
