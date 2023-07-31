namespace BackEndService.Service
{
    public class StudentService
    {
        private LibraryManagementDb _libdb = new LibraryManagementDb();
        public void Create(Student student)
        {
            _libdb.Students.Add(student);
            _libdb.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var entity = _libdb.Students.FirstOrDefault(x =>x.Id ==id);
            if (entity != null)
            {
                _libdb.Students.Remove(entity);
                _libdb.SaveChanges();

            }

        }
        public List<Student> GetAll()
        {
            return _libdb.Students.AsNoTracking().ToList();
        }
        public void Update(Student student)
        {
            var st=_libdb.Students.FirstOrDefault(x=>x.Id == student.Id);
            if (st != null)
            {
                st.FirstName = student.FirstName;
                st.LastName = student.LastName;
                st.PhoneNumber = student.PhoneNumber;
                st.Faculty = student.Faculty;
                _libdb.SaveChanges();

            }
        }
    }
}
