// Adrián Navarro, Cristina Francés, Sergio Ruescas

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Readme
{
    class Program
    {
        public static int Find(List<string> text, string word, int currentPosition)
        {
            bool found = false;
            do
            {
                if (text[currentPosition].ToUpper().Contains(word.ToUpper()))
                    return currentPosition;
                else
                    currentPosition++;
            } while (found == false);
            return -1;
        }

        static void Main(string[] args)
        {
            string name;
            List<string> data = new List<string>();
            ConsoleKeyInfo key;
            bool finished = false;
            int count = 0;

            if (args.Length > 0)
                name = args[0];
            else
            {
                Console.Write("Filename: ");
                name = Console.ReadLine();
            }

            if (!File.Exists(name))
                Console.WriteLine("File not found");
            else
            {
                string line;

                try
                {
                    StreamReader input = new StreamReader(name);

                    

                    do
                    {
                        line = input.ReadLine();

                        if (line != null)
                        {
                            data.Add(line);
                        }
                    } while (line != null);

                    input.Close();
                }
                catch (PathTooLongException)
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

                do
                {
                    for (int i = count; i < count + 24; i++)
                    {
                        if (data[i].Length > 79)
                        {
                            data[i] = data[i].Substring(0, 79);
                        }

                        Console.WriteLine(data[i]);

                        if (i == count + 22)
                        {
                            Thread.Sleep(500);
                            key = Console.ReadKey(true);

                            if (key.Key == ConsoleKey.UpArrow && count != 0)
                            {
                                count--;
                                i = count;
                            }
                            else if (key.Key == ConsoleKey.DownArrow &&
                                count != data.Count)
                            {
                                count++;
                                i = count;
                            }
                            else if (key.Key == ConsoleKey.PageDown &&
                                count + 24 < data.Count)
                            {
                                count += 23;
                                i = count - 1;
                            }
                            else if (key.Key == ConsoleKey.PageDown &&
                                count + 24 >= data.Count)
                            {
                                i = count - 25;
                            }
                            else if (key.Key == ConsoleKey.PageUp &&
                                count > 23)
                            {
                                count -= 23;
                                i = count;
                            }
                            else if (key.Key == ConsoleKey.PageUp &&
                                count <= 23)
                            {
                                i = 0;
                            }
                            else if (key.Key == ConsoleKey.Escape)
                                finished = true;

                            
                            Console.Clear();
                        }
                    }
                } while (!finished);
                
            }
        }
    }
}
