// Adrián Navarro Gabino

using System;

public class MultiplyCMD2
{
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    
    public static int Main(string[] args)
    {
        try
        {
            if(args.Length >= 2)
            {
                Console.WriteLine(
                    Multiply(
                        Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
            }
            else
            {
                Console.WriteLine("Not enough parameters");
            }
            
            return 0;
        }
        catch(Exception)
        {
            Console.WriteLine("Error");
            return 1;
        }
    }
}
