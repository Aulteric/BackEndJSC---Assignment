using System;
using System.Collections.Generic;
using System.Text;

namespace Back_Еnd_Assignment.Cards
{
    public abstract class DiscountCard
    {
        private double initialDiscount;
        private double previousMonthTurnover;


        public double InitialDiscount
        {
            get { return initialDiscount; }
            set { initialDiscount = value; }
        }
        public double PreviousMonthTurnover
        {
            get { return previousMonthTurnover; }
            set { previousMonthTurnover = value; }
        }

        public DiscountCard(double PreviousMonthTurnover)
        {
            this.PreviousMonthTurnover = PreviousMonthTurnover;
        }
    }
}
