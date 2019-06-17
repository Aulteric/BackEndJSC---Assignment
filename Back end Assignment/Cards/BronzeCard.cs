using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_Assignment.Cards
{
    public class BronzeCard : DiscountCard
    {
        public BronzeCard(string Owner, double PreviousMonthTurnover) : base(Owner, PreviousMonthTurnover)
        {
            if (PreviousMonthTurnover > 300)
            {
                InitialDiscount = 2.5;
            }
            else if (PreviousMonthTurnover > 100)
            {
                InitialDiscount = 1;
            }
            else InitialDiscount = 0;
        }

    }
}
