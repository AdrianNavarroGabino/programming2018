// Adrián Navarro Gabino

using System;

public class InsertarPosicion
{
    public static void Main()
    {
        string contacto;
        byte posicionContacto;
        
        string[] amigos = new string[100];
        byte posicion = 0;
        
        Console.WriteLine("Elige una opción:\n1- Añadir\n2- Ver todos\n" +
            "3- Insertar entre dos datos existentes\n0- Salir");
        byte opcion = Convert.ToByte(Console.ReadLine());
        while(opcion != 0)
        {
            if(opcion == 1)
            {
                if(posicion < 100)
                {
                    Console.WriteLine("Escribe el nombre:");
                    amigos[posicion] = Console.ReadLine();
                    posicion++;
                }
                else
                {
                    Console.WriteLine("Memoria insuficiente");
                }
            }
            else if(opcion == 2)
            {
                for(byte i = 0; i < posicion; i++)
                {
                    Console.WriteLine("Amigo " + (i+1) + ": " + amigos[i]);
                }
            }
            else if(opcion == 3)
            {
                if(posicion < 100)
                {
                    Console.WriteLine("Amigo:");
                    contacto = Console.ReadLine();
                    Console.WriteLine("Posición:");
                    posicionContacto = Convert.ToByte(Console.ReadLine());
                    posicion++;
                    
                    for(int i = posicion; i > posicionContacto - 1; i--)
                    {
                        amigos[i] = amigos[i - 1];
                    }
                    
                    amigos[posicionContacto - 1] = contacto;
                }
                else
                {
                    Console.WriteLine("Memoria insuficiente");
                }
            }
            
            Console.WriteLine();
            
            Console.WriteLine("Elige una opción:\n1- Añadir\n2- Ver todos\n" +
                "3- Insertar entre dos datos existentes\n0- Salir");
            opcion = Convert.ToByte(Console.ReadLine());
        }
        
        Console.WriteLine("Adeu-siau");
    }
}
