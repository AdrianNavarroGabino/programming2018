// Adrián Navarro Gabino

using System;

public class Change
{
    public static void Main()
    {
        Console.Write("Precio? ");
        int precio = Convert.ToInt32(Console.ReadLine());
        Console.Write("Pagado? ");
        int pagado = Convert.ToInt32(Console.ReadLine());
        
        int devolver = pagado - precio;
        
        Console.Write("Tu cambio es {0}: ",devolver);
        
        while(devolver >= 100)
        {
            Console.Write("{0} ", 100);
            devolver = devolver - 100;
        }
        
        while(devolver >= 10)
        {
            Console.Write("{0} ", 10);
            devolver = devolver - 10;
        }
        
        while(devolver >= 5)
        {
            Console.Write("{0} ", 5);
            devolver = devolver - 5;
        }
        
        while(devolver >= 1)
        {
            Console.Write("{0} ", 1);
            devolver = devolver - 1;
        }
        Console.WriteLine();
        
    }
}
