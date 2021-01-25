using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Israelsen
{
    public enum RushOrder
    {
        NoRush,
        Rush3,
        Rush5,
        Rush7
    }
    public class DeskQuote
    {
        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal Price { get; set; }

        public RushOrder RushOrder { get; set; }

        public Desk Desk { get; set; }

        public decimal CalcTotalPrice()
        {
            //temp.
            return 0;
        }
    }
}
