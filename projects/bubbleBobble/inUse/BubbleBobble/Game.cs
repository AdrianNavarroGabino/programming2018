// Adrián Navarro Gabino

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleBobble
{
    class Game
    {
        struct typeEnemy
        {
            public int x;
            public int y;
            public int speed;
        }

        static bool fullScreen;

        static Image player;
        static int playerX;
        static int playerY;
        static int playerSpeed;
        static int playerWidth;
        static int playerHeight;

        static int numEnemies;
        static Image enemy;
        static int enemyWidth;
        static int enemyHeight;
        static typeEnemy[] enemies;

        static bool finished;

        
        public static void Init()
        {
            fullScreen = false;

            SdlHardware.Init(1024, 768, 24, fullScreen);

            player = new Image("data/player.png");
            playerX = 50;
            playerY = 120;
            playerSpeed = 8;
            playerWidth = 32;
            playerHeight = 64;

            numEnemies = 2;
            enemies = new typeEnemy[numEnemies];
            
            enemy = new Image("data/enemy.png");
            enemyWidth = 64;
            enemyHeight = 64;

            finished = false;

            Random rnd = new Random();
            for (int i = 0; i < numEnemies; i++)
            {
                enemies[i].x = rnd.Next(200, 800);
                enemies[i].y = rnd.Next(50, 600);
                enemies[i].speed = rnd.Next(1, 5);
            }
        }

        public static void UpdateScreen()
        {
            Font font18 = new Font("data/Joystix.ttf", 18);

            SdlHardware.ClearScreen();

            SdlHardware.WriteHiddenText("Score: ",
                40, 10,
                0xCC, 0xCC, 0xCC,
                font18);

            SdlHardware.DrawHiddenImage(player, playerX, playerY);
            for (int i = 0; i < numEnemies; i++)
                SdlHardware.DrawHiddenImage(enemy, enemies[i].x, enemies[i].y);
            SdlHardware.ShowHiddenScreen();
        }

        public static void CheckUserInput()
        {
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                playerX += playerSpeed;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
                playerX -= playerSpeed;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_UP))
                playerY -= playerSpeed;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_DOWN))
                playerY += playerSpeed;

            if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
                finished = true;
        }

        public static void UpdateWorld()
        {
            // TODO
        }

        public static void CheckGameStatus()
        {
            // TODO
        }

        public static void PauseUntilNextFrame()
        {
            SdlHardware.Pause(40);
        }

        public static void UpdateHighscore()
        {
            // TODO
        }


        static void Main(string[] args)
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
}
