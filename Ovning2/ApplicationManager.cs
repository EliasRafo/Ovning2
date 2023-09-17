using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2
{
    // ApplicationManager class implements the IApplicationManager interface
    internal class ApplicationManager : IApplicationManager
    {
        // GetPrice method that return the price depending on person age
        public string GetPrice(uint age)
        {
            Person person = new Person(age);  // Creating new object of Person class and pass person age to it.

            string result = "";

            switch (person.PriceGroup) // Getting price depending on PriceGroup by using switch
            {
                case PriceGroup.Ungdom:
                    result = "Ungdomspris: 80kr";
                    break;
                case PriceGroup.Pensionar:
                    result = "Pensionärspris: 90kr";
                    break;
                case PriceGroup.Standard:
                    result = "Standardpris: 120kr";
                    break;
                default:
                    result = "Gratis";
                    break;
            }
            return result;
        }

        // GetPrice method that calculate the total price depending on list of person
        public string GetPrice(List<Person> persons)
        {
            int sum = 0;

            foreach (Person person in persons)   // Foreach loop to calculate the total price 
            {
                sum += Price(person);
            }

            return $"Antal personer: {persons.Count()}, totalkostnad för hela sällskapet {sum}";
        }

        // Price method, return the price depending on price group
        private int Price(Person p)
        {
            switch (p.PriceGroup)
            {
                case PriceGroup.Ungdom:
                    return 80;
                case PriceGroup.Pensionar:
                    return 90;
                case PriceGroup.Standard:
                    return 120;
                default:
                    return 0;
            }
        }

        // Iteration method, repeating the text for 10 times and return the new text
        public string Iteration(string text)
        {
            string result = "";
            for (int i = 0; i < 10; i++) 
            {
                result += $"{i+1}. {text}, ";
            }
            return result;
        }

        // GetWord method, splitting the text to an array and omit elements that contain an empty string, and return the third value of array.
        public string GetWord(string text)
        {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);  // splitting the text

            if (words.Length >= 3)  // Checking the length of array if it is bigger or equal to three
                return $"Det tredje ordet är {words[2]}"; // Returning the third value of array.
            else return "Meningen bör innehålla minst 3 ord";
        }
    }
}
