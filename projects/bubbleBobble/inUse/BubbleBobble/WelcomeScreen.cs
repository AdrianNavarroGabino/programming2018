using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WelcomeScreen
{
    public void Run()
    {
        Image welcome = new Image("data/welcome.png");
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(welcome, 100, 0);
        SdlHardware.ShowHiddenScreen();
        SdlHardware.Pause(2000);
    }


}
