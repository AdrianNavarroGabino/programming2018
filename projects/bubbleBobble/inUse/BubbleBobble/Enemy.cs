using System;

class Enemy : Sprite
{
    public Enemy()
    {
        LoadImage("data/enemy.png");
        width = 64;
        height = 64;
    }
}
