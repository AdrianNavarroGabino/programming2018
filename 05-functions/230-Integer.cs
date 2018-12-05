// Adrián Navarro Gabino

using System;

public class Integer
{
    public static bool IsInteger(string entry)
    {
        for(int i = 0; i < entry.Length; i++)
        {
            switch(entry[i])
            {
                case '1': break;
                case '2': break;
                case '3': break;
                case '4': break;
                case '5': break;
                case '6': break;
                case '7': break;
                case '8': break;
                case '9': break;
                case '0': break;
                default: return false;
            }
        }
        return true;
    }
    
    
    public static void Main()
    {
        if(IsInteger("1234"))
            Console.WriteLine("Is integer");
    }
}
