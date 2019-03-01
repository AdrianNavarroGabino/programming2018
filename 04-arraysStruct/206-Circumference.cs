// Adrián Navarro Gabino

using System;

public class Circumference
{
    public static void Main()
    {
        const int SIZE_X = 70;
        const int SIZE_Y = 20;
        const int x_CENTER = SIZE_X / 2;
        const int y_CENTER = SIZE_Y / 2;
        const int RADIUS = 8;
        
        byte[,] picture = new byte[SIZE_X,SIZE_Y];
        double x,y;
        
        for(int i = 0; i < 360; i+=5)
        {
            
            float radians = (float)(i * Math.PI / 180.0);
            
            x = x_CENTER + RADIUS * Math.Cos(radians);
            y = y_CENTER + RADIUS * Math.Sin(radians);
            
            picture[(int)x,(int)y] = 1;
        }
        
        for(int row = 0; row < SIZE_Y; row++)
        {
            for(int column = 0; column < SIZE_X; column++)
            {
                if(picture[column, row] == 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
