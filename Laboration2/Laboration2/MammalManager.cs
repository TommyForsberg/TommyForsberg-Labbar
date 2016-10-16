using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class MammalManager
    {
        public List<Monkey> Monkeys { get; set; }
        public List<Cat> Cats { get; set; }

        public MammalManager()
        {
            Monkeys = new List<Monkey>()
            {
                new Monkey  { Age = 10, Weight =72 }
            };

            Cats = new List<Cat>()
            {
                new Cat {Age = 4, Owner ="Katrin Johansson", Habitat ="Domesticated", Weight = 3, ColorOfFur = "Grey Spreckled", Diet = "Tuna"},
                new Cat {Age = 8, Owner ="Björn Svensson", Habitat ="Domesticated", Weight = 4, ColorOfFur = "Grey & Orange Spreckled", Diet = "Tuna"}
            };
        }

        public void AddMammal(Mammal newMammal)
        {
            Console.WriteLine("Color of fur:");
            newMammal.ColorOfFur = Console.ReadLine();
            Console.WriteLine("Diet:");
            newMammal.Diet = Console.ReadLine();
            Console.WriteLine("Number of legs:");
            newMammal.NumberOfLegs = int.Parse(Console.ReadLine());
            var animalManager = new AnimalManager();
            animalManager.AddAnimal(newMammal);
        }
        

        public void AddMonkey()
        {
            Monkey newMonkey = new Monkey();
            Console.WriteLine("Hours of sleep:");
            newMonkey.HoursOfSleep = int.Parse(Console.ReadLine());
            Console.WriteLine("Color of eyes");
            newMonkey.ColorOfEyes = Console.ReadLine();
            AddMammal(newMonkey);

        }

        public void AddCat()
        {
            Cat newCat = new Cat();
            Console.WriteLine("Owner:");
            newCat.Owner = Console.ReadLine();
            Console.WriteLine("Name:");
            newCat.Name = Console.ReadLine();
            AddMammal(newCat);
        }
    }
}
