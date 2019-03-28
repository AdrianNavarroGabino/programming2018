class HelpScreen
{
    protected Font font24;

    public void Run()
    {
        font24 = new Font("data/Joystix.ttf", 18);
        SdlHardware.ClearScreen();
        // SdlHardware.DrawHiddenImage();
        SdlHardware.WriteHiddenText("LEFT and RIGHT arrows to move",
            300, 290,
            0xC0, 0xC0, 0xC0,
            font24);
        SdlHardware.WriteHiddenText("Spacebar to jump",
            300, 330,
            0xA0, 0xA0, 0xA0,
            font24);
        SdlHardware.WriteHiddenText("Fire still not available",
            300, 370,
            0xA0, 0xA0, 0xA0,
            font24);
        SdlHardware.WriteHiddenText("R - Return to Welcome ",
            300, 410,
            0x80, 0x80, 0x80,
            font24);
        SdlHardware.ShowHiddenScreen();
        do
        {
            SdlHardware.Pause(100); // To avoid using 100% CPU
        } while (!SdlHardware.KeyPressed(SdlHardware.KEY_R));
    }
}
