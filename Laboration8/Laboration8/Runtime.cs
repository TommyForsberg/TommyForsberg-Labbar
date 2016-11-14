using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration8
{
    class Runtime
    {

        MyLists myLists = new MyLists();
        public delegate string StringConcatinator(string[] Mystrings);
        public delegate float NumberOperator(float[] MyFloats);
        public delegate double PriceCalculator(double[] Prices);

        public void Calculator(Func<float[], float> someFloats)
        {
            float result = someFloats(myLists.MyFloats);
            Console.WriteLine(result);
        }

        public string StringCon(string[] someString)
        {
            string result = null;
            int index = 0;

            foreach(var mString in someString)
            {
                index++;
                if (index < someString.Length)
                {
                    result += mString + ", ";
                }
                else
                    result += mString;
            }
            return result;
        }
        #region Assignment1
        public void Start()
        {
            StringConcatinator strCon = StringCon;
            Console.WriteLine(strCon(myLists.MyStrings));

            Func<float[], float> floatAddition = (MyFloats) =>
            {
                float result = 0;
                foreach (var number in MyFloats)
                {
                    result += number;
                }

                return result;
            };

            Func<float[], float> floatMultiply = (myFloats) =>
            {
                float result = 1;

                foreach(var number in myFloats)
                {
                    result *= number;
                }
                return result;
            };

            Calculator(floatAddition);
            Calculator(floatMultiply);
        }
        #endregion

        public void Assignment2()
        {
            var productManager = new ProductManager();
            string[] productNames = productManager.Items.Select(item => item.Name).ToArray();
            double[] productPrices = productManager.Items.Select(item => item.Price).ToArray();

            StringConcatinator strCon = productManager.FormatProductNames;
            Console.WriteLine(strCon(productNames));
            PriceCalculator priceCalculator = productManager.PriceCalculation;
            Console.WriteLine(priceCalculator(productPrices));
            
        }
    }
}
