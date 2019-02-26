class Player : Sprite
{
    protected bool jumping = false, falling = false;
    protected int xJumpSpeed = 0;
    int[] stepsOfJump = {-34, -27, -22, -16, -10, -6, -2, -1, 0,
                               0, 1, 2, 6, 10, 16, 22, 27, 34};
    protected int frameOfTheJump = 0;

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

    public void MoveRight(Room room)
    {
        if (room.CanMoveTo(x + xSpeed,
                    y,
                    x + width + xSpeed,
                    y + height))
        {
            x += xSpeed;
            ChangeDirection(RIGHT);
            NextFrame();
        }
    }

    public void MoveLeft(Room room)
    {
        if (room.CanMoveTo(x - xSpeed,
            y,
            x + width - xSpeed,
            y + height))
        {
            x -= xSpeed;
            ChangeDirection(LEFT);
            NextFrame();
        }
    }

    public void Jump(Room room)
    {
        if (jumping || falling)
            return;
        jumping = true;
        xJumpSpeed = 0;
    }

    public void JumpRight(Room room)
    {
        Jump(room);
        xJumpSpeed = xSpeed;
    }


    // Starts the jump left sequence
    public void JumpLeft(Room room)
    {
        Jump(room);
        xJumpSpeed = -xSpeed;
    }

    // Used when the player must move on his own, e.g. jumping
    public void Move(Room room)
    {
        if (jumping)
        {
            short xNextMove = (short)(x + xJumpSpeed);
            short yNextMove = (short)(y + stepsOfJump[frameOfTheJump]);
            
            if (room.CanMoveTo(
                    xNextMove,
                    yNextMove,
                    xNextMove + width,
                    yNextMove + height)
                )
            {
                x = xNextMove;
                y = yNextMove;
                NextFrame();
            }
            else
            {
                jumping = false;
                falling = true;
            }

            frameOfTheJump++;
            if (frameOfTheJump >= stepsOfJump.Length)
            {
                jumping = false;
                falling = true;
                frameOfTheJump = 0;
            }
        }
        else
        {
            if (room.CanMoveTo(
                x,
                y + ySpeed,
                x + width,
                y + ySpeed + height))
            {
                y += ySpeed;
                falling = true;
            }
            else
                falling = false;
        }
    }
}
