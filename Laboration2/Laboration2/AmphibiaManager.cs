﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class AmphibiaManager
    {
        public List<Frog> Frogs { get; set; }
        public List<Toad> Toads { get; set; }


        public AmphibiaManager()
        {
            Frogs = new List<Frog>()
                {
                   new Frog {ColorOfSkin = "Grey" },
                   new Frog { ColorOfSkin = "Green", Weight = 0.2, Age = 2, Habitat = "Water & Forest" },
                   new Frog { ColorOfSkin = "Grey & Green", Weight = 0.15, Age = 1, Habitat = "Water" }
                };

            Toads = new List<Toad>()
                {
                    new Toad {ColorOfSkin = "Purple", Metamorphosis = true, Weight = 0.3, CanSwim = true,
                     Habitat = "Mud & Lakes", Age = 3}
                };
        }

        public void AddAmphibia(Amphibia newAmphibia)
        {
            
            Console.WriteLine("Color of skin: ");
            newAmphibia.ColorOfSkin = Console.ReadLine();
            newAmphibia.CanSwim = true;
            newAmphibia.HasGills = true;
            //Frog newFrog = (Frog)newAmphibia;
            AddAnimal(newAmphibia);
            // Frog newFrog = new Frog();
            
        }
        public void AddAnimal(Animal newAnimal) //börja med det specifika och skicka vidare ut i generella
        {
            Console.WriteLine("Habitat:");
            newAnimal.Habitat = Console.ReadLine();
            Console.WriteLine("YES");
            Console.ReadKey();
            AddToList(newAnimal);
        }

        public void AddFrog()
        {
            Frog newFrog = new Frog();
            Console.WriteLine("Pattern:");
            newFrog.Pattern = Console.ReadLine();
            AddAmphibia(newFrog);
        }

        public void ListFrogs()
        {
            //for(int i = 0; i <= Frogs.Count; i++)
            //{ Console.WriteLine(Frogs[i].ColorOfSkin); }
            foreach (var Frog in Frogs)
            {
                Console.WriteLine(Frog.ColorOfSkin);
            }
            Console.ReadLine();
        }

        public void AddToList(Animal newAnimal)
        {
            if (newAnimal is Frog)
            {
                Frog newFrog = (Frog)newAnimal;
                // AmphibiaManager amphibiaManager = new AmphibiaManager();
                Frogs.Add(newFrog);
            }
        }
    }
}
