﻿
namespace BackEndService.Data
{
    public class LibraryManagementDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=root;Database=LibraryManagementDb");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookStudent>()
                .HasOne<Student>(st => st.Student)
                .WithMany(s => s.BookStudents)
                .HasForeignKey(st => st.StudentId);
            modelBuilder.Entity<BookStudent>()
                .HasOne<Book>(st => st.Book)
                .WithMany(b => b.BookStudents)
                .HasForeignKey(bk => bk.BookId);

            modelBuilder.Entity<BoughtBooks>()
                .HasOne<Student>(st => st.Student)
                .WithMany(b => b.BoughtBooks)
                .HasForeignKey(st => st.StudentId);
            modelBuilder.Entity<BoughtBooks>()
                .HasOne<Book>(st => st.Book)
                .WithMany(b => b.BoughtBooks)
                .HasForeignKey(st => st.BookId);
            

            var sd = new SeedData();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = sd.students[0],
                    FirstName = "Paul",
                    LastName = "Walker",
                    PhoneNumber = "9982345678",
                    Faculty = Faculty.Moliya,
                },
                new Student
                {
                    Id = sd.students[1],
                    FirstName = "Dominik",
                    LastName = "Toretto",
                    PhoneNumber = "888892834769",
                    Faculty=Faculty.Soliq_va_sugurta,
                },
                new Student
                {
                    Id = sd.students[2],
                    FirstName = "Pirc",
                    LastName = "Roman",
                    PhoneNumber = "998992349012",
                    Faculty = Faculty.Byudjet_hisobi_va_gaznachilik,
                });
            modelBuilder.Entity<Librarian>().HasData(
                new Librarian()
                {
                    Id = sd.librarian[0],
                    FirstName = "Judit",
                    LastName = "Polgar",
                    PhoneNumber = "998973290312",
                    UserName = "judpl",
                    Password = "Pass123",
                },
                new Librarian()
                {
                    Id = sd.librarian[1],
                    FirstName = "Izabella",
                    LastName = "Dickson",
                    PhoneNumber ="998913845940",
                    UserName = "Iza",
                    Password = "Izason11",
                });
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = sd.books[0],
                    Title = "Anna Karenina",
                    Author = "Lev Tolstoy",
                    Description = "Lorem ipsum",
                    Quantity = 30,
                    Price = 23
                },
                new Book()
                {
                    Id = sd.books[1],
                    Title = "Madame Bovary",
                    Author = "Gustav Flaubert",
                    Description = "Lorem ipsum",
                    Quantity = 20,
                    Price = 30,
                },
                new Book()
                {
                    Id = sd.books[2],
                    Title = "War and Peace",
                    Author = "Lev Tolstoy",
                    Description = "Lorem ipsum",
                    Quantity = 12,
                    Price = 40,
                }

                );
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Librarian> Librarian { get; set; }
        public DbSet<BookStudent> BookStudents { get; set; }
        public DbSet<BoughtBooks> BoughtBooks { get; set; }
    }
}
