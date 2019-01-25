using System;

class Enemy : Sprite
{
    public Enemy()
    {
        LoadImage("data/enemy.png");
        width = 64;
        height = 64;
        xSpeed = 6;
    }

    public override void Move()
    {
        x += xSpeed;
        if ((x < 50) || (x > 970))
            xSpeed = -xSpeed;
    }
}
