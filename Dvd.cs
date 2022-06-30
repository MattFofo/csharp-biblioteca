using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Item
    {
        protected int duration;
        protected int serialNumber;

        public Dvd(int duration, int itemCode, string title, int year, string sector, bool isAvaible, int rack, string author) : base(itemCode, title, year, sector, isAvaible, rack, author)
        {
            this.duration = duration;
        }
    }
}
