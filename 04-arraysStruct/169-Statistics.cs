// Adrián Navarro Gabino

using System;

public class Statistics
{
    public static void Main()
    {
        int option;
        int numberOfData = 0;
        double[] data = new double[1000];
        
        double search;
        
        bool isIn = false;
        
        double addition;
        double average;
        double maximum;
        double minimum;
        
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add data");
            Console.WriteLine("2) Show data");
            Console.WriteLine("3) Search");
            Console.WriteLine("4) Show statistics summary");
            Console.WriteLine("0) Exit");
            
            option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter data #{0}",
                            numberOfData + 1);
                        data[numberOfData] =
                            Convert.ToDouble(Console.ReadLine());
                        numberOfData++;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Wrong data");
                    }
                    break;
                case 2:
                    Console.WriteLine("Entered data:");
                    for(int i = 0; i < numberOfData; i++)
                        Console.WriteLine(data[i]);
                    break;
                case 3:
                    Console.WriteLine("Enter data to search:");
                    search = Convert.ToDouble(Console.ReadLine());
                    
                    for(int i = 0; i < numberOfData; i++)
                    {
                        if(search == data[i])
                            isIn = true;
                    }
                    if(isIn)
                        Console.WriteLine("{0} is in the data", search);
                    else
                        Console.WriteLine("{0} is not in the data",
                            search);
                    break;
                case 4:
                    Console.WriteLine("Amount of data: " + numberOfData);
                    
                    addition = 0;
                    for(int i = 0; i < numberOfData; i++)
                        addition += data[i];
                    Console.WriteLine("Addition: " + addition);
                    
                    average = addition / numberOfData;
                    Console.WriteLine("Average: " + average);
                    
                    maximum = minimum = data[0];
                    for(int i = 0; i < numberOfData; i++)
                    {
                        if(data[i] > maximum)
                            maximum = data[i];
                        if(data[i] < minimum)
                            minimum = data[i];
                    }
                    Console.WriteLine("Maximum: " + maximum);
                    Console.WriteLine("Minimum: " + minimum);
                    
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        } while(option != 0);
    }
}
