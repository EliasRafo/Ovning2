using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2.Helpers
{
    // Static class UserInput
    public static class UserInput
    {
        // AskForString static method, used to check if user input is not null or white space.
        public static string AskForString(string prompt, IHelper helper)
        {

            bool success = false;
            string answer;

            do
            {
                helper.Print($"{prompt}: ");
                answer = helper.GetInput();  // Getting user input

                if (string.IsNullOrWhiteSpace(answer))  // check if user input is null or white space.
                {
                    helper.Print($"You must enter a valid {prompt}");  // Asking user to enter a valid input
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        // AskForUInt static method, used to check if user input an uint.
        public static uint AskForUInt(string prompt, IHelper helper)
        {
            do
            {
                string input = AskForString(prompt, helper);  // Calling AskForString method

                if (uint.TryParse(input, out uint result))  // TryParse user input
                {
                    return result;
                }

            } while (true);
        }
    }
}
