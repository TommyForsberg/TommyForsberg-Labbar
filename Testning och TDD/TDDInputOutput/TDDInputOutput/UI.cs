using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDInputOutput
{
    public class UI
    {
        public static float CorrectInteger()
        {
            while (true)
            {
                string input = Console.ReadLine();
                float number;
                bool result = float.TryParse(input, out number);

                if (result)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again!");
                }
            }
        }
    }
}
