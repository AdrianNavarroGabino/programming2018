// Adrián Navarro Gabino

using System;

public class Pizzas
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < cases; i++)
        {
            int people = Convert.ToInt32(Console.ReadLine());
            
            String[] aux = Console.ReadLine().Split();
            
            int slices = 0;
            
            for(int j = 0; j < people; j++)
            {
                slices += Convert.ToInt32(aux[j]);
            }
            
            Console.Write("Case #" + (i + 1) + ": ");
            if(slices % 8 != 0)
            {
                Console.WriteLine(slices / 8 + 1);
            }
            else
            {
                Console.WriteLine(slices / 8);
            }
        }
    }
}
