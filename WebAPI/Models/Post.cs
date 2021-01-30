using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Post
    {
        public int PostId { get; set; }
        [Required, Column(TypeName = "varchar(300)")]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime TimeCreated { get; set; }

        public int? PersonId { get; set; }
        public Person Person { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
