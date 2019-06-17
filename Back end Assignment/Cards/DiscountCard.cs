using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_Assignment.Cards
{
    public abstract class DiscountCard
    {
        private string owner;
        private double initialDiscount;
        private double previousMonthTurnover;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
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

        public DiscountCard(string Owner, double PreviousMonthTurnover)
        {
            this.Owner = Owner;
            this.PreviousMonthTurnover = PreviousMonthTurnover;
        }
    }
}
