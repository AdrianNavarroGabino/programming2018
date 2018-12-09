// Adrián Navarro Gabino

using System;

public class Fibonacci
{
    public static void Main()
    {
        Console.Write("Term: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int firstFibonacci = 0;
        int secondFibonacci = 1;
        int count = 0;
        
        while(count <= n)
        {
            if(count == 0)
                firstFibonacci = 0;
            else if(count == 1)
                secondFibonacci = 1;
            else if(count > 1 && count % 2 == 0)
                firstFibonacci += secondFibonacci;
            else
                secondFibonacci += firstFibonacci;
                
            count++;
        }
        
        int fibonacciN = firstFibonacci <= secondFibonacci ? 
            secondFibonacci : firstFibonacci;
        int fibonacciNMinusOne = firstFibonacci <= secondFibonacci ? 
            firstFibonacci : secondFibonacci;
            
        Console.WriteLine("Term " + n + ": " + fibonacciN);
        Console.WriteLine(fibonacciN + " divided by " + fibonacciNMinusOne +
            ": " + ((double)fibonacciN / (double)fibonacciNMinusOne));
    }
}
