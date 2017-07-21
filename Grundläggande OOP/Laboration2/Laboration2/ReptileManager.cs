using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class ReptileManager
    {
        public static List<Crocodile> Crocodiles { get; set; }
        public static List<Snake> Snakes { get; set; }

        public ReptileManager()
        {
            Crocodiles = new List<Crocodile>()
            {
                new Crocodile {Age = 45, CanRun = true, DaysOfStarving = 21,
                    NumberOfTeeth = 80, Habitat = "Muddy River", HasEatenHuman = false,  IsColdBlooded = true, ColorOfScale = "Dark Green", Weight = 110},
                new Crocodile {Age = 14, CanRun = true, DaysOfStarving = 2, ColorOfScale = "Dark Green", Weight = 115},
                 new Crocodile {Age = 102, CanRun = true, DaysOfStarving = 90,
                    NumberOfTeeth = 100, Habitat = "River & Lake", HasEatenHuman = true,  IsColdBlooded = true, ColorOfScale = "Dark Black", Weight = 300},
            };

            Snakes = new List<Snake>()
            {
                new Snake { NumberOfTeeth = 6, Weight = 3.2, Habitat = "Desert & Forest", Sound = "Rattle", Age = 3, IsColdBlooded = true, CanRun = false,
                ColorOfScale = "Black & Yellow", IsVenomous = true},
                new Snake { NumberOfTeeth = 6, Weight = 0.2, Habitat = "Forest", Sound = "Rattle", Age = 1, IsColdBlooded = true, CanRun = false,
                ColorOfScale = "Black", IsVenomous = true}
            };
        }

        public void AddReptile(Reptile newReptile)
        {
            Console.WriteLine("Color of scale" );
            newReptile.ColorOfScale = Console.ReadLine();
            Console.WriteLine("Number of teeth");
            newReptile.NumberOfTeeth = int.Parse(Console.ReadLine());
            var animalManager = new AnimalManager();
            animalManager.AddAnimal(newReptile);
        }

        public void AddCrocodile()
        {
            Crocodile newCrocodile = new Crocodile();
            Console.WriteLine("Days of starving:");
            newCrocodile.DaysOfStarving = int.Parse(Console.ReadLine());
            Console.WriteLine("Has eaten human: (yes/no)");
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
                newCrocodile.HasEatenHuman = true;
            else
                newCrocodile.HasEatenHuman = false;
            AddReptile(newCrocodile);


        }

        public void AddSnake()
        {
            Snake newSnake = new Snake();
            newSnake.IsVenomous = true;
            Console.WriteLine("Sound:");
            newSnake.Sound = Console.ReadLine();
            AddReptile(newSnake);
        }

        public void ListCrocodiles()
        {
            AnimalManager animalManager = new AnimalManager();
            var reptiles = new List<Reptile>(Crocodiles);
            var animals = new List<Animal>(Crocodiles);
            for (int i = 0; i < Crocodiles.Count; i++)
            {
                Console.WriteLine("Crocodile No" + (i + 1) + ":");
                Console.WriteLine(animalManager.ListAnimals(animals, i));
                Console.WriteLine(ListReptiles(reptiles, i));
                Console.WriteLine("Has eaten human: {0} \tDays of starving: {1}", Crocodiles[i].HasEatenHuman , Crocodiles[i].DaysOfStarving);
                Console.WriteLine();
            }

        }

        public void ListSnakes()
        {
            AnimalManager animalManager = new AnimalManager();
            var reptiles = new List<Reptile>(Snakes);
            var animals = new List<Animal>(Snakes);
            for (int i = 0; i < Snakes.Count; i++)
            {
                Console.WriteLine("Snake No" + (i + 1) + ":");
                Console.WriteLine(animalManager.ListAnimals(animals, i));
                Console.WriteLine(ListReptiles(reptiles, i));
                Console.WriteLine("Sound: {0} \tIs Venomous: {1}", Snakes[i].Sound, Snakes[i].IsVenomous );
                Console.WriteLine();
            }
        }

        public string ListReptiles(List<Reptile> reptiles, int i)
        {
            return String.Format("Color of scale: {0} \tNumber of teeth: {1}", reptiles[i].ColorOfScale, reptiles[i].NumberOfTeeth);
        }

        public void DeleteCrocodile()
        {
            Console.WriteLine("Choose who to delete:");
            int input = int.Parse(Console.ReadLine());
            Crocodiles.RemoveAt(input - 1);
        }

        public void DeleteSnake()
        {
            Console.WriteLine("Choose who to delete:");
            int input = int.Parse(Console.ReadLine());
            Snakes.RemoveAt(input - 1);
        }



    }
}
