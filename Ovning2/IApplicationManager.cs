using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2
{
    // IApplicationManager interface
    internal interface IApplicationManager
    {
        // GetPrice interface method
        string GetPrice(uint age);
        // Overloading the GetPrice method 
        string GetPrice(List<Person> persons);
        // Iteration interface method
        string Iteration(string text);
        // GetWord interface method
        string GetWord(string text);
    }
}
