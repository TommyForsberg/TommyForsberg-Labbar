using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Interfaces
{
    class UI //Shared by both Film and Book - Controllers
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Manage films");
            Console.WriteLine("2. Manage books");
        }
        public static void PrintFilmMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add film");
            Console.WriteLine("2. Remove film");
            Console.WriteLine("3. Show all films");
            Console.WriteLine("4. Edit film");
            Console.WriteLine("5. Return");
        }

        public static void PrintBookMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Remove book");
            Console.WriteLine("3. Show all books");
            Console.WriteLine("4. Edit book");
            Console.WriteLine("5. Return");
        }

        public static void PrintHeader()
        {
            Console.WriteLine("  " + "{0,-20}{1,-20}{2}","Director/Author","Title", "Year" );
        }

        public static Item AddItem(Item newItem) //Receives any Item and takes input for various properties from user
        {                                        //depending on which type of object
            Console.WriteLine("Title:");
            newItem.Title = Console.ReadLine();
            Console.WriteLine("Year:");
            newItem.Year = int.Parse(Console.ReadLine());

            if (newItem is Film)
            {
                Film newFilm = (Film)newItem;
                Console.WriteLine("Director:");
                newFilm.Director = Console.ReadLine();
                return newFilm;
            }

            else
            {
                Book newBook = (Book)newItem;
                Console.WriteLine("Author:");
                newBook.Author = Console.ReadLine();
                return newBook;
            }
        }

        public static void PrintItems(Item[] items) //Prints any list received
        {
            PrintHeader();
            int index = 0;
            foreach(var item in items)
            {
                index++;
                Console.WriteLine(index + " " + item.Properties());
            }
        }

        public static int SelectItem(Item[] items) //Receives any list of objects for selection
        {
            PrintItems(items);
            Console.Write("Select:");
            return int.Parse(Console.ReadLine());
        }

        public static void EditItem(Item item) //Edits Book or Film
        {
            Console.Clear();
            Console.WriteLine("1. Change title");
            Console.WriteLine("2. Change year");
            Console.WriteLine("3. Change director/author");

            var choice = Console.ReadKey(true).Key;
            switch(choice)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("New title:");
                    item.Title = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("New year");
                    item.Year = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D3:
                    if(item is Film)
                    {
                        Film newFilm = (Film)item;
                        Console.WriteLine("New director:");
                        newFilm.Director = Console.ReadLine();
                    }

                    if(item is Book)
                    {
                        Book newBook = (Book)item;
                        Console.WriteLine("New Author");
                        newBook.Author = Console.ReadLine();
                    }
                    break;
            }
        }
    }
}
