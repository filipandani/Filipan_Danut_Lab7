using LibraryModel.Models;
using LibraryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryModel.Models
{
    public class PublishedBooks
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public Publishers Publishers { get; set; }
        public Books  Books { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6,2")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<PublishedBooks> PublishedBook { get; set; }



    }
}
