using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemConverter
{
    public class ForbiddenCharacterOrderException : Exception
    {
        public ForbiddenCharacterOrderException()
        {
        }
        public ForbiddenCharacterOrderException(string message)
        : base(message)
        {
        }
        public ForbiddenCharacterOrderException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
