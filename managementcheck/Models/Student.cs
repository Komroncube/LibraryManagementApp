namespace managementcheck.Models
{
    public class Student : IPerson
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Faculty Faculty { get; set; }
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public ICollection<BookStudent> BookStudents { get; set; }
        public ICollection<BoughtBooks> BoughtBooks { get; set; }

    }
}
