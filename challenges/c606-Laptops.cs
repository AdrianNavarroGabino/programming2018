// Adrián Navarro Gabino

using System;

class Laptops
{
    static bool IsHappy(int[,] laptops, int numberOfLaptops)
    {
        for(int i = 0; i < numberOfLaptops; i++)
            for(int j = 0; j < numberOfLaptops; j++)
                if(laptops[i,0] < laptops[j,0] && laptops[i,1] > laptops[j,1])
                    return true;
                    
        return false;
    }
    
    
    static void Main()
    {
        int numberOfLaptops = Convert.ToInt32(Console.ReadLine());
        
        int[,] laptops = new int[numberOfLaptops, 2];
        
        for(int i = 0; i < numberOfLaptops; i++)
        {
            string[] laptopAux = Console.ReadLine().Split();
            
            laptops[i, 0] = Convert.ToInt32(laptopAux[0]);
            laptops[i, 1] = Convert.ToInt32(laptopAux[1]);
        }
        
        if(IsHappy(laptops, numberOfLaptops))
            Console.WriteLine("Happy Alex");
        else
            Console.WriteLine("Poor Alex");
    }
}
