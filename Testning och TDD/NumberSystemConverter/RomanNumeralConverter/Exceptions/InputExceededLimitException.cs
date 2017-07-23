using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemConverter
{
    public class InputExceededLimitException: Exception
    {
        public InputExceededLimitException()
        {
        }

        public InputExceededLimitException(string message)
        : base(message)
        {
        }

        public InputExceededLimitException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
