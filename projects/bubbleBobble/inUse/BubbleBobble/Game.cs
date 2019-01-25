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

        
    public Game()
    {
        player = new Player();
        player.MoveTo(200, 100);

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
        {
            if (room.CanMoveTo(player.GetX() + player.GetSpeedX(),
                   player.GetY(),
                   player.GetX() + player.GetWidth() + player.GetSpeedX(),
                   player.GetY() + player.GetHeight()))
                player.MoveRight();
        }
        if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
        {
            if (room.CanMoveTo(player.GetX() - player.GetSpeedX(),
                    player.GetY(),
                    player.GetX() + player.GetWidth() - player.GetSpeedX(),
                    player.GetY() + player.GetHeight()))
                player.MoveLeft();
        }
        if (SdlHardware.KeyPressed(SdlHardware.KEY_UP))
        {
            if (room.CanMoveTo(player.GetX(),
                    player.GetY() - player.GetSpeedY(),
                    player.GetX() + player.GetWidth(),
                    player.GetY() + player.GetHeight() - player.GetSpeedY()))
                player.MoveUp();
        }
        if (SdlHardware.KeyPressed(SdlHardware.KEY_DOWN))
        {
            if (room.CanMoveTo(player.GetX(),
                    player.GetY() + player.GetSpeedY(),
                    player.GetX() + player.GetWidth(),
                    player.GetY() + player.GetHeight() + player.GetSpeedY()))
                player.MoveDown();
        }

        if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
            finished = true;
    }

    void UpdateWorld()
    {
        for (int i = 0; i < numEnemies; i++)
            enemies[i].Move();
    }

    void CheckGameStatus()
    {
        for (int i = 0; i < numEnemies; i++)
            if (player.CollisionsWith(enemies[i]))
                finished = true;
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

