using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ContactInfo
    {
        public int ContactInfoId { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string PhoneNumber { get; set; }
        [Required, Column(TypeName = "varchar(320)")]
        public string Email { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
