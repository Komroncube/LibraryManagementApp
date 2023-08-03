using BookStudentView = managementcheck.ViewModels.BookStudentView;

namespace managementcheck.Service
{
    public class BookOperation
    {
        private LibraryManagementDb _libdb;
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=LibraryManagementAppDb";
        public BookOperation( )
        {
            _libdb = new LibraryManagementDb();
        }
        public void IssueBook(BookStudent bookStudent)
        {
            
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = "Insert into public.\"BookStudents\" (\"Id\", \"StudentId\", \"BookId\", \"IssueDate\", \"Status\", \"ReturnDate\")  values(@id, @StudentId, @BookId, @IssueDate, @Status, @ReturnDate)";
                connection.Execute(sqlQuery, bookStudent);
            }
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
        public IEnumerable<BookStudentView> GetStudentBooks()
        {
            return from BookStudents in _libdb.BookStudents
                   join student in _libdb.Students on BookStudents.StudentId equals student.Id
                   join book in _libdb.Books on BookStudents.BookId equals book.Id
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
                       ReturnedDate = BookStudents.ReturnDate
                   };
        }
        public int GetIssuedCount()
        {
            return _libdb.BookStudents.Where(x => x.Status == 0).Count();
        }
        public int GetReturnedCount()
        {
            return _libdb.BookStudents.Where(x=>x.Status==Status.Returned).Count();
        }
        public int GetSoldBooks()
        {
            return _libdb.BoughtBooks.Select(x => x.Quantity).Sum();
        }
    }
}
