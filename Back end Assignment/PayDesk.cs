using Back_end_Assignment.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Back_end_Assignment
{
    class PayDesk
    {
        private double purchaseValue;

        public double PurchaseValue
        {
            get { return purchaseValue; }
            set { purchaseValue = value; }
        }
        private DiscountCard card;

        public DiscountCard Card
        {
            get { return card; }
            set { card = value; }
        }
        public PayDesk(double PurchaseValue, double Turnover, int TypeOfCard)
        {
            this.PurchaseValue = PurchaseValue;
            switch (TypeOfCard)
            {
                case 1:
                    this.card = new BronzeCard(Turnover);
                    break;
                case 2:
                    this.card = new SilverCard(Turnover);
                    break;
                case 3:
                    this.card = new GoldCard(Turnover);
                    break;
                default:
                    break;
            }
        }
        static void GetDiscount()
        {
            
        }
    }
}
