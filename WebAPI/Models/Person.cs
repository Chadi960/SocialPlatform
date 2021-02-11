using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [Required, Column(TypeName = "varchar(35)")]
        public string FirstName { get; set; }
        [Required, Column(TypeName = "varchar(35)")]
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [Required, Column(TypeName = "varchar(40)")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        [ForeignKey("GenderFK")]
        public int? Gender { get; set; }
        public Genders GenderFK { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
