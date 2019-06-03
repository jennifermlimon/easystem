using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Supplier
    {
        [Key]
        public Guid SupplierId { get; set; }
        [StringLength(25)]
        [MinLength(1)]
        [Required]
        public string SupplierName { get; set; }
        [StringLength(13)]
        [MinLength(9)]
        [Required]
        public string SupplierTelephone { get; set; }
        [StringLength(9)]
        [MinLength(9)]
        [Required]
        public string SupplierCif { get; set; }
        [StringLength(50)]
        [MinLength(7)]
        [Required]
        public string SupplierEmail { get; set; }
        [StringLength(50)]
        [MinLength(1)]        
        public string SupplierAdress { get; set; }
    }
}
