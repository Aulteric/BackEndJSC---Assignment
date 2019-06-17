using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_Assignment.Cards
{
    public class SilverCard : DiscountCard
    {
        public SilverCard(string Owner, double PreviousMonthTurnover) : base(Owner, PreviousMonthTurnover)
        {
            if (PreviousMonthTurnover > 300)
            {
                InitialDiscount = 3.5;
            }
            else InitialDiscount = 2;
        }
    }
}
