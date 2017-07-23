using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDInputOutput
{
    public class Manager
    {
        public void Start()
        {
            Console.WriteLine("Firstname:");
            var _firstName = Console.ReadLine();
            Console.WriteLine("Lastname:");
            var _lastName = Console.ReadLine();
            Console.WriteLine("Input first number:");
            float _firstNumber = UI.CorrectInteger();
            Console.WriteLine("Input second number");
            float _secondNumber = UI.CorrectInteger();

            var writer = new Writer(_firstName, _lastName, _firstNumber, _secondNumber);

            writer.WriteToFile(writer.AssembleArray());
            var arrayFromFile = writer.ReadFromFile();

            Console.Clear();

            for (int i = 0; i < arrayFromFile.Length; i++)
            {
                Console.WriteLine(arrayFromFile[i]);
            }
            Console.Read();
        }
    }
}
