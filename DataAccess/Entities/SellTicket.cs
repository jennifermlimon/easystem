using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class SellTicket
    {
        [Key]
        public Guid SellTicketId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public int Quantity => 0;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }
        [Required]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        [Required]
        public DateTime SellTicketDate { get; set; }
        [Required]
        public Guid CashierId { get; set; }
        public Cashier Cashier { get; set; }
    }
}
