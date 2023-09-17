using Ovning2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2
{
    // Helper class implements the IHelper interface
    public class Helper : IHelper
    {
        // Getting user input
        public string GetInput()
        {
            return Console.ReadLine()!;
        }
        // Print message to user
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
