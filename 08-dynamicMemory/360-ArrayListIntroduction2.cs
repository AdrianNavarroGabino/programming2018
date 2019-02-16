// Adrián Navarro Gabino

using System;
using System.Collections;

class ArrayListIntroduction2
{
    static void Main()
    {
        ArrayList myList = new ArrayList();
        
        string numberAux;
        int number;
        
        do
        {
            Console.Write("Enter a whole number: ");
            numberAux = Console.ReadLine();
            
            if(numberAux != "")
            {
                number = Convert.ToInt32(numberAux);
                myList.Add(number);
            }
        } while(numberAux != "");
        
        int position;
        
        do
        {
            Console.Write("Enter a position: ");
            position = Convert.ToInt32(Console.ReadLine());
            if(position != 0)
                Console.WriteLine(myList[position - 1]);
        }while(position != 0);
    }
}
