// Creating a loop with "goto"
// Adrián Navarro Gabino

using System;

public class OneToTenGoTo
{
    public static void Main()
    {        
        int n = 1;
        
    loop:
        Console.Write("{0} ", n);
        n++;
        
        if(n <= 10)
            goto loop;
    }
}
