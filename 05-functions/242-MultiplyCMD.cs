// Adrián Navarro Gabino

using System;

public class MultiplyCMD
{
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    
    public static void Main(string[] args)
    {
        if(args.Length >= 2)
        {
            Console.WriteLine(
                Multiply(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
        }
    }
}
