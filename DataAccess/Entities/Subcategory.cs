using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Subcategory
    {
        [Key]
        public Guid SubcategoryId { get; set; }
        [StringLength(25)]
        [MinLength(1)]
        [Required]
        public string SubcategoryName { get; set; }
        public string SubcategoryDescription { get; set; }
        public Category Category{ get; set; }
        public Guid CategoryId { get; set; }
    }
}
