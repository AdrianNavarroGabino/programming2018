// Marks (if)
// Adrián Navarro Gabino

using System;

public class Notas
{
    public static void Main()
    {
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        
        if(mark == 10 || mark == 9)
            Console.WriteLine("Sobresaliente");
        else if(mark == 8 || mark == 7)
            Console.WriteLine("Notable");
        else if(mark == 6)
            Console.WriteLine("Bien");
        else if(mark == 5)
            Console.WriteLine("Aprobado");
        else if(mark < 5 && mark >= 0)
            Console.WriteLine("Suspenso");
        else
            Console.WriteLine("Wrong mark");
    }
}
