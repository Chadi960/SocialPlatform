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
        public int CommentId { get; set; }
        [Required, Column(TypeName = "varchar(50)")]
        public string Content { get; set; }
        public DateTime TimeCreated { get; set; }
        
        public int? PostId { get; set; }
        public Post Post { get; set; }
        public int? PersonId { get; set; }
        public Person Person { get; set; }
    }
}
