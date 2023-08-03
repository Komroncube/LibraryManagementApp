namespace managementcheck.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Book()
        {
            Id = Guid.NewGuid();
        }
        public ICollection<BookStudent> BookStudents { get; set; }
        public ICollection<BoughtBooks> BoughtBooks { get; set; }
    }
}
