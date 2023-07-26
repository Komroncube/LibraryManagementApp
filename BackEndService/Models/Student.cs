using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndService.Models
{
    public class Student : IPerson
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Faculty { get; set; }
        public ICollection<BookStudent> BookStudents { get; set; }


    }
}
