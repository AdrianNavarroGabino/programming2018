// Adrián Navarro Gabino

using System;

public class FunctionInitials
{
    public static string Initials(string entry)
    {
        string init = "" + entry[0];
        
        for(int i = 1; i < entry.Length; i++)
        {
            if(entry[i - 1] == ' ' && entry[i] != ' ')
            {
                init += entry[i];
            }
        }
        
        init = init.ToUpper();
        
        return init;
    }
    
    public static void Main()
    {
        Console.WriteLine(Initials("Don Quijote de la Mancha"));
    }
}
