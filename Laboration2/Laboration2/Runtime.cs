using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Runtime
    {
        AmphibiaManager amphibiaManager = new AmphibiaManager();
        ReptileManager reptileManager = new ReptileManager();
        MammalManager mammalManager = new MammalManager();

        public void Start()
        {
            amphibiaManager = new AmphibiaManager();
            bool isProgramRunning = true;
            do
            {
                Menu.MainMenu();
                FirstMenuNavigation();
            } while (isProgramRunning);
        }

        //public void InitializeListsAndInstances()
        //{
        //    var amphibiaManager = new AmphibiaManager();
        //    var reptileManager = new ReptileManager();
        //    var mammalManager = new MammalManager();
           
        //}

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
                    
                    amphibiaManager.ListFrogs();
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
                    //string lable = "Add";
                    Menu.AmphibiaMenu();
                    ThirdMenuNavigation();
                    break;


            }
        }

        public void ThirdMenuNavigation()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Choice:");

            switch (input)
            {
                case 1:
                    //var amphibiaManager = new AmphibiaManager();
                    amphibiaManager.AddFrog(); 
                    break;
            }
        }

   

    }
}
