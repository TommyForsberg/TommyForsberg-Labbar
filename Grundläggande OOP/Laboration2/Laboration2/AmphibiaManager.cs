using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class AmphibiaManager
    {
        public static List<Frog> Frogs { get; set; }
        public static List<Toad> Toads { get; set; }


        public AmphibiaManager()
        {
            Frogs = new List<Frog>()
                {
                   new Frog {ColorOfSkin = "Grey", JumpLength = 2, Pattern = "Spreckled", Age = 1, Weight = 0.4},
                   new Frog { ColorOfSkin = "Green", JumpLength = 5, Weight = 0.2, Age = 2, Habitat = "Water & Forest", Pattern = "Camouflage" },
                   new Frog { ColorOfSkin = "Grey & Green", Weight = 0.15, Age = 1, Habitat = "Water", JumpLength = 6 }
                };

            Toads = new List<Toad>()
                {
                    new Toad {ColorOfSkin = "Purple", Metamorphosis = true, Weight = 0.3, CanSwim = true,
                     Habitat = "Mud & Lakes", Age = 3},
                    new Toad {ColorOfSkin = "Purple/Black", Metamorphosis = true, Weight = 0.8, CanSwim = true,
                     Habitat = "Rivers", Age = 9}
                };
        }

        public void AddAmphibia(Amphibia newAmphibia)
        {
            Console.WriteLine("Color of skin: ");
            newAmphibia.ColorOfSkin = Console.ReadLine();
            newAmphibia.CanSwim = true;
            newAmphibia.HasGills = true;
            AnimalManager animalManager = new AnimalManager();
            animalManager.AddAnimal(newAmphibia);
        }
      

        public void AddFrog() //Steg ett i tillägg av groda
        {
            Frog newFrog = new Frog();
            Console.WriteLine("Pattern:");
            newFrog.Pattern = Console.ReadLine();
            Console.WriteLine("Jump Length:");
            newFrog.JumpLength = int.Parse(Console.ReadLine());
            AddAmphibia(newFrog);
        }

        public void AddToad()
        {
            Toad newToad = new Toad();
            Console.WriteLine();
            newToad.Metamorphosis = true;
            Console.WriteLine("Walking Length:"); 
            newToad.walkingLength = int.Parse(Console.ReadLine());
            AddAmphibia(newToad);
        }

        public void ListFrogs()
        {
            AnimalManager animalManager = new AnimalManager();
            var amphibias = new List<Amphibia>();
            amphibias.AddRange(Frogs);
            var animals = new List<Animal>(Frogs);
            for (int i = 0; i < Frogs.Count; i++)
            {
                Console.WriteLine("Frog No" + (i + 1) + ":");
                Console.WriteLine(animalManager.ListAnimals(animals, i));
                Console.WriteLine(ListAmphibia(amphibias, i));
                Console.WriteLine("JumpLength: {0} Cm \tPattern: {1}", Frogs[i].JumpLength, Frogs[i].Pattern);
                Console.WriteLine();
            }
         
        }

        public void ListToads()
        {
            AnimalManager animalManager = new AnimalManager();
            var amphibias = new List<Amphibia>(Toads);
            var animals = new List<Animal>(Toads);
            for (int i = 0; i < Toads.Count; i++)
            {
                Console.WriteLine("Toad No" + (i + 1) + ":");
                Console.WriteLine(animalManager.ListAnimals(animals, i));
                Console.WriteLine(ListAmphibia(amphibias, i));
                Console.WriteLine("Walking Length: {0} Cm", Toads[i].walkingLength);
                Console.WriteLine();
            }
        }

    public string ListAmphibia(List<Amphibia> amphibias, int i)
        {
            return String.Format("Color of skin: {0}", amphibias[i].ColorOfSkin);
        }

        public void DeleteFrog()
        {
            Console.WriteLine("Choose who to delete:");
            int input = int.Parse(Console.ReadLine());
            Frogs.RemoveAt(input - 1);
        }

        public void DeleteToad()
        {
            Console.WriteLine("Choose who to delete:");
            int input = int.Parse(Console.ReadLine());
            Toads.RemoveAt(input - 1);
        }
    }
}
