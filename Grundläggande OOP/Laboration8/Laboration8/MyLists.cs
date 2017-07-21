using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration8
{

    class MyLists
    {
        public  string[] MyStrings { get; set; }
        public  float[] MyFloats { get; set; }

        public MyLists()
        {
            MyStrings = new string[]
            {
                "Hello",
                "World",
                "My",
                "Name",
                "is",
                "HAL9000"
            };

            MyFloats = new float[]
            {
                9.0f,
                5.0f,
                2.5f,
                1.0f,
                3.4f
            };
        }
    }
}
