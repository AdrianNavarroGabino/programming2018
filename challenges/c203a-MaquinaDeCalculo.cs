/*
    Calculates basic operations
*/

/*
Example of input
5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13
Example of output
-8
5
21
ERROR
-8
*/

// Adrián Navarro Gabino

using System;

public class MaquinaDeCalculo
{
    public static void Main()
    {
        ushort casosPrueba = Convert.ToUInt16(Console.ReadLine());
        
        string[] datos;
        
        for(ushort i = 0; i < casosPrueba; i++)
        {
            datos = Console.ReadLine().Split();
            
            switch(datos[1])
            {
                case "+":
                    Console.WriteLine(Convert.ToInt16(datos[0]) +
                        Convert.ToInt16(datos[2]));
                    break;
                case "-":
                    Console.WriteLine(Convert.ToInt16(datos[0]) -
                        Convert.ToInt16(datos[2]));
                    break;
                case "*":
                    Console.WriteLine(Convert.ToInt16(datos[0]) *
                        Convert.ToInt16(datos[2]));
                    break;
                case "/":
                    if(datos[2] != "0")
                        Console.WriteLine(Convert.ToInt16(datos[0]) /
                            Convert.ToInt16(datos[2]));
                    else
                        Console.WriteLine("ERROR");
                    break;
                default:
                    break;
            }
        }
    }
}
