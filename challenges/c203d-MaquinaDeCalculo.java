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

import java.util.*;

public class MaquinaDeCalculo
{
    public static void main(String[] args)
    {
        Scanner entrada = new Scanner(System.in);
        Scanner entrada2 = new Scanner(System.in);
        
        short casosPrueba = entrada.nextShort();
        
        String[] datos;
        
        for(int i = 0; i < casosPrueba; i++)
        {
            datos = entrada2.nextLine().split(" ");
            
            switch(datos[1])
            {
                case "+":
                    System.out.println(Short.parseShort(datos[0]) +
                        Short.parseShort(datos[2]));
                    break;
                case "-":
                    System.out.println(Short.parseShort(datos[0]) -
                        Short.parseShort(datos[2]));
                    break;
                case "*":
                    System.out.println(Short.parseShort(datos[0]) *
                        Short.parseShort(datos[2]));
                    break;
                case "/":
                    try
                    {
                        System.out.println(Short.parseShort(datos[0]) /
                            Short.parseShort(datos[2]));
                    }
                    catch(ArithmeticException e)
                    {
                        System.out.println("ERROR");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
