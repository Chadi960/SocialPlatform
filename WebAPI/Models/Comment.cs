using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        [Required, Column(TypeName = "varchar(50)")]
        public string Content { get; set; }
        public DateTime TimeCreated { get; set; }

        [ForeignKey("Post")]
        public int? PostFK { get; set; }
        public Post Post { get; set; }
        [ForeignKey("Person")]
        public int? PersonFK { get; set; }
        public Person Person { get; set; }
    }
}
