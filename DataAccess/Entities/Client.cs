using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Client
    {
        [Key]
        public Guid ClientId { get; set; }
        [StringLength(25)]
        [MinLength(1)]
        [Required]
        public string ClientName { get; set; }
        [StringLength(25)]
        [MinLength(3)]
        [Required]
        public string ClientSurname1 { get; set; }
        [StringLength(25)]                
        public string ClientSurname2 { get; set; }   
        [Required]
        public DateTime ClientDateOfBirth { get; set; }
        [StringLength(13)]
        [MinLength(9)]
        [Required]
        public string CLientTelephone { get; set; }
        [StringLength(9)]
        [MinLength(9)]
        [Required]
        public string ClientNif { get; set; }
        [StringLength(50)]
        [MinLength(7)]
        [Required]
        public string ClientEmail { get; set; }
        [StringLength(50)]        
        public string ClientAdress { get; set; }
    }
}
