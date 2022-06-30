using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Loan
    {
        protected User user;
        protected List<Item> items;
        protected string dateStartBorrow = null;
        protected string dateEndBorrow = null;

        public Loan(User user, List<Item> items)
        {
            this.user = user;
            this.items = items;
        }

        public void Borrow(User user, Item item)
        {

        }
    }

}
