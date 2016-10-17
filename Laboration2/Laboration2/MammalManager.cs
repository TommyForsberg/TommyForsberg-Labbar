using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class MammalManager
    {
        public static List<Monkey> Monkeys { get; set; }
        public static List<Cat> Cats { get; set; }

        public MammalManager()
        {
            Monkeys = new List<Monkey>()
            {
                new Monkey  { Age = 10, Weight =72, Diet ="Bananas", ColorOfFur = "Black", Habitat = "Djungle", HoursOfSleep = 10,
                ColorOfEyes = "blue", NumberOfLegs = 2, IsColdBlooded = false },
                new Monkey  { Age = 5, Weight =70, Diet ="Grapes", ColorOfFur = "Black/Brown", Habitat = "Djungle", HoursOfSleep = 9,
                ColorOfEyes = "brown", NumberOfLegs = 2, IsColdBlooded = false }
            };

            Cats = new List<Cat>()
            {
                new Cat {NumberOfLegs = 4, Age = 4, Owner ="Katrin Johansson", Habitat ="Domesticated", Weight = 3, ColorOfFur = "Grey Spreckled", Diet = "Tuna"},
                new Cat {NumberOfLegs = 4, Age = 8, Owner ="Björn Svensson", Habitat ="Domesticated", Weight = 4, ColorOfFur = "Grey & Orange Spreckled", Diet = "Tuna"}
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
            Console.WriteLine("Color of eyes:");
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
        public void ListMonkeys()
        {
            AnimalManager animalManager = new AnimalManager();
            var mammals = new List<Mammal>(Monkeys);
            var animals = new List<Animal>(Monkeys);
            for (int i = 0; i < Monkeys.Count; i++)
            {
                Console.WriteLine("Monkey No" + (i + 1) + ":");
                Console.WriteLine(animalManager.ListAnimals(animals, i));
                Console.WriteLine(ListMammal(mammals, i));
                Console.WriteLine("Hours of sleep: {0} \tColor of eyes: {1}", Monkeys[i].HoursOfSleep, Monkeys[i].ColorOfEyes);
                Console.WriteLine();
            }
        }

        public void ListCats()
        {
            AnimalManager animalManager = new AnimalManager();
            var mammals = new List<Mammal>(Cats);
            var animals = new List<Animal>(Cats);
            for (int i = 0; i < Cats.Count; i++)
            {
                Console.WriteLine("Cat No" + (i + 1) + ":");
                Console.WriteLine(animalManager.ListAnimals(animals, i));
                Console.WriteLine(ListMammal(mammals, i));
                Console.WriteLine("Name: {0} \tOwner: {1}", Cats[i].Name, Cats[i].Owner);
                Console.WriteLine();
            }
        }

        public string ListMammal(List<Mammal> mammals, int i)
        {
            return String.Format("Color of fur: {0} \tDiet: {1} \tNumber of legs: {2}", mammals[i].ColorOfFur, mammals[i].Diet, mammals[i].NumberOfLegs);
        }

        public void DeleteMonkey()
        {
            Console.WriteLine("Choose who to delete:");
            int input = int.Parse(Console.ReadLine());
            Monkeys.RemoveAt(input - 1);
        }
        public void DeleteCat()
        {
            Console.WriteLine("Choose who to delete:");
            int input = int.Parse(Console.ReadLine());
            Cats.RemoveAt(input - 1);
        }
    }
}
