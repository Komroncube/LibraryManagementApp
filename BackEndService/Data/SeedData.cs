using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndService.Data
{
    public class SeedData
    {
        public Guid[] students = new Guid[]
        {
            Guid.Parse("e8ba3b0b-9481-4ef4-883f-6df822b55884"),
            Guid.Parse("2ebec012-d020-43c0-b621-6092fc700312"),
            Guid.Parse("7fcf0586-0358-4638-91cd-147b1a014b05")
        };
        public Guid[] books = new Guid[]
        {
            Guid.Parse("a09b59e7-240c-4a28-919f-8a19dfc2a86e"),
            Guid.Parse("9745f08c-4cbc-4888-a881-c890842e0ead"),
            Guid.Parse("e25020c2-9175-4ec4-8cb8-dfa0e11686f8")
        };
        public Guid[] librarian = new Guid[]
        {
            Guid.Parse("570fe434-6f20-44e2-83a8-84dec81b8108"),
            Guid.Parse("d1707dfc-85f9-4039-ac3a-0d1358554e46")
        };
    }
}
