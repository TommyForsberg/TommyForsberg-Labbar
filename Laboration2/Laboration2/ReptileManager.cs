using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class ReptileManager
    {
        public List<Crocodile> Crocodiles { get; set; }
        public List<Snake> Snakes { get; set; }

        public ReptileManager()
        {
            Crocodiles = new List<Crocodile>()
            {
                new Crocodile {Age = 45, CanRun = true, DaysOfStarving = 21, ColorOfScale = "Dark Green", Weight = 110},
                new Crocodile {Age = 14, CanRun = true, DaysOfStarving = 2, ColorOfScale = "Dark Green", Weight = 115}
            };

            Snakes = new List<Snake>()
            {
                new Snake { NumberOfTeeth = 6, Weight = 3.2, Habitat = "Desert & Forest", Sound = "Rattle", Age = 3 }
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



        }

        public void AddSnake()
        {
            Snake newSnake = new Snake();
            newSnake.IsVenomous = true;
            Console.WriteLine("Sound:");
            newSnake.Sound = Console.ReadLine();
            AddReptile(newSnake);
        }
    }
}
