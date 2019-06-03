using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [StringLength(25)]
        [MinLength(1)]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]       
        public decimal Price { get; set; }   
        public Guid SubcategoryId{ get; set; }
        public Subcategory Subcategory{ get; set; }  
        [Required]
        public double Earns { get; set; }
    }
}
