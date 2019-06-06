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
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public Guid? ClientId { get; set; }
        public Client Client { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
