using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration8
{
    class Program
    {
        static void Main(string[] args)
        {
            var runtime = new Runtime();
            Console.WriteLine("1. Assignment G, 2. Assignment VG");
            int input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                
                case 1:
                    runtime.Start();
                    Console.ReadLine();
                    break;
                case 2:
                    runtime.Assignment2();
                    break;
            }
        }
    }
}
