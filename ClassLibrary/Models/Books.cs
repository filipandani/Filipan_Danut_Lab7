using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryModel.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<PublishedBooks> PublishedBook { get; set; }

    }
}
