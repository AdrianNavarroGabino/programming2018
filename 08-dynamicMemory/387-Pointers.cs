// Adrián Navarro Gabino

using System;

class Pointers
{
    unsafe static void Main()
    {
        int x;
        x = 2;
        
        int y;
        y = 10;
        
        int* position;
        position = &x;
        
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine((long) position);
    }
}
