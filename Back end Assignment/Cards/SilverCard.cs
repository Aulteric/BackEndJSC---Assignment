using System;
using System.Collections.Generic;
using System.Text;

namespace Back_Еnd_Assignment.Cards
{
    public class SilverCard : DiscountCard
    {
        public SilverCard(double PreviousMonthTurnover) : base(PreviousMonthTurnover)
        {
            if (PreviousMonthTurnover > 300)
            {
                InitialDiscount = 3.5;
            }
            else InitialDiscount = 2;
        }
    }
}
