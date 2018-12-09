// Adrián Navarro Gabino

using System;

public class SquareRoot
{
    public static void Main()
    {
        Console.Write("Number? ");
        string number = Console.ReadLine();
        long num;
        long root = 0;
        bool exact = true;
        
        while(number != "end")
        {
            num = Convert.ToInt64(number);
            
            for(long i = 1; i <= num; i++)
            {
                if(i * i <= num && (i + 1) * (i + 1) > num)
                    root = i;
            }
            
            if(root * root == num)
            {
                Console.Write("Root: " + root);
                Console.WriteLine(" (exact)");
            }
            else
            {
                exact = false;
                if((num - root * root) < ((root + 1) * (root + 1) - num) )
                    Console.Write("Root: " + root);
                else
                    Console.Write("Root: " + (root + 1));
                Console.WriteLine(" (not exact)");
            }
            
            if(!exact)
            {
                double rootexact = (double) root;
                for(double i = 0.1; i < 1; i += 0.1)
                {
                    if((root + i) * (root + i) <= num &&
                        (root + i + 0.1) * (root + i + 0.1) > num)
                        rootexact = root + i;
                }
                
                Console.WriteLine("Root with a decimal: " + rootexact);
            }
            
            Console.Write("Number? ");
            number = Console.ReadLine();
        }
        
        Console.WriteLine("Finished session");
    }
}
