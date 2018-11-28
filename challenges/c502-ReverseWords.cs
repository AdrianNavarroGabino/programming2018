/*
Sample Input 
3
this is a test
foobar
all your base
Output 
Case #1: test a is this
Case #2: foobar
Case #3: base your all
*/

// Adrián Navarro Gabino

using System;

public class ReverseWords
{
    public static void Main()
    {
        byte cases = Convert.ToByte(Console.ReadLine());
        
        for(int i = 0; i < cases; i++)
        {
            string[] sentence = Console.ReadLine().Split();
            
            Console.Write("Case #{0}: ", i+1);
            for(int j = sentence.Length - 1; j > 0; j--)
            {
                Console.Write(sentence[j] + " ");
            }
            Console.WriteLine(sentence[0]);
        }
    }
}
