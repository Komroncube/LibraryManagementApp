using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndService.Service
{
    public class LibrarianService
    {
        private LibraryManagementDb _libdb = new LibraryManagementDb();
        public void Create(Librarian librarian)
        {
            _libdb.Librarian.Add(librarian);
            _libdb.SaveChanges();
        }
        public List<Librarian> GetAll()
        {
            return _libdb.Librarian.ToList();
        }
        public void Delete(Librarian librarian)
        {
            _libdb.Librarian.Remove(librarian);
            _libdb.SaveChanges();
        }
        public void Update(Librarian librarian)
        {
            var lb = _libdb.Librarian.FirstOrDefault(x => x.Id == librarian.Id);
            if (lb != null) 
            {
                lb.FirstName = librarian.FirstName;
                lb.LastName = librarian.LastName;
                lb.PhoneNumber = librarian.PhoneNumber;
                lb.UserName = librarian.UserName;
                lb.Password = librarian.Password;
                _libdb.SaveChanges();
            }
        }
    }
}
