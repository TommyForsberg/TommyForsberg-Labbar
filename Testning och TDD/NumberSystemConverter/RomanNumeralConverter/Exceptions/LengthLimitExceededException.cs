using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemConverter
{
    public class LengthLimitExceededException : Exception
    {
        public LengthLimitExceededException()
        {

        }
        public LengthLimitExceededException(string message)
            :base(message)
        { }

        public LengthLimitExceededException(string message, Exception inner)
            :base(message, inner)
        {

        }
    }
}
