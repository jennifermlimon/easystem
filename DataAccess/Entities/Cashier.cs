using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Cashier
    {
        public Guid CashierId { get; set; }
        public DateTime OpenDateTime { get; set; }
        public DateTime CloseDateTime { get; set; }
        public bool Close { get; set; }
        public double Amount { get; set; }
        public int Remaining => 100;
        public double ToBank { get; set; }
        public ICollection<SellTicket> SellTickets { get; set; }
    }
}
