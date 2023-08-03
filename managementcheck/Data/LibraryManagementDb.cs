
namespace managementcheck.Data
{
    public class LibraryManagementDb : DbContext
    {
      //  public LibraryManagementDb() : base(options) { }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=root;Database=LibraryManagementAppDb");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }


        
        Action<ModelBuilder> AddSeedData;
        
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
            

            base.OnModelCreating(modelBuilder);
            //AddStudent(modelBuilder);
            //AddLibrarian(modelBuilder);
            //AddBook(modelBuilder);
            AddSeedData += AddStudent;
            AddSeedData += AddLibrarian;
            AddSeedData += AddBook;
            AddSeedData.Invoke(modelBuilder);
        }
        private void AddStudent(ModelBuilder modelBuilder)
        {
            SeedData sd = new SeedData();

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = Guid.Parse("92bb0fa8-4b24-4f68-993e-d8a3cdd70e9a"),
                    FirstName = "Paul",
                    LastName = "Walker",
                    PhoneNumber = "9982345678",
                    Faculty = Faculty.Moliya,
                },
                new Student
                {
                    Id = Guid.Parse("a15d5783-4e91-4d41-bb77-ac603a08ac80"),
                    FirstName = "Dominik",
                    LastName = "Toretto",
                    PhoneNumber = "888892834769",
                    Faculty = Faculty.Soliq_va_sugurta,
                },
                new Student
                {
                    Id = Guid.Parse("8b1642e5-43fc-443c-9bbf-afbe7d502bd4"),
                    FirstName = "Pirc",
                    LastName = "Roman",
                    PhoneNumber = "998992349012",
                    Faculty = Faculty.Byudjet_hisobi_va_gaznachilik,
                });
        }
        private void AddLibrarian(ModelBuilder modelBuilder)
        {
            SeedData sd = new SeedData();

            modelBuilder.Entity<Librarian>().HasData(
                new Librarian()

                {
                    Id = Guid.Parse("cb2633d5-b064-4a24-b193-bc95fc702595"),

                    FirstName = "Judit",
                    LastName = "Polgar",
                    PhoneNumber = "998973290312",
                    UserName = "judpl",
                    Password = "Pass123",
                },
                new Librarian()
                {
                    Id = Guid.Parse("d67b3d81-b3c7-499e-b026-c48af4e039f5"),

                    FirstName = "Izabella",
                    LastName = "Dickson",
                    PhoneNumber = "998913845940",
                    UserName = "Iza",
                    Password = "Izason11",
                });
        }
        private void AddBook(ModelBuilder modelBuilder)
        {
            SeedData sd = new SeedData();

            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = Guid.Parse("49eb1f21-cc89-427a-9611-feb264e4055a"),

                    Title = "Anna Karenina",
                    Author = "Lev Tolstoy",
                    Description = "Lorem ipsum",
                    Quantity = 30,
                    Price = 23
                },
                new Book()
                {
                    Id = Guid.Parse("e6267aaa-a321-43b0-a021-779789489b8f"),
                    Title = "Madame Bovary",
                    Author = "Gustav Flaubert",
                    Description = "Lorem ipsum",
                    Quantity = 20,
                    Price = 30,
                });
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Librarian> Librarian { get; set; }
        public DbSet<BookStudent> BookStudents { get; set; }
        public DbSet<BoughtBooks> BoughtBooks { get; set; }
    }
}
