// Average of positive and negative numbers
// Adrián Navarro Gabino

using System;

public class Average
{
    public static void Main(string[] args)
    {
        const int SIZE = 10;
        
        double[] numbers = new double[SIZE];
        double[] positiveNumbers = new double[SIZE];
        double[] negativeNumbers = new double[SIZE];
        
        int positiveCount = 0;
        int negativeCount = 0;
        
        double positiveSum = 0;
        double negativeSum = 0;
        
        double positiveAverage = 0;
        double negativeAverage = 0;
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter number {0}: ", (i+1));
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        foreach(double n in numbers)
        {
            if(n > 0)
            {
                positiveNumbers[positiveCount] = n;
                positiveCount++;
            }
            else if(n < 0)
            {
                negativeNumbers[negativeCount] = n;
                negativeCount++;
            }
        }
        
        if(positiveCount > 0)
        {
            foreach(double d in positiveNumbers)
            {
                positiveSum += d;
            }
            
            positiveAverage = positiveSum / SIZE;
            
            Console.WriteLine("Average of positive numbers: {0}",
                positiveAverage);
        }
        else
        {
            Console.WriteLine("There is no positive numbers");
        }
        
        if(negativeCount > 0)
        {
            foreach(double d in negativeNumbers)
            {
                negativeSum += d;
            }
            
            negativeAverage = negativeSum / SIZE;
            
            Console.WriteLine("Average of negative numbers: {0}",
                negativeAverage);
        }
        else
        {
            Console.WriteLine("There is no negative numbers");
        }
    }
}
