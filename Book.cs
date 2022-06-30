using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Item
    {
        private int nPages;
        public Book(int nPages, int itemCode, string title, int year, string sector, bool isAvaible, int rack, string author) : base(itemCode, title, year, sector, isAvaible, rack, author)
        {
            this.nPages = nPages;
        }
    }
}
