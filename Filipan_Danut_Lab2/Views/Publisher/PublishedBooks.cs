using Filipan_Danut_Lab2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Filipan_Danut_Lab2.Views.Books
{
    public class PublishedBooks
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public Publishers Publishers { get; set; }
        public Filipan_Danut_Lab2.Models.Books  Books { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6,2")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<PublishedBooks> PublishedBook { get; set; }



    }
}
