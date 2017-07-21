using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11_Events
{
    class Runtime
    {

        public delegate void AnalyzeNumber(int number);
        private event AnalyzeNumber NumberInput;
        public void Start()
        {

            NumberInput += IsEven;
            NumberInput += IsDivisableByThree;
            NumberInput += IsPrimeNumber;
         
           
            do {
                Console.Clear();
                Console.WriteLine("Input number");
                int input = int.Parse(Console.ReadLine());
                OnNumberInput(input);
                Console.ReadKey();
                } while (true);
}

        public void IsEven(int number)
        {
            Console.WriteLine("{0} is {1} even number", number, number %2==0? "an":"not an");
                
        }

        public void IsDivisableByThree(int number)
        {
            Console.WriteLine("{0} {1} divisable by three", number, number %3==0? "is":"is not");
        }

        public void IsPrimeNumber(int number)
        {
            bool isPrime = true;
            if (number <= 1)
                isPrime = false;

            else
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                else
                    isPrime = true;
            }
            if (isPrime == true)
            Console.WriteLine("The number is a prime number.");
            else
                Console.WriteLine("The number is not a prime number.");
        }

       protected virtual void OnNumberInput(int input)
        {
            NumberInput?.Invoke(input);
        }

    }
}
