using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb6_Console_Adventure
{
    public class Goblin : INonPlayerCharacter
    {
        private string signatureMark;
        public string Name { get; set; }
        public string SignatureMark
        {
            get
            {
                if (signatureMark == null)
                    signatureMark = "scar";
                return signatureMark;
            }
            set
            {
                signatureMark = value;
            }
        }

        public int TemperPoints { get; set; }
        public List<IEnvironment> SecretLocation { get; set; }
        public string Appearance(string location)
        {
            string mood;
            if (TemperPoints > 7)
                mood = "drunk";

            else if (TemperPoints == 5)
                mood = "apathetic";

            else
                mood = "aggressive";

            return ("The goblin had a " + SignatureMark + ", it looked very " + mood);
        }

        public void Presentation()
        {
            if (SecretLocation != null && SecretLocation.Count > 0)
            {
                Console.WriteLine("Hello...I am " + Name + ", I will tell you a secret.");
                Console.WriteLine("There is this place...called " + SecretLocation[0].Name
                    + " it lies in " + SecretLocation[0].Location + ".\n I have marked the location on your map.");
                Repository.Rooms.Add(SecretLocation[0]);
                SecretLocation.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Hello...I am " + Name + ", leave me alone.");
            }
        }
    }
}