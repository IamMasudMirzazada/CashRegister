using Cash.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash
{
    class CashRegister
    {
        public double TotalAmount { get; set; }
        static int TotalSalesCount = 0;
        public Currency Currency;


        public CashRegister(int totalAmount, Currency currency)
        {
            TotalAmount = totalAmount;
            Currency = currency;
        }

        public void AddNewSale(double mebleg, Currency currency)
        {
            if (Currency == currency)
            {
                TotalAmount += mebleg;
            }
            else
            {
                switch ((int)currency)
                {
                    case (int)Currency.dollar:
                        TotalAmount = TotalAmount + mebleg * 1.70 ;
                        break;
                    case (int)Currency.manat:
                        TotalAmount = TotalAmount + mebleg / 1.70 ;
                        break;
                }
            }
        }


        public void RemoveSale(double mebleg, Currency currency)
        {
            if (Currency == currency)
            {
                TotalAmount -= mebleg;
            }
            else
            {
                switch ((int)currency)
                {
                    case (int)Currency.dollar:
                        TotalAmount = TotalAmount - mebleg * 1.70;
                        break;
                    case (int)Currency.manat:
                        TotalAmount = TotalAmount - mebleg / 1.70;
                        break;
                }
            }
        }
    }
}
