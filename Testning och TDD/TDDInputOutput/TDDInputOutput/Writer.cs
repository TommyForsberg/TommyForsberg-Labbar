using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TDDInputOutput
{
    public class Writer
    {
        string _firstName;
        string  _lastName;
        float _firstNumber;
        float _secondNumber;
        

        public Writer(string _firstName, string _lastName, float _firstNumber, float _secondNumber)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;
            this._firstNumber = _firstNumber;
            this._secondNumber = _secondNumber;

            var directory = "C://Users//Tommy//Desktop";
            if(!File.Exists(directory + "//TextFile.txt"))
            File.Create(directory + "//TextFile.txt");
        }
        //public void TakeInput()
        //{
        //    Console.WriteLine("Firstname:");
        //    _firstName = Console.ReadLine();
        //    Console.WriteLine("Lastname:");
        //    _lastName = Console.ReadLine();
        //    Console.WriteLine("Input first number:");
        //    _firstNumber = int.Parse(Console.ReadLine());
            
        //    Console.WriteLine("Input second number");
        //    _secondNumber = int.Parse(Console.ReadLine());
        //}
        public string FullNameGenerator(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        public float Addition(float number1, float number2)
        {
            return number1 + number2;
        }

        public float Subtractor(float number1, float number2)
        {
            return number1 - number2;
        }

        public float Multiplication(float number1, float number2)
        {
            return number1 * number2;
        }

        public float Division(float number1, float number2)
        {
            return number1 / number2;
        }

        public void WriteToFile(string[] assembly)
        {
            var directory = "C://Users//Tommy//Desktop";
            // File.WriteAllLines(directory + "//TextFile.txt", AssembleArray(_firstName, _lastName, _firstNumber, _secondNumber));
            File.WriteAllLines(directory + "//TextFile.txt", assembly);
        }

        public string[] AssembleArray()
        {
            //return new string[] {
            //    FullNameGenerator(_firstName,_lastName),
            //    Addition(_firstNumber,_secondNumber).ToString(),
            //    Subtractor(_firstNumber,_secondNumber).ToString(),
            //    Multiplication(_firstNumber,_secondNumber).ToString(),
            //    Division(_firstNumber,_secondNumber).ToString()
            //};
            string[] s =
            {
                     FullNameGenerator(_firstName,_lastName),
                Addition(_firstNumber,_secondNumber).ToString(),
                Subtractor(_firstNumber,_secondNumber).ToString(),
                Multiplication(_firstNumber,_secondNumber).ToString(),
                Division(_firstNumber,_secondNumber).ToString()
            };
            if(s[4] == "∞" || s[4] == "-∞")
            {
                s[4] = "invalid";
            }
            return s;
        }

        public string[] ReadFromFile()
        {
            var directory = "C://Users//Tommy//Desktop";
            var array = File.ReadAllLines(directory + "//TextFile.txt");
            return array;
        }
    }
}
