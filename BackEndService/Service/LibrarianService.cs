namespace managementcheck.Service
{
    public class LibrarianService : IDatabaseService<Librarian> 
    {
        private LibraryManagementDb _libdb = new LibraryManagementDb();
        public void Create(Librarian librarian)
        {
            _libdb.Librarian.Add(librarian);
            _libdb.SaveChanges();
        }
        public IEnumerable<Librarian> GetAll()
        {
            return _libdb.Librarian.ToList();
        }
        public void Delete(Guid id)
        {
            var entity = _libdb.Librarian.FirstOrDefault(x =>x.Id ==id);
            if(entity!= null)
            {
                _libdb.Librarian.Remove(entity);
                _libdb.SaveChanges();
            }
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
        public bool isExist(string username)
        {
            return _libdb.Librarian.Where(x=>x.UserName == username).Any();
        }
        public bool CheckUser(string username, string password, out Guid id)
        {
            id = Guid.Empty;
            var user = _libdb.Librarian.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if(user!= null) 
            {
                id = user.Id;
                return user != null;
            }
            return false;

            
        }
        public int GetCount()
        {
            return _libdb.Librarian.Count();
        }
    }
}
