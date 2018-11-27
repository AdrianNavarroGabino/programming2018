// Marks (switch)
// Adrián Navarro Gabino

using System;

public class NotasSwitch
{
    public static void Main()
    {
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        
        switch(mark)
        {
            case 10:
            case 9: Console.WriteLine("Sobresaliente"); break;
            case 8:
            case 7: Console.WriteLine("Notable"); break;
            case 6: Console.WriteLine("Bien"); break;
            case 5: Console.WriteLine("Aprobado"); break;
            case 4:
            case 3:
            case 2:
            case 1:
            case 0: Console.WriteLine("Suspenso"); break;
            default: Console.WriteLine("Wrong mark"); break;
        }
    }
}
