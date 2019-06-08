using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Stock
    {
        public Guid StockId { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime DateIn = DateTime.Today;
        public DateTime? DateOut { get; set; }
        public Guid BuyTicketId { get; set; }
        public BuyTicket BuyTicket { get; set; }
        public Guid? SellTicketId { get; set; }
        public SellTicket SellTicket { get; set; }
    }
}
