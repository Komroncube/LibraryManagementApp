using BackEndService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndService.Service
{
    public class BookOperation
    {
        private static LibraryManagementDb _libdb = new LibraryManagementDb();
        public void IssueBook(BookStudent bookStudent)
        {
            _libdb.BookStudents.Add(bookStudent);
            var book = _libdb.Books.FirstOrDefault(x=>x.Id == bookStudent.BookId);
            if (book != null)
            {
                book.Quantity -= 1;
            }
            _libdb.SaveChanges();
        }
        public void ReturnBook(Guid IssuedBookId)
        {
            var takenbook = _libdb.BookStudents.FirstOrDefault(x => x.Id == IssuedBookId);
            if (takenbook != null)
            {
                var book = _libdb.Books.FirstOrDefault(x => x.Id == takenbook.BookId);
                if (book != null)
                {
                    book.Quantity += 1;
                }
                takenbook.Status = Status.Returned;
                takenbook.ReturnDate = DateTime.UtcNow;
                _libdb.SaveChanges();
            }
        }
        public void BuyBook(BoughtBooks buybook)
        {
            var book = _libdb.Books.FirstOrDefault(x => x.Id == buybook.BookId);
            if (book != null)
            {
                book.Quantity -= buybook.Quantity;
            }
            _libdb.BoughtBooks.Add(buybook);
            _libdb.SaveChanges();
        }
        public static IEnumerable<BookStudentView> GetStudentBooks()
        {
            return from BookStudents in _libdb.BookStudents
                   join student in _libdb.Students on BookStudents.StudentId equals student.Id
                   join book in _libdb.Books on BookStudents.BookId equals book.Id where book.Quantity>0
                   select new BookStudentView()
                   {
                       Id = BookStudents.Id,
                       FirstName = student.FirstName,
                       LastName = student.LastName,
                       PhoneNumber = student.PhoneNumber,
                       Title = book.Title,
                       Description = book.Description,
                       Author = book.Author,
                       Status = BookStudents.Status,
                       Quantity = book.Quantity,
                   };
        }
    }
}
