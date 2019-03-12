// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

public class Spaceships
{
    struct Spaceship : IComparable<Spaceship>
    {
        public int oxigen;
        public int weight;

        public int CompareTo(Spaceship s2)
        {
            if (this.weight != s2.weight)
            {
                return weight.CompareTo(s2.weight);
            }
            else
            {
                return s2.oxigen.CompareTo(this.oxigen);
            }
        }
    }

    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            int minimumO2 = Convert.ToInt32(Console.ReadLine());
            int spaceships = Convert.ToInt32(Console.ReadLine());
            List<Spaceship> spcs = new List<Spaceship>();



            for (int j = 0; j < spaceships; j++)
            {
                Spaceship s = new Spaceship();

                string[] data = Console.ReadLine().Split();
                s.oxigen = Convert.ToInt32(data[0]);
                s.weight = Convert.ToInt32(data[1]);

                spcs.Add(s);
            }

            spcs.Sort();

            Console.WriteLine("Caso " + i + ":");
            for(int j = 0; j < spaceships; j++)
            {
                Console.WriteLine(spcs[j].oxigen + " " + spcs[j].weight);
            }
        }
    }
}
