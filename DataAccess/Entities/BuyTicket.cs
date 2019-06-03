using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class BuyTicket
    {
        [Key]
        public Guid BuyTicketId { get; set; }
        public virtual ICollection<Product> Products { get; set; }        
        public int Quantity => 0;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Supplier Supplier { get; set; }
        [Required]
        public DateTime BuyTicketDate { get; set; }
    }
}
