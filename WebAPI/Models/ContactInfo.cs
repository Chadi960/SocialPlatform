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
        public int ContactInfoID { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string PhoneNumber { get; set; }
        [Required, Column(TypeName = "varchar(320)")]
        public string Email { get; set; }

        [ForeignKey("Person")]
        public int PersonFK { get; set; }
        public Person Person { get; set; }
    }
}
