using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filipan_Danut_Lab2.Models.LibraryVievModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publishers> Publishers { get; set; }
        public IEnumerable<Books> Books { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
