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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            student = new Label();
            books = new Label();
            librarian = new Label();
            issuebook = new Label();
            returnbook = new Label();
            logout = new Label();
            panel1 = new Panel();
            buybook_lbl = new Label();
            panel2 = new Panel();
            std_count = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            book_count = new Label();
            panel4 = new Panel();
            label5 = new Label();
            librarian_count = new Label();
            panel5 = new Panel();
            label7 = new Label();
            issued_count = new Label();
            panel6 = new Panel();
            label9 = new Label();
            returned_count = new Label();
            panel7 = new Panel();
            label11 = new Label();
            sold_count = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // student
            // 
            student.AutoSize = true;
            student.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            student.ForeColor = SystemColors.ControlLightLight;
            student.Location = new Point(281, 37);
            student.Name = "student";
            student.Size = new Size(144, 45);
            student.TabIndex = 0;
            student.Text = "Students";
            student.Click += student_Click;
            student.MouseLeave += student_MouseLeave;
            student.MouseHover += student_MouseHover;
            // 
            // books
            // 
            books.AutoSize = true;
            books.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            books.ForeColor = SystemColors.ControlLightLight;
            books.Location = new Point(425, 37);
            books.Name = "books";
            books.Size = new Size(106, 45);
            books.TabIndex = 0;
            books.Text = "Books";
            books.Click += books_Click;
            // 
            // librarian
            // 
            librarian.AutoSize = true;
            librarian.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            librarian.ForeColor = SystemColors.ControlLightLight;
            librarian.Location = new Point(1081, 37);
            librarian.Name = "librarian";
            librarian.Size = new Size(156, 45);
            librarian.TabIndex = 0;
            librarian.Text = "Librarians";
            librarian.Click += librarian_Click;
            // 
            // issuebook
            // 
            issuebook.AutoSize = true;
            issuebook.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            issuebook.ForeColor = SystemColors.ControlLightLight;
            issuebook.Location = new Point(531, 37);
            issuebook.Name = "issuebook";
            issuebook.Size = new Size(188, 45);
            issuebook.TabIndex = 0;
            issuebook.Text = "Issue books";
            issuebook.Click += issuebook_Click;
            // 
            // returnbook
            // 
            returnbook.AutoSize = true;
            returnbook.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            returnbook.ForeColor = SystemColors.ControlLightLight;
            returnbook.Location = new Point(719, 37);
            returnbook.Name = "returnbook";
            returnbook.Size = new Size(209, 45);
            returnbook.TabIndex = 0;
            returnbook.Text = "Return books";
            returnbook.Click += returnbook_Click;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            logout.ForeColor = Color.Red;
            logout.Location = new Point(1237, 37);
            logout.Name = "logout";
            logout.Size = new Size(130, 45);
            logout.TabIndex = 0;
            logout.Text = "Log out";
            logout.Click += logout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(logout);
            panel1.Controls.Add(librarian);
            panel1.Controls.Add(buybook_lbl);
            panel1.Controls.Add(returnbook);
            panel1.Controls.Add(issuebook);
            panel1.Controls.Add(books);
            panel1.Controls.Add(student);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 119);
            panel1.TabIndex = 1;
            // 
            // buybook_lbl
            // 
            buybook_lbl.AutoSize = true;
            buybook_lbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buybook_lbl.ForeColor = SystemColors.ControlLightLight;
            buybook_lbl.Location = new Point(928, 37);
            buybook_lbl.Name = "buybook_lbl";
            buybook_lbl.Size = new Size(153, 45);
            buybook_lbl.TabIndex = 0;
            buybook_lbl.Text = "Buy book";
            buybook_lbl.Click += buybook_lbl_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(std_count);
            panel2.Location = new Point(58, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 1;
            // 
            // std_count
            // 
            std_count.AutoSize = true;
            std_count.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            std_count.Location = new Point(128, 31);
            std_count.Name = "std_count";
            std_count.Size = new Size(37, 45);
            std_count.TabIndex = 0;
            std_count.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 100);
            label2.Name = "label2";
            label2.Size = new Size(124, 38);
            label2.TabIndex = 0;
            label2.Text = "Students";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(book_count);
            panel3.Location = new Point(549, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 100);
            label3.Name = "label3";
            label3.Size = new Size(91, 38);
            label3.TabIndex = 0;
            label3.Text = "Books";
            // 
            // book_count
            // 
            book_count.AutoSize = true;
            book_count.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            book_count.Location = new Point(128, 31);
            book_count.Name = "book_count";
            book_count.Size = new Size(37, 45);
            book_count.TabIndex = 0;
            book_count.Text = "1";
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(librarian_count);
            panel4.Location = new Point(1040, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 150);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 100);
            label5.Name = "label5";
            label5.Size = new Size(136, 38);
            label5.TabIndex = 0;
            label5.Text = "Librarians";
            // 
            // librarian_count
            // 
            librarian_count.AutoSize = true;
            librarian_count.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            librarian_count.Location = new Point(128, 31);
            librarian_count.Name = "librarian_count";
            librarian_count.Size = new Size(37, 45);
            librarian_count.TabIndex = 0;
            librarian_count.Text = "1";
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Controls.Add(issued_count);
            panel5.Location = new Point(58, 437);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 150);
            panel5.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 100);
            label7.Name = "label7";
            label7.Size = new Size(177, 38);
            label7.TabIndex = 0;
            label7.Text = "Issued books";
            // 
            // issued_count
            // 
            issued_count.AutoSize = true;
            issued_count.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            issued_count.Location = new Point(128, 31);
            issued_count.Name = "issued_count";
            issued_count.Size = new Size(37, 45);
            issued_count.TabIndex = 0;
            issued_count.Text = "1";
            // 
            // panel6
            // 
            panel6.Controls.Add(label9);
            panel6.Controls.Add(returned_count);
            panel6.Location = new Point(549, 437);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 150);
            panel6.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 100);
            label9.Name = "label9";
            label9.Size = new Size(212, 38);
            label9.TabIndex = 0;
            label9.Text = "Returned books";
            // 
            // returned_count
            // 
            returned_count.AutoSize = true;
            returned_count.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            returned_count.Location = new Point(128, 31);
            returned_count.Name = "returned_count";
            returned_count.Size = new Size(37, 45);
            returned_count.TabIndex = 0;
            returned_count.Text = "1";
            // 
            // panel7
            // 
            panel7.Controls.Add(label11);
            panel7.Controls.Add(sold_count);
            panel7.Location = new Point(1040, 437);
            panel7.Name = "panel7";
            panel7.Size = new Size(300, 150);
            panel7.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(71, 100);
            label11.Name = "label11";
            label11.Size = new Size(153, 38);
            label11.TabIndex = 0;
            label11.Text = "Sold books";
            // 
            // sold_count
            // 
            sold_count.AutoSize = true;
            sold_count.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sold_count.Location = new Point(128, 31);
            sold_count.Name = "sold_count";
            sold_count.Size = new Size(37, 45);
            sold_count.TabIndex = 0;
            sold_count.Text = "1";
            // 
            // MainPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1378, 844);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label student;
        private Label books;
        private Label librarian;
        private Label issuebook;
        private Label returnbook;
        private Label logout;
        private Panel panel1;
        private Label buybook_lbl;
        private Panel panel2;
        private Label label2;
        private Label std_count;
        private Panel panel3;
        private Label label3;
        private Label book_count;
        private Panel panel4;
        private Label label5;
        private Label librarian_count;
        private Panel panel5;
        private Label label7;
        private Label issued_count;
        private Panel panel6;
        private Label label9;
        private Label returned_count;
        private Panel panel7;
        private Label label11;
        private Label sold_count;
    }
}