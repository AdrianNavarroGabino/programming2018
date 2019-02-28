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
    protected Room room;
    protected bool finished;
    protected Font font18;

        
    public Game()
    {
        player = new Player();
        player.MoveTo(200, 100);

        finished = false;

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
        for (int i = 0; i < room.NumEnemies; i++)
            room.Enemies[i].DrawOnHiddenScreen();
        SdlHardware.ShowHiddenScreen();
    }

    void CheckUserInput()
    {
        if (SdlHardware.KeyPressed(SdlHardware.KEY_SPC))
        {
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                player.JumpRight(room);
            else if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
                player.JumpLeft(room);
            else
                player.Jump(room);
        }

        if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
        {
            player.MoveRight(room);
        }
        if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
        {
            player.MoveLeft(room);
        }

        if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
            finished = true;
    }

    void UpdateWorld()
    {
        player.Move(room);

        for (int i = 0; i < room.NumEnemies; i++)
            room.Enemies[i].Move();
    }

    void CheckGameStatus()
    {
        for (int i = 0; i < room.NumEnemies; i++)
            if (player.CollisionsWith(room.Enemies[i]))
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

