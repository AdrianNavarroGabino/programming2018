class Player : Sprite
{
    public Player()
    {
        //LoadImage("data/player.png");
        LoadSequence(RIGHT,
            new string[] { "data/playerR1.png",
                "data/playerR2.png"});
        LoadSequence(LEFT,
            new string[] { "data/playerL1.png",
                "data/playerL2.png"});
        currentDirection = RIGHT;
        x = 50;
        y = 120;
        xSpeed = ySpeed = 8;
        width = 48;
        height = 48;
    }

    public void MoveRight()
    {
        x += xSpeed;
        ChangeDirection(RIGHT);
        NextFrame();
    }

    public void MoveLeft()
    {
        x -= xSpeed;
        ChangeDirection(LEFT);
        NextFrame();
    }

    public void MoveUp()
    {
        y -= ySpeed;
    }

    public void MoveDown()
    {
        y += ySpeed;
    }
}
