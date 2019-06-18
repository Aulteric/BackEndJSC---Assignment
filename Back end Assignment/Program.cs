using System;

namespace Back_Еnd_Assignment
{
    class Program
    {
        private static int InputCardChoice()
        {
            Console.WriteLine("Please choose the type of card you want to have" + Environment.NewLine + "1.Bronze" +
                Environment.NewLine + "2.Silver" + Environment.NewLine + "3.Gold");
            return ChoiceValidator();
        }

        private static double InputTurnover()
        {
            Console.WriteLine("Please input the turnover from last month: ");
            return DoubleValidator();
        }

        private static double InputPurchaseValue()
        {
            Console.WriteLine("Please input the Purchase value of the client: ");
            return DoubleValidator();
        }

        private static double DoubleValidator()
        {
            var temp = Console.ReadLine();
            double Validated;
            if (!(double.TryParse(temp, out Validated)))
            {
                if (Validated < 0)
                {
                    Console.WriteLine("Please insert a valid number");
                    Validated = DoubleValidator();
                }
            }
            return Validated;
        }

        private static int ChoiceValidator()
        {
            var temp = Console.ReadLine();
            int Choice;
            if (int.TryParse(temp, out Choice))
            {
                if (Choice > 3 || Choice < 1)
                {
                    Console.WriteLine("Please insert a valid choice");
                    Choice = ChoiceValidator();
                }
            }
            else
            {
                Console.WriteLine("Please insert a valid choice");
                Choice = ChoiceValidator();
            }
            return Choice;
        }

        private static void OutputResults(Client Client)
        {
            PayDesk.GetPurchaseValue(Client);
            PayDesk.GetDiscountRate(Client);
            PayDesk.GetDiscount(Client);
            PayDesk.GetTotal(Client);
        }
        
        static void Main(string[] args)
        {
            var CardChoice = InputCardChoice();
            var Turnover = InputTurnover();
            var PurchaseValue = InputPurchaseValue();
            var Client = new Client(PurchaseValue, Turnover, CardChoice);
            OutputResults(Client);
        }
    }
}
