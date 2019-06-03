using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [StringLength(15)]
        [MinLength(8)]
        public string UserName { get; set; }
        [StringLength(14)]
        [MinLength(6)]
        public string UserPassword { get; set; }
    }
}
