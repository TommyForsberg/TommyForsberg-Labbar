using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public abstract class Animal
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public bool IsColdBlooded { get; set; }
        public string Habitat { get; set; }
    

        public virtual string Move()
        {
            return String.Format("This animal ");
        }

        public virtual string Introduction()
        {
            if(IsColdBlooded)
          return String.Format("weighs {0} kilos, it is {1} years old. \nIt lives in {2} and it is cold blooded", Weight, Age, Habitat);

          return String.Format("weighs {0} kilos, it is {1} years old. \nIt lives in {2}. It is warm blooded", Weight, Age, Habitat);
        }

      
        //public virtual void Sound()
        //{
            
        //}
    }
}
