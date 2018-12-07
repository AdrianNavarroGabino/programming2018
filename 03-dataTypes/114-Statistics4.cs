// Statistics4: Sum, average, max, min, "end" to endish
// Adrián Navarro Gabino

using System;

public class Statistics
{
    public static void Main()
    {
        double sum = 0;
        double num;
        double average = 0;
        double minimum = 0;
        double maximum = 0;
        int count = 0;
        string numAux;
        
        Console.Write("Number: ");
        numAux = Console.ReadLine();
        if(numAux != "end")
        {
            num = Convert.ToDouble(numAux);
            minimum = num;
            maximum = num;
        }
        
        while(numAux != "end")
        {
            num = Convert.ToDouble(numAux);
            
            if(num != 0)
            {
                count++;
                sum += num;
                average = sum / count;
                Console.WriteLine("Max = {0}", maximum);
                Console.WriteLine("Min= {0}", minimum);
                Console.WriteLine("Sum = {0}", sum);
                Console.WriteLine("Average = {0}", average);
            }
            
            Console.Write("Number: ");
            numAux = Console.ReadLine();
            
            if(num < minimum)
                minimum = num;
            if(num > maximum)
                maximum = num;
        }
            
        Console.WriteLine("See you!");
        
    }
    
}
