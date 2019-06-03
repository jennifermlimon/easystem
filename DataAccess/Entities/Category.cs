using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [StringLength(25)]
        [MinLength(1)]
        [Required]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
