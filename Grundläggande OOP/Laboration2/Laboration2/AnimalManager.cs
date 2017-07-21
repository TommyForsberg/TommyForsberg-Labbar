using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class AnimalManager
    {
       
        public void AddAnimal(Animal newAnimal)
        {
            Console.WriteLine("Habitat:");
            newAnimal.Habitat = Console.ReadLine();
            Console.WriteLine("Age:");
            newAnimal.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Weight:");
            newAnimal.Weight = int.Parse(Console.ReadLine());
            AddToList(newAnimal);
        }

        public void AddToList(Animal newAnimal)
        {
            if (newAnimal is Frog)
            {
                Frog newFrog = (Frog)newAnimal;
                AmphibiaManager.Frogs.Add(newFrog);
            }

            else if(newAnimal is Toad)
            {
                Toad newToad = (Toad)newAnimal;
                AmphibiaManager.Toads.Add(newToad);
            }

            else if (newAnimal is Monkey)
            {
                Monkey newMonkey = (Monkey)newAnimal;
                MammalManager.Monkeys.Add(newMonkey);
            }
            else if (newAnimal is Cat)
            {
                Cat newCat = (Cat)newAnimal;
                MammalManager.Cats.Add(newCat);
            }
            else if (newAnimal is Crocodile)
            {
                Crocodile newCrocodile  = (Crocodile)newAnimal;
                ReptileManager.Crocodiles.Add(newCrocodile);
            }
            else if (newAnimal is Snake)
            {
                Snake newSnake  = (Snake)newAnimal;
                ReptileManager.Snakes.Add(newSnake);
            }
        }

        public string ListAnimals(List<Animal> animals, int i)
        {
            return String.Format("Age: {0} \tHabitat: {1} \tWeight: {2} kg", animals[i].Age, animals[i].Habitat, animals[i].Weight) ;
            }

      
    }
}
