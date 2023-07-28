namespace FrontEnd
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            student = new Label();
            books = new Label();
            librarian = new Label();
            issuebook = new Label();
            returnbook = new Label();
            logout = new Label();
            SuspendLayout();
            // 
            // student
            // 
            student.AutoSize = true;
            student.Location = new Point(519, 23);
            student.Name = "student";
            student.Size = new Size(124, 38);
            student.TabIndex = 0;
            student.Text = "Students";
            // 
            // books
            // 
            books.AutoSize = true;
            books.Location = new Point(649, 23);
            books.Name = "books";
            books.Size = new Size(91, 38);
            books.TabIndex = 0;
            books.Text = "Books";
            // 
            // librarian
            // 
            librarian.AutoSize = true;
            librarian.Location = new Point(1100, 23);
            librarian.Name = "librarian";
            librarian.Size = new Size(136, 38);
            librarian.TabIndex = 0;
            librarian.Text = "Librarians";
            // 
            // issuebook
            // 
            issuebook.AutoSize = true;
            issuebook.Location = new Point(746, 23);
            issuebook.Name = "issuebook";
            issuebook.Size = new Size(161, 38);
            issuebook.TabIndex = 0;
            issuebook.Text = "Issue books";
            // 
            // returnbook
            // 
            returnbook.AutoSize = true;
            returnbook.Location = new Point(913, 23);
            returnbook.Name = "returnbook";
            returnbook.Size = new Size(181, 38);
            returnbook.TabIndex = 0;
            returnbook.Text = "Return books";
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.Location = new Point(1242, 23);
            logout.Name = "logout";
            logout.Size = new Size(111, 38);
            logout.TabIndex = 0;
            logout.Text = "Log out";
            // 
            // MainPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1378, 844);
            Controls.Add(logout);
            Controls.Add(returnbook);
            Controls.Add(issuebook);
            Controls.Add(librarian);
            Controls.Add(books);
            Controls.Add(student);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label student;
        private Label books;
        private Label librarian;
        private Label issuebook;
        private Label returnbook;
        private Label logout;
    }
}