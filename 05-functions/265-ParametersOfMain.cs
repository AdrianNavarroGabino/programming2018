/*
Create a “Main” function to test these functions. It must analyze the command 
line parameters (which can be uppercase, lowercase or mixed case) and must 
behave as follows (2 points):
    * If "sum" is the first parameter, followed by an integer number, (sum 97), 
    it will display the sum of the digits of that number (e.g. 7).
    * If "second" is the first parameter, followed by three numbers (second 7 9 
    8), it will display the second highest value of those three (e.g. 8).
    * If "boxed" is the first parameter, followed by a text (boxed Exam), it 
    will display that text boxed.
    * If "digits" is the first parameter, followed by an integer number (digits 
    34), the program will display the amount of digits in that number.
    * If no parameters are used, or an incorrect first parameter is specified, 
    it will display "Usage: sum / second / boxed /  digits" and return to 
    operating system with error code 1. Also, if fewer parameters than expected 
    are used (ie: "sum" and no number, "second" and less than three numbers, 
    and so on), it will display "Missing parameters" and return to operating 
    system with error code 2. If everything is correct, it will return to 
    operating system with error code 0.
*/

// Adrián Navarro Gabino

using System;

public class ParametersOfMain

{
    public static int Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: sum / second / boxed /  digits");
            return 1;
        }
        else
        {
            switch(args[0].ToLower())
            {
                case "sum":
                    if (args.Length <= 2)
                        Console.WriteLine(SumDigits(
                            Convert.ToInt32(args[1])));
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;

                case "boxed":
                    if (args.Length <= 2)
                        DisplayTextBoxed(args[1]);
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;

                case "second":
                    if (args.Length <= 4)
                    { 
                        float max, second;
                        float[] data = { 
                            Convert.ToSingle(args[1]),
                            Convert.ToSingle(args[2]),
                            Convert.ToSingle(args[3]) };
                        Get2Max(data, out max, out second);

                        Console.WriteLine("Maximum is " + max + ", second is " + second);
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;

                case "digits":
                    if (args.Length <= 2)
                    { 
                        Console.WriteLine(AmountOfDigits(
                            Convert.ToUInt32(args[1])));
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;

                default:
                    Console.WriteLine("Usage: sum / second / boxed /  digits");
                    break;
            }
            return 0;
        } 
    }
    
    static int SumDigits(int num)
    {
        string digits = num.ToString();
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Convert.ToInt32(
                digits.Substring(i,1));
        }
        return sum;
    }

    public static void DisplayTextBoxed(string s)
    {
        Console.WriteLine("+" + new string('-', s.Length+4) + "+");
        Console.WriteLine("|  " + s + "  |");
        Console.WriteLine("+" + new string('-', s.Length + 4) + "+");
    }

    static void Get2Max(float[] data, out float max, out float segundo)
    {
        max = data[0];
        segundo = data[0];
        foreach(float d in data)
        {
            if (d < max) max = d;
            if (d < segundo) segundo = d;
        }

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > max)
            {
                if (segundo < max)
                    segundo = max;
                max = data[i];
            }
            else if ((data[i] > segundo) && (data[i] < max))
            {
                segundo = data[i];
            }
        }
    }

    public static int AmountOfDigits(uint num)
    {
        int digits = 1;        
        while(num / 10 != 0)
        {
            num /= 10;
            digits++;
        }        
        return digits;
    }

}
