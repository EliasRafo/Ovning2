using Ovning2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2
{
    public class Main
    {
        private static IHelper helper = new Helper();
        private static ApplicationManager priceCalculation = new ApplicationManager();

        // Run method
        public void Run()
        {
            do
            {
                Console.Clear();
                ShowMeny(); // Calling ShowMeny method
                string input = helper.GetInput().ToUpper();   // Getting user input

                switch (input)  // Calling approperiet method depending on user input
                {
                    case MenyHelpers.UngdomPensionar:
                        UngdomPensionar();
                        break;
                    case MenyHelpers.HeltSallskap:
                        HeltSallskap();
                        break;
                    case MenyHelpers.Upprepa:
                        Upprepa();
                        break;
                    case MenyHelpers.TredjeOrdet:
                        TredjeOrdet();
                        break;
                    case MenyHelpers.Sluta:
                        Environment.Exit(0);
                        break;
                    default:
                        helper.Print("Det är felaktig input.");
                        break;
                }


            } while (true);
        }

        private static void ShowMeny()  // ShowMeny method, displaying menu items
        {
            helper.Print("Välkommen till C# övning 2");
            helper.Print("Vänligen navigera genom menyn genom att skriva en siffra som du väljer");
            helper.Print($"{MenyHelpers.UngdomPensionar}. Ungdom eller pensionär");
            helper.Print($"{MenyHelpers.HeltSallskap}. priset för ett helt sällskap");
            helper.Print($"{MenyHelpers.Upprepa}. Upprepa tio gånger");
            helper.Print($"{MenyHelpers.TredjeOrdet}. Det tredje ordet");
            helper.Print($"{MenyHelpers.Sluta}. Sluta");
        }

        private static void UngdomPensionar()  // UngdomPensionar method
        {
            uint alder = UserInput.AskForUInt("Ange ålder", helper);  // Getting age value

            helper.Print(priceCalculation.GetPrice(alder));  // Displaying price depending on age

            helper.Print("Tryck på valfri tangent för att fortsätta");
            Console.ReadLine();
        }

        private static void HeltSallskap()  // HeltSallskap method
        {
            uint NumberOfPerson = UserInput.AskForUInt("Antal personer", helper);  // Getting number of person
            List<Person> persons = new List<Person>();  // Creating list of Person
            uint alder;

            for (int i = 0; i < NumberOfPerson; i++)  // Using for-loop to get the age of each person and add the person to persons list
            {
                alder = UserInput.AskForUInt($"Ange ålder {i + 1} ", helper);

                persons.Add(new Person(alder));
            }

            helper.Print(priceCalculation.GetPrice(persons));  // Displaying the total price

            helper.Print("Tryck på valfri tangent för att fortsätta");
            Console.ReadLine();
        }

        private static void Upprepa()   // Upprepa method
        {
            string text = UserInput.AskForString("Ange text", helper);   // Getting text value

            helper.Print(priceCalculation.Iteration(text));  // Displaying the iteration of text

            helper.Print("Tryck på valfri tangent för att fortsätta");
            Console.ReadLine();
        }

        private static void TredjeOrdet()   // TredjeOrdet method
        {
            string text = UserInput.AskForString("Ange text", helper);   // Getting text value

            helper.Print(priceCalculation.GetWord(text)); // Displaying the third word of the entered text

            helper.Print("Tryck på valfri tangent för att fortsätta");
            Console.ReadLine();
        }

    }
}
