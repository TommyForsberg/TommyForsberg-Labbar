using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLabb1
{
    class Runtime
    {
       public void Start()
        {
            List<Dog> dogList = new List<Dog>();
            
            bool isProgramRunning = true; 
            do
            {
                Console.Clear();
                Console.WriteLine("1. Add new. \n2. Remove.\n3. Show Info. \n4. EXIT. ");
                var input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                        Console.WriteLine("What is the name of the dog?");
                        string name = Console.ReadLine();
                        Console.WriteLine("How old is the dog?");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the breed?");
                        string breed = Console.ReadLine();
                        dogList.Add(new Dog { Name = name, Age = age, Breed = breed });
                        break;

                    case "2":
                        
                        break;

                    case "3":
                        foreach (var Dog in dogList)
                        {
                            Console.WriteLine(Dog.Name +" " + Dog.Age +" " + Dog.Breed);
                            
                        }
                        Console.ReadLine();
                        break;

                    case "4":
                        isProgramRunning = false;
                        break;

                        //Dog newDog = new Dog
                        //{
                        //    Name = name,
                        //    Age = age,
                        //    Breed = breed
                        //};
                }
            } while (isProgramRunning);

            
            //{
            //   new Dog
            //    {
            //        Name = "Hugo",
            //        Age = 4,
            //        Breed = "Tax"
            //    },
            //    new Dog
            //    {
            //        Name = "Leija",
            //        Age = 5,
            //        Breed = "Dobberman"
            //    },
            //};
            
            
        }

    
    }
}
