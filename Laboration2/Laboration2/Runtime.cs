using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Runtime
    {
        

        //AmphibiaManager amphibiaManager = new AmphibiaManager();
        //ReptileManager reptileManager = new ReptileManager();
        //MammalManager mammalManager = new MammalManager();


        public void Start()
        {
            
            bool isProgramRunning = true;
            MenuMechanics menuMechanics = new MenuMechanics();
            do
            {
                Menu.MainMenu();
                menuMechanics.FirstMenuNavigation();
            } while (isProgramRunning);
        }

       

        

   

    }
}
