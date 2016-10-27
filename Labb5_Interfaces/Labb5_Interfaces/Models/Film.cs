using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Labb5_Interfaces
{
    public class Film : Item
    {
        public enum GenreType 
        {
            Action = 1,
            Thriler,
            Comedy,
            Drama,
            Horror
        } //Not yet implemented
        public string Director { get; set; }
        public GenreType Genre { get; set; }
        public override string Properties()
        {
            return string.Format("{0,-20}{1,-25}",Director, base.Properties());
        }
    }

 
}