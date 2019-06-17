using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_Assignment.Cards
{
    class GoldCard : DiscountCard
    {
        public GoldCard(double PreviousMonthTurnover) : base(PreviousMonthTurnover)
        {
            if (PreviousMonthTurnover > 100)
            {
                InitialDiscount = 2 + Math.Floor(PreviousMonthTurnover / 100);
                if (InitialDiscount > 10)
                {
                    InitialDiscount = 10;
                }
            }
            else InitialDiscount = 2;
        }
    }
}
