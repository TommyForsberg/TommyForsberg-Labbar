using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb5_Interfaces
{
    public class ItemLists  //Holdingplace for lists of different objects
    {
        private static List<Film> films;
        private static List<Book> books;

        public static List<Film> Films
        {
            get
            {  if (films == null)
                  films = new List<Film>();

                return films;
            }
       }

        public static List<Book> Books
        {
            get
            { if (books == null)
                    books = new List<Book>();

                return books;

            }
        }
    }
}