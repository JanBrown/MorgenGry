using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class BookRepository
    {
        private List<Book> books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            foreach (var b in books)
            {
                if (b.ItemId == itemId)
                    return b;
            }
            return null;
        }
        public double GetTotalValue()
        {
            double totalValue = 0.0;

            foreach (var b in books)
            {
                totalValue += Utility.GetValueOfBook(b);
            }

            return totalValue;
        }
    }
}
