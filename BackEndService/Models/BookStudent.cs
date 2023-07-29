
namespace BackEndService.Models
{
    public class BookStudent
    {
        [Key]
        public Guid Id { get; set; }
        //[ForeignKey("Student")]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        //[ForeignKey("Book")]
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public DateTime IssueDate { get; set; }
        public Status Status { get; set; }
        public DateTime? ReturnDate { get; set; }
        public BookStudent() => Id = Guid.NewGuid();

    }
}
