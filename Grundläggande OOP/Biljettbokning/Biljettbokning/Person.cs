using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Event> MyEvents { get; set; }


        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
