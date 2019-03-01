// Adrián Navarro Gabino

using System;

public class VideoCollection
{
    struct video
    {
        public string title;
        public int duration;
        public int size;
    }
    
    public static void Main()
    {
        const int SIZE = 1000;
        video[] v = new video[SIZE];
        
        int option;
        int position = 0;
        string search;
        video vAux;
        
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add video");
            Console.WriteLine("2. See all videos");
            Console.WriteLine("3. Search a video");
            Console.WriteLine("4. Sort by size");
            Console.WriteLine("0. Exit");
            
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if(option == 1)
            {
                if(position < SIZE)
                {
                    Console.Write("Enter the title of video #{0}: ",
                        position+1);
                    v[position].title = Console.ReadLine();
                    Console.Write("Enter the duration in seconds: ");
                    v[position].duration = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the size in kb: ");
                    v[position].size = Convert.ToInt32(Console.ReadLine());
                    
                    position++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Database full");
                    Console.WriteLine();
                }
            }
            else if(option == 2)
            {
                for(int i = 0; i < position; i++)
                {
                    Console.WriteLine("Video number {0}:", i+1);
                    Console.WriteLine("Title: " + v[i].title);
                    Console.WriteLine("Duration: " + v[i].duration +
                        " seconds");
                    Console.WriteLine("Size: " + v[i].size + "kb");
                    
                    Console.WriteLine();
                }
            }
            else if(option == 3)
            {
                Console.Write("Enter the video to search: ");
                search = Console.ReadLine().ToUpper();
                
                for(int i = 0; i < position; i++)
                {
                    if(v[i].title.ToUpper().Contains(search))
                    {
                        Console.WriteLine("Video number {0}:", i+1);
                        Console.WriteLine("Title: " + v[i].title);
                        Console.WriteLine("Duration: " + v[i].duration +
                            " seconds");
                        Console.WriteLine("Size: " + v[i].size + "kb");
                        
                        Console.WriteLine();
                    }
                }
            }
            else if(option == 4)
            {
                for(int i = 0; i < position - 1; i++)
                {
                    for(int j = i + 1; j < position; j++)
                    {
                        if(v[i].size > v[j].size)
                        {
                            vAux.title = v[i].title;
                            vAux.duration = v[i].duration;
                            vAux.size = v[i].size;
                            
                            v[i].title = v[j].title;
                            v[i].duration = v[j].duration;
                            v[i].size = v[j].size;
                            
                            v[j].title = vAux.title;
                            v[j].duration = vAux.duration;
                            v[j].size = vAux.size;
                        }
                    }
                }
            }
        } while(option != 0);
    }
}
