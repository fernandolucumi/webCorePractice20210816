using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webCorePractice20210816.Models
{
    public class Article
    {
        public int ID { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
