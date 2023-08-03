﻿namespace managementcheck.Service
{
    public class BookService : IDatabaseService<Book>
    {
        private LibraryManagementDb _libdb = new LibraryManagementDb();
        public void Create(Book book)
        {
            _libdb.Books.Add(book);
            _libdb.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var entity = _libdb.Books.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _libdb.Books.Remove(entity);
                _libdb.SaveChanges();

            }
        }
        public IEnumerable<Book> GetAll() 
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
        public int GetCount()
        {
            return _libdb.Books.Count();
        }
    }
}
