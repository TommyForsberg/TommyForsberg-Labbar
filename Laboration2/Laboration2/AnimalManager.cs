using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class AnimalManager
    {
       // public static List<Frog> Frogs { get; set; }
        public void AddAnimal(Animal newAnimal) //börja med det specifika och skicka vidare ut i generella
        {
            Console.WriteLine("Habitat:");
            newAnimal.Habitat = Console.ReadLine();
            Console.WriteLine("Age:");
            newAnimal.Age = int.Parse(Console.ReadLine());
            AddToList(newAnimal);
        }

        public void AddToList(Animal newAnimal)
        {
            if (newAnimal is Frog)
            {
                Frog newFrog = (Frog)newAnimal;
                //AmphibiaManager amphibiaManager = new AmphibiaManager();
                AmphibiaManager.Frogs.Add(newFrog);
            }

            else if(newAnimal is Toad)
            {
                Toad newToad = (Toad)newAnimal;
                AmphibiaManager.Toads.Add(newToad);
            }
        }
    }
}
