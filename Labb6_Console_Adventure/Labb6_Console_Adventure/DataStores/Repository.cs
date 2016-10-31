using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb6_Console_Adventure;
namespace Labb6_Console_Adventure
{
    class Repository //Holds all Lists and populates Lists with constructor
    {
        
        public IEnvironment CurrentRoom { get; set; }
        public static List<IEnvironment> Rooms { get; set; }
        public List<IInterestingObject> SherlocksStuff { get; set; }
        public Repository()

        {
            Rooms = new List<IEnvironment>()
            {
                new Apartment {Location = "Baker Street", Name = "Home",
                    People =  new List<INonPlayerCharacter>
                    {
                        new Human("Baker Street") {Name = "Dr Watson", FacialHair ="moustasche"}
                   }
                },
                new Inn {Location = "Gondor", Name = "The Fat Duck",
                    People = new List<INonPlayerCharacter>
                    {
                        new Goblin {Name = "Jazil", SignatureMark = "big nose", TemperPoints = 8 },
                        new Goblin {Name = "Shagrat", TemperPoints = 2,
                            SecretLocation = new List<IEnvironment>
                            { new Inn { Location ="Mordor", Name = "Durthang",
                            Furniture = new List<IInterestingObject>
                            {new KeyObject { ObjectType = 0, Interactable = true, Color = "Gold"} } } } },
                        new Hobbit {Name = "Sméagol" },
                        new Human("Gondor") {Name = "Klaus", FacialHair = "beard"}
                    },
                     Furniture = new List<IInterestingObject>
                    {new Prop {ObjectType = (Prop.PropType)1, Color ="Blue", Interactable =true },
                    new Prop {ObjectType = (Prop.PropType)0, Color = "Red", Interactable = false }
                     }
                    }
        };
            SherlocksStuff = new List<IInterestingObject>
            {new Prop {ObjectType = 0, Color = "White", Interactable =false }

            };

            CurrentRoom = Rooms[0];

        }
    }
}
