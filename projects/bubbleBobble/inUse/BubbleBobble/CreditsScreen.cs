using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CreditsScreen
{
    public void Run()
    {
        Image welcome = new Image("data/credits.png");
        Font font18 = new Font("data/Joystix.ttf", 18);
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(welcome, 0, 0);
        SdlHardware.WriteHiddenText("(Partial) Remake by Adrián",
            10, 50,
            0x57, 0xA6, 0x39,
            font18);
        SdlHardware.WriteHiddenText("R to Return",
            420, 440,
            0xFE, 0x00, 0x00,
            font18);
        SdlHardware.ShowHiddenScreen();
        do
        {
            SdlHardware.Pause(100); // To avoid using 100% CPU
        }while (!SdlHardware.KeyPressed(SdlHardware.KEY_R));
    }
}
