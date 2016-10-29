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
        public  List<IEnvironment> Rooms { get; }
        public List<IInterestingObject> SherlocksStuff { get; set; }
        public Repository()
        {
            Rooms = new List<IEnvironment>()
            {
                new Apartment {Location = "Baker Street",
                    People =  new List<INonPlayerCharacter>
                    {
                        new Human {Name = "Dr Watson", TemperPoints = 10 }
                    }
                },
                new Inn {Location = "Gondor",
                    People = new List<INonPlayerCharacter>
                    {
                        new Goblin {Name = "Shagrat", TemperPoints = 2 }
                    }
                    }

            };
                
        }

        public IEnvironment GetRoom(int currentRoom)
        {
            return Rooms[currentRoom];
            
        }

        //public List<IEnvironment> GetAllRooms()
        //{
        //    return Rooms;

        //}


    }
}
