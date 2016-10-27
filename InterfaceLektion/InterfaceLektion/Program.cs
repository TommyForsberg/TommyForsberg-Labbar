using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLektion.Interfaces;

namespace InterfaceLektion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region old
            //IFlyable bird = new Bird();
            //IFlyable plane = new Plane();

            //bird.Fly();
            //plane.Fly();
# endregion
            //Typing an object variable to an interface menas we can treat
            //all classes/objects implementing this interface the same way.
            //For example we may add different classes to a List of of interfaces.
            //The downside is that we cannot access methods or properties that
            //are specific for BIrd or Plane without casting.

            List < IFlyable >  flyingThings = new List<IFlyable>
            {
                new Bird {Color = "Red", TopSpeed = 80 },
                new Plane {TopSpeed = 2000 }
            };

            foreach(var flyingthing in flyingThings)
            {
                flyingthing.Fly();
                Console.WriteLine(flyingthing.TopSpeed);
               /* Console.WriteLine(((Bird)flyingthing).Color)*/;
            }

            List<ISpeakable> speakingThings = new List<ISpeakable>
            {
                new Bird { Color = "red", TopSpeed = 30},
                new Dog(),
                new Person()
            };

            foreach(var speakingThing in speakingThings)
            {
                Console.WriteLine(speakingThing.Speak());
            }
        }
    }
}
