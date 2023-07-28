using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndService.Service
{
    public class BookService
    {
        private LibraryManagementDb _libdb = new LibraryManagementDb();
        public void Create(Book book)
        {
            _libdb.Books.Add(book);
            _libdb.SaveChanges();
        }
        public void Delete(Book book)
        {
            _libdb.Books.Remove(book);
            _libdb.SaveChanges();

        }
        public List<Book> GetAll() 
        {
            return _libdb.Books.ToList();
        }
        public void Update(Book book)
        {
            var bk = _libdb.Books.FirstOrDefault(book => book.Id == book.Id);
            if (bk != null)
            {
                bk.Title = book.Title;
                bk.Description = book.Description;
                bk.Author = book.Author;
                bk.Quantity = book.Quantity;
                bk.Price = book.Price;
                _libdb.SaveChanges();
            }
        }
    }
}
