using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13EventsOchDelegater
{
    class AdultChecker
    {
        public void OnWrongInput(string input)
        {
            Console.WriteLine("AdultChecker: " + input + " is not allowed!");
        }
    }
}
