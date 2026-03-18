using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    // Public classes allows developers to access them from other locations.
    public class HelloWorld
    {
        int a = 1;
        int b = 2;

        // Public method. Notice PascalCase convention for methods and classes.
        // A static local function can't capture local variables or instance state.
        public static void Print()
        {
            Console.WriteLine("Hello World!");
            // Notice that you cannot access a or b variables here. That's because this is a static method. Local variables only.
        }

        // Private method. Only accessible here.
        private void PrivatePrint()
        {
            // We can access class variables here because we're not a static method.
            a++;
            b--;
            Console.WriteLine("Sheeesh! Hello World!");
        }
    }
}
