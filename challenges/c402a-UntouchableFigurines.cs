/*
Example input
6
4 4
XXXX
XXXX
XXXX
XXXX
3 3
XXX
XFX
XXX
3 3
XXX
FXX
XXX
4 3
XXXX
FXFX
XXXX
6 6
XXXXXX
XFXXFX
XXXXXX
XFXFXX
XXXXXX
XXXXXX
3 3
XFX
XXX
XXX
Example output
INVALIDA
VALIDA
INVALIDA
INVALIDA
VALIDA
INVALIDA
*/

// Adrián Navarro Gabino

using System;

public class UntouchableFigurines
{
    public static void Main()
    {
        byte cases = Convert.ToByte(Console.ReadLine());
        
        for(byte actualCase = 0; actualCase < cases; actualCase++)
        {
            string[] auxSize = Console.ReadLine().Split();
            
            byte width = Convert.ToByte(auxSize[0]);
            byte height = Convert.ToByte(auxSize[1]);

            char[,] floor = new char[height, width];

            for (byte ii = 0; ii < height; ii++)
            {
                string line = Console.ReadLine();

                for (byte jj = 0; jj < width; jj++)
                {
                    floor[ii, jj] = Convert.ToChar(line[jj]);
                }
            }

            bool valid = true;
            byte figure = 0;

            byte i = 0;
            

            while (valid && i < height)
            {
                byte j = 0;
                while (valid && j < width)
                {
                    if (floor[i, j] == 'F')
                    {
                        figure++;
                        if (i == 0 || j == 0 ||
                           i == height - 1 || j == width - 1)
                        {
                            valid = false;
                        }
                        else if (floor[i + 1, j] == 'F' ||
                                floor[i, j + 1] == 'F' ||
                                floor[i + 1, j + 1] == 'F' ||
                                floor[i + 1, j - 1] == 'F')
                        {
                            valid = false;
                        }
                    }
                    j++;
                }
                i++;
            }

            if (valid & figure > 0)
            {
                Console.WriteLine("VALIDA");
            }
            else
            {
                Console.WriteLine("INVALIDA");
            }
        }
    }
}

