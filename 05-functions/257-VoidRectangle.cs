// Adrián Navarro Gabino

using System;

public class VoidRectangle
{
    public static void DibujarRectanguloHueco(
                                int width, int height, char symbol)
    {
        string row1 = new string(symbol, width);
        
        string row2 = new string( ' ', width - 2);
        row2 = symbol + row2 + symbol;
        
        Console.WriteLine(row1);
        for(int i = 0; i < height - 2; i++)
            Console.WriteLine(row2);
        Console.WriteLine(row1);
    }
    public static void Main()
    {
        int width = 10;
        int height = 4;
        char symbol = '*';
        
        DibujarRectanguloHueco(width, height, symbol);
    }
}
