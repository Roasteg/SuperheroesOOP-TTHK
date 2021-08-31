using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace kangelased
{
    class Program
    {
        static List<Kangelane> kangelased;

        static void LaeKangelased(string filename)
        {
            var heroes = File.ReadAllLines(filename);
            foreach (var name in heroes)
            {
                var nameLocation = name.Split("/");
                if (nameLocation.Contains("*"))
                {
    
                }
                Console.WriteLine(nameLocation[0]);
                Console.WriteLine(nameLocation[1]);

            }
            
        }

        static void Main(string[] args)
        {
            SuperKangelane batman = new SuperKangelane("Batman", "Smalville");
            int sajast = batman.SavedPeople(100);
            int poolSajast = batman.SavedPeople(50);
            Console.WriteLine(batman);
            Console.WriteLine($"Sajast:{sajast}%");
            Console.WriteLine($"Pool Sajast:{poolSajast}");
            LaeKangelased("Superheroes.txt");
        }

    }
}
