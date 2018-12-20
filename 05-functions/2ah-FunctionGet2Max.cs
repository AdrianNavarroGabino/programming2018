// Adrián Navarro Gabino

using System;

public class FunctionGet2Max
{
    public static int Get2Max(
                            float[] data, ref float max, ref float second)
    {
        for(int i = 0; i < data.Length - 1; i++)
        {
            for(int j = i + 1; j < data.Length; j++)
            {
                if(data[i] < data[j])
                {
                    float aux = data[i];
                    data[i] = data[j];
                    data[j] = aux;
                }
            }
        }
        
        max = data[0];
        for(int i = 1; i < data.Length; i++)
        {
            if(data[i] < max)
            {
                second = data[i];
                return 0;
            }
        }
        second = data[0];
        return 0;
    }
    
    
    public static void Main()
    {
        float[] data = {2f, 7.5f, 6f, -1f, 20f, 5f};
        float max = 0;
        float second = 0;
        
        Get2Max(data, ref max, ref second);
        Console.WriteLine("Max number is " + max +
            ", the second one is " + second);
            
        float[] data2 = {20f, 7.5f, 6f, -1f, 20f, 5f};
        
        Get2Max(data2, ref max, ref second);
        Console.WriteLine("Max number is " + max +
            ", the second one is " + second);
            
        float[] data3 = {5f, 5f, 5f};
        
        Get2Max(data3, ref max, ref second);
        Console.WriteLine("Max number is " + max +
            ", the second one is " + second);
    }
}
