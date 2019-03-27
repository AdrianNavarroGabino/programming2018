// Adrián Navarro Gabino

using System;
using System.IO;
using System.Collections.Generic;

class P1Files
{
    static void Main(string[] args)
    {
        string inputName;
        
        if(args.Length > 0)
            inputName = args[0];
        else
        {
            Console.Write("Input: ");
            inputName = Console.ReadLine();
        }
        
        if(!File.Exists(inputName))
            Console.WriteLine("File not found");
        else
        {
            try
            {
                StreamReader input = new StreamReader(inputName);
                List<string> data = new List<string>();
                string line;
                
                do
                {
                    line = input.ReadLine();
                    if(line != null)
                        data.Add(line);
                } while(line != null);
                input.Close();
                
                if(data[0] != "P1")
                    Console.WriteLine("Not a P1");
                else
                {
                    int sizeLine;
                    if(data[1].Substring(0,1) == "#")
                        sizeLine = 2;
                    else
                        sizeLine = 1;
                    
                    string[] aux = data[sizeLine].Split();
                    int width = Convert.ToInt32(aux[0]);
                    int height = Convert.ToInt32(aux[1]);
                    
                    int[,] image = new int[height, width];
                    int currX = 0;
                    int currY = 0;
                    
                    for(int i = sizeLine + 1; i < data.Count; i++)
                    {
                        for(int j = 0; j < data[i].Length; j++)
                        {
                            if( data[i][j] == '1' )
                            {
                                image[currX, currY] = 1;
                                currY = (currY + 1) % width;
                                if(currY == 0)
                                    currX++;
                            }
                            if( data[i][j] == '0' )
                            {
                                image[currX, currY] = 0;
                                currY = (currY + 1) % width;
                                if(currY == 0)
                                    currX++;
                            }
                        }
                    }
                    
                    for(int i = 0; i < height; i++)
                    {
                        for(int j = 0; j < width; j++)
                        {
                            if(image[i,j] == 0)
                                Console.Write("·");
                            if(image[i,j] == 1)
                                Console.Write("#");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("IO error");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
