using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossesBilarOchBågar
{
    class Menu
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Stock Manager 1.0 | BOSSES BILAR OCH BÅGAR");
            Console.WriteLine("1. Cars");
            Console.WriteLine("2. Motorcycles");
            Console.WriteLine("3. Buy/Sell");
        }

        public static void PrintTabSorting()
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4, -10}{5,-10}{6, -10}{7,-5}\n", "TYPE", "CODE", "BRAND", "MODEL", "YEAR", "COLOR", "USED/NEW", "PRICE");
        }

        public static void PrintFilterChoice()
        {
            Console.WriteLine("\n{0}{1,11}{2,15}{3,15}{4,10}\n{5,29}{6,11}", "Filter by ? :", "1. Brand", "2. Color", "3. Used/New", "4. Year", "5. Sell/Scrap", "6. Return"  );
        }

        public static void PrintBuyAndAdd()
        {
            Console.WriteLine("1. Buy from market");
            Console.WriteLine("2. Add to stock");
        }

        public static void SellOrScrap()
        {
            Console.WriteLine("Sell/Scrap vehicle? (Yes/No");
            
        }
    }
}
