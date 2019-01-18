class Room
{
    protected Image wallL1;

    protected int mapHeight = 16, mapWidth = 24;
    protected int tileWidth = 32, tileHeight = 32;
    protected int leftMargin = 100, topMargin = 50;

    protected string[] levelData =
    {
        "111111111111111111111111",
        "11                    11",
        "11                    11",
        "11                    11",
        "11                    11",
        "1111  111111111111  1111",
        "11                    11",
        "11                    11",
        "1111  111111111111  1111",
        "11                    11",
        "11                    11",
        "1111  111111111111  1111",
        "11                    11",
        "11                    11",
        "11                    11",
        "111111111111111111111111"};

    public Room()
    {
        wallL1 = new Image("data/tile-wallL1.png");
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
}
