// Decimal to binary
// Adrián Navarro Gabino

using System;

public class Binary
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        
        int divider = number;
        int[] rests = new int[8];
        
        int count = 0;
        
        while(divider != 0)
        {
            rests[count] = divider % 2;
            divider /= 2;
            count++;
        }
        
        Console.Write("{0} with the algorithm: ", number);
        for(int i = count - 1; i >= 0; i--)
            Console.Write(rests[i]);
        Console.WriteLine();
        
        Console.WriteLine("{0} with .ToString: {1}",
            number, Convert.ToString(number, 2));
    }
}
