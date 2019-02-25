// Adrián Navarro Gabino

using System;
using System.IO;
using System.Collections.Generic;

class ListAndMenu2
{
    static void Main()
    {
        List<string> myList;
        try
        {
            string[] aux = File.ReadAllLines("374.txt");
            myList = new List<string>(aux);
        }
        catch(Exception)
        {
            myList = new List<string>();
        }
        
        string option;

        do
        {
            Console.WriteLine();
            Console.WriteLine("A - Add");
            Console.WriteLine("V - View all");
            Console.WriteLine("F - Find");
            Console.WriteLine("I - Insert a new string");
            Console.WriteLine("E - Remove a string");
            Console.WriteLine("M - Modify a string");
            Console.WriteLine("O - Sort data");
            Console.WriteLine("Q - Quit");
            

            option = Console.ReadLine().ToUpper();
            switch (option)
            {
                case "A":
                    Console.Write("Enter some text to add: ");
                    myList.Add(Console.ReadLine());
                    break;
                case "V":
                    foreach (string s in myList)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                case "F":
                    Console.Write("Which text do you want to find: ");
                    string search = Console.ReadLine();
                    bool found = false;
                    foreach (string s in myList)
                    {
                        if (s.ToUpper().Contains(search.ToUpper()))
                        {
                            found = true;
                            Console.WriteLine(s);
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Not found!");
                    }
                    break;
                case "I":
                    Console.Write("In which position? ");
                    int position = Convert.ToInt32(Console.ReadLine()) -
                        1;
                    Console.Write("Enter some text to add: ");
                    myList.Insert(position, Console.ReadLine());
                    break;
                case "E":
                    Console.Write("In which position? ");
                    int positionRemove =
                        Convert.ToInt32(Console.ReadLine()) - 1;
                    if(positionRemove < myList.Count)
                        myList.RemoveAt(positionRemove);
                    else
                        Console.WriteLine("Wrong position");
                    break;
                case "M":
                    Console.Write("In which position? ");
                    int positionModify =
                        Convert.ToInt32(Console.ReadLine()) - 1;
                    if(positionModify < myList.Count)
                        myList[positionModify] = Console.ReadLine();
                    else
                        Console.WriteLine("Wrong position");
                    break;
                case "O":
                    myList.Sort();
                    break;
                case "Q":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
        while (option != "Q");
        
        File.WriteAllLines("374.txt", myList.ToArray());
    }
}
