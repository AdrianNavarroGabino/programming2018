// Calculator (version 2)
// Adrián Navarro Gabino

using System;

public class Calculator2
{
    public static void Main()
    {
        string numString1 = "";
        
        do
        {
            bool goOn = false;
            double num1 = 0;
            double num2 = 0;
            char operation = 'a';
            
            
            while(!goOn)
            {
                try
                {
                    Console.Write("Number? ");
                    numString1 = Console.ReadLine();
                    if(numString1 != "")
                    {
                        num1 = Convert.ToDouble(numString1);
                        Console.Write("operation? ");
                        operation = Convert.ToChar(Console.ReadLine());
                        Console.Write("Number? ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    goOn = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            if(numString1 != "")
            {
                switch(operation)
                {
                    case '+':
                            Console.WriteLine("{0}{1}{2} = {3}",num1,
                                operation, num2, num1 + num2);
                            break;
                    case '-':
                            Console.WriteLine("{0}{1}{2} = {3}",num1,
                                operation, num2, num1 - num2);
                            break;
                    case 'x':
                    case 'X':
                    case '*':
                    case '·':
                            Console.WriteLine("{0}{1}{2} = {3}",num1,
                                operation, num2, num1 * num2);
                            break;
                    case '/':
                            Console.WriteLine("{0}{1}{2} = {3}",num1,
                                operation, num2, num1 / num2);
                            break;
                    default:
                            Console.WriteLine("Wrong operation");
                            break;
                }
            }
        } while(numString1 != "");
    }
    
}
