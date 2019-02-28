class Room
{
    protected Image wallL1;

    protected int mapHeight = 15, mapWidth = 19;
    protected int tileWidth = 32, tileHeight = 32;
    protected int leftMargin = 100, topMargin = 50;

    const int MAX_ENEMIES = 10;
    public int NumEnemies = 0;
    public Enemy[] Enemies;

    protected string[] levelData =
    {
        "1111111111111111111",
        "1                 1",
        "1                 1",
        "1       ee        1",
        "1                 1",
        "11   111111111   11",
        "1                 1",
        "1                 1",
        "11   111111111   11",
        "1                 1",
        "1                 1",
        "11   111111111   11",
        "1                 1",
        "1                 1",
        "1111111111111111111"};

    public Room()
    {
        wallL1 = new Image("data/tile-wallL1.png");

        Enemies = new Enemy[MAX_ENEMIES];
        for (int row = 0; row < mapHeight; row++)
        {
            for (int col = 0; col < mapWidth; col++)
            {
                if (levelData[row][col] == 'e')
                {
                    int posX = col * tileWidth + leftMargin;
                    int posY = row * tileHeight + topMargin;
                    Enemies[NumEnemies] = new Enemy();
                    Enemies[NumEnemies].MoveTo(posX, posY);
                    Enemies[NumEnemies].SetSpeed(2, 2);
                    NumEnemies++;
                    levelData[row] = levelData[row].
                        Remove(col, 1).Insert(col, " ");
                }
            }
        }
    }

    public void DrawOnHiddenScreen()
    {
        for (int row = 0; row < mapHeight; row++)
        {
            for (int col = 0; col < mapWidth; col++)
            {
                int posX = col * tileWidth + leftMargin;
                int posY = row * tileHeight + topMargin;
                switch (levelData[row][col])
                {
                    case '1': SdlHardware.DrawHiddenImage(wallL1, posX, posY); break;
                }
            }
        }
    }
    public bool CanMoveTo(int x1, int y1, int x2, int y2)
    {
        for (int column = 0; column < mapWidth; column++)
        {
            for (int row = 0; row < mapHeight; row++)
            {
                char tile = levelData[row][column];
                if (tile != ' ')
                {
                    int x1tile = leftMargin + column * tileWidth;
                    int y1tile = topMargin + row * tileHeight;
                    int x2tile = x1tile + tileWidth;
                    int y2tile = y1tile + tileHeight;
                    if ((x1tile < x2) &&
                        (x2tile > x1) &&
                        (y1tile < y2) &&
                        (y2tile > y1) 
                        )
                        return false;
                }
            }
        }
        return true;
    }
}
