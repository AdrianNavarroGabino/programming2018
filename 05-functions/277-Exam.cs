// Adrián Navarro Gabino

using System;

public class Exam
{
    public static bool IsPrime(long x)
    {
        for(long i = 2; i < x / 2; i++)
        {
            if(x % i == 0)
                return false;
        }
        
        return true;
    }
    
    public static bool IsCircularPrime(long x)
    {
        string aux = x.ToString();
        long y;
        int size = aux.Length;
        
        for(int i = 0; i < size; i++)
        {
            aux = aux.Substring(1, size - 1) + aux[0];
            y = Convert.ToInt64(aux);
            
            if(!IsPrime(y))
                return false;
        }
        
        return true;
    }
    
    public static void DibujarParalelogramo(int w, int h, char s)
	{
		string row1 = new string(s, w);
		string spaces = new string(' ', w - 2);
		
		Console.WriteLine(row1);
		for(int i = 1; i < h - 1; i++)
		{
			for(int j = 0; j < i; j++)
			{
				Console.Write(" ");
			}
			Console.Write(s);
			Console.Write(spaces);
			Console.WriteLine(s);
		}
		for(int i = 0; i < h - 1; i++)
		{
			Console.Write(" ");
		}
		Console.WriteLine(row1);
	}
    
    public static void ContarMm(string text, ref int upper,
		ref int lower)
	{
		upper = lower = 0;
		
		foreach(char c in text)
		{
			if(c != ' ')
			{
				string aux = c + "";
				if(aux.ToLower() == aux)
					lower++;
				else
					upper++;
			}
		}
	}
    
    public static long McdR(long a, long b)
	{
		long greatest;
		long lowest;
		
		if(a >= b)
		{
			greatest = a;
			lowest = b;
		}
		else
		{
			greatest = b;
			lowest = a;
		}
		
		if(lowest == 0)
		{
			return greatest;
		}
		
		return McdR(lowest, greatest % lowest);
		
	}
	
	public static long Mcd(long a, long b)
	{
		long greatest;
		long lowest;
		
		if(a >= b)
		{
			greatest = a;
			lowest = b;
		}
		else
		{
			greatest = b;
			lowest = a;
		}
		
		long mcd = 1;
		
		for(int i = 1; i <= lowest; i++)
		{
			if(lowest % i == 0 && greatest % i == 0)
				mcd = i;
		}
		
		return mcd;
	}
    
    
    
    public static int Main(string[] args)
    {
        if(args.Length == 0 ||
            (args[0].ToLower().CompareTo("cprime") != 0 &&
            args[0].ToLower().CompareTo("mm") != 0 &&
            args[0].ToLower().CompareTo("para") != 0 &&
            args[0].ToLower().CompareTo("mcd") != 0))
        {
            Console.WriteLine("Uso: cprime / mm / para / mcd");
            return 1;
        }
        else
        {
            if(args[0].ToLower() != "cprime")
            {
                if(args.Length < 2)
                {
                    Console.WriteLine("Faltan parámetros");
                    return 2;
                }
                else
                {
                    if(IsCircularPrime(Convert.ToInt64(args[1])))
                        Console.WriteLine(args[1] +
                            " is a circular prime");
                    else
                        Console.WriteLine(args[1] +
                                            " is not a circular prime");
                    return 0;
                }
            }
            else if(args[0].ToLower() != "mm")
            {
                if(args.Length < 2)
                {
                    Console.WriteLine("Faltan parámetros");
                    return 2;
                }
                else
                {
                    int upper = 0;
                    int lower = 0;
                    
                    ContarMm(args[1], ref upper, ref lower);
		
                    Console.WriteLine("Mayúsculas: " + upper +
                        ", minúsculas: " + lower);
                    return 0;
                }
                
            }
            else if(args[0].ToLower() != "para")
            {
                if(args.Length < 3)
                {
                    Console.WriteLine("Faltan parámetros");
                    return 2;
                }
                else
                {
                    DibujarParalelogramo(Convert.ToInt32(args[1]),
                                    Convert.ToInt32(args[2]), '#');
                    return 0;
                }
            }
            else if(args[0].ToLower() != "mcd")
            {
                if(args.Length < 3)
                {
                    Console.WriteLine("Faltan parámetros");
                    return 2;
                }
                else
                {
                    Console.WriteLine(McdR(Convert.ToInt64(args[1]),
                                    Convert.ToInt64(args[2])));
                    return 0;
                }
            }
            return 0;
        }
    }
}
