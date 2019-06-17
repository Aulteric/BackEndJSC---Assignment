using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_Assignment.Cards
{
    class GoldCard : DiscountCard
    {
        public GoldCard(string Owner, double PreviousMonthTurnover) : base(Owner, PreviousMonthTurnover)
        {
            if (PreviousMonthTurnover > 100)
            {
                InitialDiscount = 2 + (int)(PreviousMonthTurnover / 100);
                if (InitialDiscount > 10)
                {
                    InitialDiscount = 10;
                }
            }
        }
    }
}
