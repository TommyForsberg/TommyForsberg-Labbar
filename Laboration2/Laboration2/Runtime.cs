using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Runtime
    {


        public static bool IsProgramRunning { get; set; }


        public void Start()
        {
            
            IsProgramRunning = true;
            MenuMechanics menuMechanics = new MenuMechanics();
            do
            {
                Menu.MainMenu();
                menuMechanics.FirstMenuNavigation();
            } while (IsProgramRunning);
        }

       

        

   

    }
}
