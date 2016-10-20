using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossesBilarOchBågar
{
    class ValidInput
    {

        public static int ValidInteger()
        {
            bool validInput;
            int output;

            do
            {
                string input = Console.ReadLine();
                validInput = int.TryParse(input, out output);
                if (validInput)
                    return output;
                else
                   Console.WriteLine("Wrong input, try again.");
            } while (true);
        }
    }
}
