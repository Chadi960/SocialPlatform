using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Gender
    {
        public Char GenderID { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
