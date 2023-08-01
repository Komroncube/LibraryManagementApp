using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndService.ViewModels
{
    public class BookStudentView
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Author { get; set; }
        public Status Status { get; set; }
        public int Quantity { get; set; }
    }
}
