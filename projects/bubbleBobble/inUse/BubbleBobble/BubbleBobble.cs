using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BubbleBobble
{
    public static void Main()
    {
        bool fullScreen = false;
        SdlHardware.Init(1024, 720, 24, fullScreen);

        WelcomeScreen w = new WelcomeScreen();
        do
        {
            w.Run();
            if (w.GetChosenOption() == 1)
            {
                Game g = new Game();
                g.Run();
            }
            else if (w.GetChosenOption() == 2)
            {
                CreditsScreen credits = new CreditsScreen();
                credits.Run();
            }
            else if (w.GetChosenOption() == 3)
            {
				HelpScreen help = new HelpScreen();
				help.Run();	
			}
        } while (w.GetChosenOption() != 4);
    }
}
