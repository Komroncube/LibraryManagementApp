// See https://aka.ms/new-console-template for more information
using BackEndService.Models;
using BackEndService.Service;

Console.WriteLine("Hello, World!");
var book = new Book()
{
    Title = "My little prince",
    Description = "bolalar va kattalarning dunyoqarashi farqi haqida",
    Author = "Antuan de Sent Ekzyuperi",
    Quantity = 100,
    Price = 43,

};
BookService bookService = new BookService();
//bookService.Create(book);

var st = new Student()
{
    FirstName = "Letti",
    LastName = "Ortiz",
    PhoneNumber = "12345678902",
    Faculty = BackEndService.Enums.Faculty.Buxgalteriya_hisobi_va_audit
};
StudentService stservice = new StudentService();
//stservice.Create(st);
var lb = new Librarian()
{
    FirstName = "Teo",
    LastName = "Hernandez",
    PhoneNumber = "998374892304",
    UserName = "Teojon",
    Password = "Lz123",
};
LibrarianService ls = new LibrarianService();
ls.Create(lb);