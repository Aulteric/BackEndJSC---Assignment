using System;

namespace Back_end_Assignment
{
    class Program
    {
        private static void Inputing()
        {
            Console.WriteLine("Please choose the type of card you want to have" + Environment.NewLine + "1.Bronze" +
                Environment.NewLine + "2.Silver" + Environment.NewLine + "3.Gold");
            var CardChoice = ChoiceValidator();
        }

        private static int ChoiceValidator()
        {
            var temp = Console.ReadLine();
            int choice;
            if (int.TryParse(temp, out choice))
            {
                if (choice > 3 || choice < 1)
                {
                    Console.WriteLine("Please insert a valid choice");
                    choice = ChoiceValidator();
                }
            }
            else
            {
                Console.WriteLine("Please insert a valid choice");
                choice = ChoiceValidator();
            }
            return choice;
        }

        static void Main(string[] args)
        {
            Inputing();
        }

    }
}
