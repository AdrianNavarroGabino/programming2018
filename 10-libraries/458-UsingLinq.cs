// Adrián Navarro Gabino

using System;
using System.Linq;

class UsingLinq
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter number {0}: ", (i + 1));
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        var result =
            from n in numbers
            where n > 0
            orderby n
            select n;

        foreach(var number in result)
            Console.Write(number + " ");
    }
}


