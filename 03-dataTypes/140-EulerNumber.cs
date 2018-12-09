// Estimation of Euler's number
// Adrián Navarro Gabino

using System;

public class NumeroE
{
    public static void Main()
    {
        double e1, e2;
        
        int addends;
        int auxAddends;
        
        Console.Write("Addends? ");
        string amountOfAddends = Console.ReadLine();
        
        while(amountOfAddends != "")
        {
            addends = Convert.ToInt32(amountOfAddends);
            
            e1 = 0;
            e2 = 0;
            auxAddends = 1;
            
            for(int i = 0; i < addends; i++)
            {
                if(i == 0)
                {
                    e1 += 1;
                }
                else
                {
                    auxAddends *= i;
                    e1 += (1.0/auxAddends);
                }
            }
            
            auxAddends = 1;
            
            for(int i = 0; i < addends - 1; i++)
            {
                if(i == 0)
                {
                    e2 += 1;
                }
                else
                {
                    auxAddends *= i;
                    e2 += (1.0/auxAddends);
                }
            }
            
            Console.WriteLine("e is approximately " + e1 +
                " (difference with " + (addends - 1) + " addends: " +
                (e1 - e2) + ")");
            
            Console.Write("Addends? ");
            amountOfAddends = Console.ReadLine();
        }
        
        Console.WriteLine("Bye!");
    }
}
