using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        public string Title {get; set;}

        public DateTime PublishedDate { get; set; }

        public string Description { get; set; }

        public string ISBN { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}