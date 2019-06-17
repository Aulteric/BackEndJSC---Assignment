using Back_end_Assignment.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_Assignment
{
    public class PayDesk
    {
        public static void GetPurchaseValue(Client client)
        {
            Console.WriteLine($"Purchase value: ${client.PurchaseValue:F2}");
        }
        public static void GetDiscountRate(Client client)
        {
            Console.WriteLine($"Discount Rate: {client.Card.InitialDiscount:F1}%");
        }
        public static void GetDiscount(Client client)
        {
            Console.WriteLine($"Discount: ${client.Discount:F2}");
        }
        public static void GetTotal(Client client)
        {
            Console.WriteLine($"Total: ${(client.PurchaseValue - client.Discount):F2}");
        }        
    }
}
