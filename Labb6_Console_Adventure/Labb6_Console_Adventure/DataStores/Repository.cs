using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb6_Console_Adventure;
namespace Labb6_Console_Adventure
{
    class Repository
    {
        public IEnvironment CurrentRoom { get; set; }
        public  List<IEnvironment> Rooms { get; }
        public List<IInterestingObject> SherlocksStuff { get; set; }
        public Repository()

        {
            
            Rooms = new List<IEnvironment>()
            {
                new Apartment {Location = "Baker Street",
                    People =  new List<INonPlayerCharacter>
                    {
                        new Human("Baker Street") {Name = "Dr Watson"}
                   } 
                },
                new Inn {Location = "Gondor",
                    People = new List<INonPlayerCharacter>
                    {
                        new Goblin {Name = "Shagrat", TemperPoints = 2 },
                        new Hobbit {Name = "Sméagol" },
                        new Human("Gondor") {Name = "Klaus" }
                    }
                    }

            };
            SherlocksStuff = new List<IInterestingObject>
            {new Prop {ObjectType = 0, Color = "White" }

            };

            CurrentRoom = Rooms[0];

        }

        public void SetRoom(IEnvironment room)
        {
            Rooms.Add(room);
        }

        //public List<IEnvironment> GetAllRooms()
        //{
        //    return Rooms;

        //}


    }
}
