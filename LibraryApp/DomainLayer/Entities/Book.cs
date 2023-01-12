using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public List<Book> Books { get; set; }

        public Library Library { get; set; }
    }
}
