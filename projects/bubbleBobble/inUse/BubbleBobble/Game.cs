// Adrián Navarro Gabino

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Game
{
    protected Player player;
    protected int numEnemies;
    protected Enemy[] enemies;
    protected Room room;
    protected bool finished;
    protected Font font18;

        
    void Init()
    {
        player = new Player();

        numEnemies = 2;
        enemies = new Enemy[numEnemies];
        
        for(int i = 0; i < numEnemies; i++)
        {
            enemies[i] = new Enemy();
        }

        finished = false;

        Random rnd = new Random();
        for (int i = 0; i < numEnemies; i++)
        {
            enemies[i].MoveTo(rnd.Next(200, 800), rnd.Next(50, 600));
            enemies[i].SetSpeed(rnd.Next(1, 5), rnd.Next(1, 5));
        }

        font18 = new Font("data/Joystix.ttf", 18);
        room = new Room();
    }

    void UpdateScreen()
    {
        SdlHardware.ClearScreen();
        room.DrawOnHiddenScreen();

        SdlHardware.WriteHiddenText("Score: ",
            40, 10,
            0xCC, 0xCC, 0xCC,
            font18);
        
        player.DrawOnHiddenScreen();
        for (int i = 0; i < numEnemies; i++)
            enemies[i].DrawOnHiddenScreen();
        SdlHardware.ShowHiddenScreen();
    }

    void CheckUserInput()
    {
        if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
            player.MoveRight();
        if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
            player.MoveLeft();
        if (SdlHardware.KeyPressed(SdlHardware.KEY_UP))
            player.MoveUp();
        if (SdlHardware.KeyPressed(SdlHardware.KEY_DOWN))
            player.MoveDown();

        if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
            finished = true;
    }

    void UpdateWorld()
    {
        // TODO
    }

    void CheckGameStatus()
    {
        // TODO
    }

    void PauseUntilNextFrame()
    {
        SdlHardware.Pause(40);
    }

    void UpdateHighscore()
    {
        // TODO
    }

    public void Run()
    {
        Init();

        do
        {
            UpdateScreen();
            CheckUserInput();
            UpdateWorld();
            PauseUntilNextFrame();
            CheckGameStatus();
        }
        while (!finished);

        UpdateHighscore();
    }
}

