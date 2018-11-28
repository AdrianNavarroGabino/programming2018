// Adrián Navarro Gabino

using System;

public class Base1
{
    public static void Main()
    {
        int n;
        
        do
        {
            n = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
                Console.Write(1);
            Console.WriteLine();
        } while(n != 0);
    }
}
