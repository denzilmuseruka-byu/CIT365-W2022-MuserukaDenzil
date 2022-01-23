using System;

namespace MegaDesk_Museruka
{
    public class DeskQuote
    {
        //Desk, rush days, customer name, and quote date. This class will also hold the logic in determining the desk quote total.

        public string CustomerName {get;set;}
        public int RushDays {get;set;}
        public Desk Desk {get;set;}
        public DateTime QuoteDate {get;set;}
       

        public void CalculateDeskQuoteTotal()
        {

        }

    }
}
