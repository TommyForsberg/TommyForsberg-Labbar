using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemConverter
{
    public class InputZeroException : Exception
    {
        public InputZeroException()
        { }

        public InputZeroException(string message)
            : base(message)
        { }

        public InputZeroException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
