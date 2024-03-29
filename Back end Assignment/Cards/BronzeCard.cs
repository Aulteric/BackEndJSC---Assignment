﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Back_Еnd_Assignment.Cards
{
    public class BronzeCard : DiscountCard
    {
        public BronzeCard(double PreviousMonthTurnover) : base(PreviousMonthTurnover)
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
