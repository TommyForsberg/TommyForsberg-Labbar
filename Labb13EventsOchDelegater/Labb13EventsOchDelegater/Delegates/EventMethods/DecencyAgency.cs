using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13EventsOchDelegater
{
    class DecencyAgency
    {
        public void OnWrongInput(string input)
        {
            Console.WriteLine("Decency Agency: DA has been notified for " +input);
        }
    }
}
