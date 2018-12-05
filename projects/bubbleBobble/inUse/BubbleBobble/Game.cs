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
        static Image player = new Image("data/player.png");
        static int playerX = 50;
        static int playerY = 120;
        static int playerSpeed = 8;
        static int playerWidth = 32;
        static int playerHeight = 64;

        static Random rnd = new Random();
        static int numEnemies = 2;
        static int[] enemyX = new int[numEnemies];
        static int[] enemyY = new int[numEnemies];
        static int[] enemySpeedX = new int[numEnemies];

        static int enemyWidth = 64;
        static int enemyHeight = 64;
        static Image enemy = new Image("data/enemy.png");

        static bool finished = false;
        public static void Init()
        {
            for (int i = 0; i < numEnemies; i++)
            {
                enemyX[i] = rnd.Next(200, 800);
                enemyY[i] = rnd.Next(50, 600);
                enemySpeedX[i] = rnd.Next(1, 5);
            }
        }

        public static void DrawElements(Font font18)
        {
            SdlHardware.ClearScreen();

            SdlHardware.WriteHiddenText("Score: ",
                40, 10,
                0xCC, 0xCC, 0xCC,
                font18);

            SdlHardware.DrawHiddenImage(player, playerX, playerY);
            for (int i = 0; i < numEnemies; i++)
                SdlHardware.DrawHiddenImage(enemy, enemyX[i], enemyY[i]);
            SdlHardware.ShowHiddenScreen();
        }

        public static void ProcessUserInput()
        {
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                playerX += playerSpeed;
            else if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
                playerX -= playerSpeed;
            else if (SdlHardware.KeyPressed(SdlHardware.KEY_UP))
                playerY -= playerSpeed;
            else if (SdlHardware.KeyPressed(SdlHardware.KEY_DOWN))
                playerY += playerSpeed;
        }

        public static void CheckGameStatus()
        {
            if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
                finished = true;
        }

        public static void PauseUntilNextFrame()
        {
            Thread.Sleep(40);
        }


        static void Main(string[] args)
        {
            bool fullScreen = false;
            SdlHardware.Init(1024, 768, 24, fullScreen);
            Font font18 = new Font("data/Joystix.ttf", 18);

            Init();

            do
            {
                DrawElements(font18);

                ProcessUserInput();

                CheckGameStatus();

                PauseUntilNextFrame();
            }
            while (!finished);
        }
    }
}
