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

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Choice:");

            switch (input)
            {
                case 1:
                    string lable = "Add";
                    Menu.AnimalMenu(lable);
                    SecondMenuNavigation();
                    break;

                case 3:
                    string lableList = "List";
                    Menu.AnimalMenu(lableList);
                    SecondMenuNavigation();
                   // amphibiaManager.ListFrogs();
                    break;


            }
        }
        public void SecondMenuNavigation()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Choice:");

            switch (input)
            {
                case 1:
                    Menu.AmphibiaMenu();
                    AmphibiaMenuNavigation();
                    break;


                case 2:
                    Menu.MammalMenu();
                    MammalMenuNavigation();
                    break;

                case 3:
                    Menu.ReptileMenu();
                    ReptileMenuNavigation();
                    break;

            }
        }

        public void AmphibiaMenuNavigation()
        {

            int input = int.Parse(Console.ReadLine());
           // Console.WriteLine("Choice:");
            
            switch (input)
            {
                case 1:

                    amphibiaManager.AddFrog();
                    break;

               case 2:
                    amphibiaManager.AddToad();
                    break;
            }
        }

        public void MammalMenuNavigation()
        {
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1: mammalManager.AddMonkey();
                    break;
                case 2: mammalManager.AddCat();
                    break;
            }
        }

        public void ReptileMenuNavigation()
        {
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1: reptileManager.AddCrocodile();
                    break;
                case 2: reptileManager.AddSnake();
                    break;
            }
        }
    }
}
