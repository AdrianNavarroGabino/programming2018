// "char" - if & switch
// Adrián Navarro Gabino

using System;

public class CharIfSwitch
{
    public static void Main()
    {
        bool continuar = false;
        char caracter = 'a';
        
        while(!continuar)
        {
            try
            {
                Console.Write("Enter a character: ");
                caracter = Convert.ToChar(Console.ReadLine());
                continuar = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                continuar = false;
            }
        }
        
        if('0' <= caracter && caracter <= '9')
            Console.WriteLine("It's a digit");
        else if(caracter == '+' || caracter == '-' || caracter == '*' ||
                caracter == '/' || caracter == '%')
            Console.WriteLine("It's an operator");
        else if(caracter == '.' || caracter == ',' || caracter == ';' ||
                caracter == ':')
            Console.WriteLine("It's a puntuation symbol");
        else
            Console.WriteLine("Wrong character");
        
        switch(caracter)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': Console.WriteLine("It's a digit"); break;
            case '+':
            case '-':
            case '*':
            case '/':
            case '%': Console.WriteLine("It's an operator"); break;
            case '.':
            case ',':
            case ';':
            case ':': Console.WriteLine("It's a puntuation symbol"); break;
            default: Console.WriteLine("Wrong character"); break;
        }
    }
}
