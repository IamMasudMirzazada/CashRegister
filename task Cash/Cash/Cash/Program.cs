using Cash.Enums;
using System;

namespace Cash
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cr1 = new CashRegister(0, Currency.manat);
            cr1.AddNewSale(89, Currency.dollar);
            cr1.AddNewSale( 200, Currency.manat);
            cr1.AddNewSale(30, Currency.manat);
            cr1.RemoveSale(45 , Currency.dollar);
            cr1.RemoveSale(56 , Currency.manat);
             
            Console.WriteLine(cr1.TotalAmount ); 
        }
    }
}
