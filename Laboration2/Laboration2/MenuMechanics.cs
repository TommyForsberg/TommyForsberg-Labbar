using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class MenuMechanics
    {
        AmphibiaManager amphibiaManager = new AmphibiaManager();
        ReptileManager reptileManager = new ReptileManager();
        MammalManager mammalManager = new MammalManager();
        
        public void FirstMenuNavigation()
        {
            bool delete = false;
            int input = int.Parse(Console.ReadLine());
           

            switch (input)
            {
                case 1:
                    string lable = "Add:";
                    delete = false;
                    Menu.AnimalMenu(lable);
                    SecondMenuNavigation(delete);
                    break;

                case 2:
                    lable = "delete";
                    delete = true;
                    Menu.AnimalMenu(lable);
                    SecondMenuNavigation(delete);
                    
                    break;


                case 3:
                    Menu.ListAnimalsMenu();
                    ListAnimalsNavigation();
                    break;

                case 4: Runtime.IsProgramRunning = false;
                    break;

            }
        }
        public void SecondMenuNavigation(bool delete)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Menu.AmphibiaMenu();
                    AmphibiaMenuNavigation(delete);
                    break;


                case 2:
                    Menu.MammalMenu();
                    MammalMenuNavigation(delete);
                    break;

                case 3:
                    Menu.ReptileMenu();
                    ReptileMenuNavigation(delete);
                    break;

                case 4:
                    break;

                default:
                    break;

            }
        }

        public void AmphibiaMenuNavigation(bool delete)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    if (delete == false)
                    amphibiaManager.AddFrog();

                    if (delete == true)
                    {
                        amphibiaManager.ListFrogs();
                        amphibiaManager.DeleteFrog();
                    }
                    break;

               case 2:
                    if (delete == false)
                        amphibiaManager.AddToad();
                    if (delete == true)
                    {
                        amphibiaManager.ListToads();
                        amphibiaManager.DeleteToad();
                    }
                        break;
                default:
                    break;
            }
        }

        public void MammalMenuNavigation(bool delete)
        {
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    if (delete == false)
                        mammalManager.AddMonkey();

                    if (delete == true)
                    {
                        mammalManager.ListMonkeys();
                        mammalManager.DeleteMonkey();
                    }
                    break;
                case 2:
                    if (delete == false)
                        mammalManager.AddCat();

                    if (delete == true)
                    { 
                     mammalManager.ListCats();
                     mammalManager.DeleteCat();
                    }
                        break;
            }
        }

        public void ReptileMenuNavigation(bool delete)
        {
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1:
                    if (delete == false)
                        reptileManager.AddCrocodile();

                    if (delete == true)
                    {
                        reptileManager.ListCrocodiles();
                        reptileManager.DeleteCrocodile();
                    }
                        break;
                case 2:
                    if (delete == false)
                        reptileManager.AddSnake();

                    if (delete == true)
                    {
                        reptileManager.ListSnakes();
                        reptileManager.DeleteSnake();
                    }
                        break;
            }
        }

        public void ListAnimalsNavigation()
        {
            AnimalManager animalManager = new AnimalManager();
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                
                case 1:
                    Console.WriteLine("FROGS");
                    amphibiaManager.ListFrogs();
                    Console.WriteLine("TOADS");
                    amphibiaManager.ListToads();
                    Console.WriteLine("MONKEYS");
                    mammalManager.ListMonkeys();
                    Console.WriteLine("CATS");
                    mammalManager.ListCats();
                    Console.WriteLine("CROCODILES");
                    reptileManager.ListCrocodiles();
                    Console.WriteLine("SNAKES");
                    reptileManager.ListSnakes();
                    break;
                case 2: amphibiaManager.ListFrogs();
                    break;
                case 3: amphibiaManager.ListToads();
                    break;
                case 4: mammalManager.ListMonkeys();
                    break;
                case 5: mammalManager.ListCats();
                    break;
                case 6: reptileManager.ListCrocodiles();
                    break;
                case 7: reptileManager.ListSnakes();
                    break;
            }
            Console.ReadLine();
        }
}
}
