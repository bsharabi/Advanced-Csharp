using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    class book
    {
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set
            {
                if (value.Length > 2 && value.Length > 15)
                    bookName = value;
            }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 18 && value < 120)
                    price = value;
            }
        }

        private int authorId;

        public int AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }

    }
}



