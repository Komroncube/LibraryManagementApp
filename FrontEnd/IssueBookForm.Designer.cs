namespace FrontEnd
{
    partial class IssueBookForm
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
            student_lbl = new Label();
            book_lbl = new Label();
            student_input = new TextBox();
            book_input = new TextBox();
            issue_btn = new Button();
            studentdataview = new DataGridView();
            bookdataview = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentdataview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookdataview).BeginInit();
            SuspendLayout();
            // 
            // student_lbl
            // 
            student_lbl.AutoSize = true;
            student_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            student_lbl.Location = new Point(12, 143);
            student_lbl.Name = "student_lbl";
            student_lbl.Size = new Size(113, 32);
            student_lbl.TabIndex = 0;
            student_lbl.Text = "Student";
            // 
            // book_lbl
            // 
            book_lbl.AutoSize = true;
            book_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            book_lbl.Location = new Point(12, 239);
            book_lbl.Name = "book_lbl";
            book_lbl.Size = new Size(79, 32);
            book_lbl.TabIndex = 0;
            book_lbl.Text = "Book";
            // 
            // student_input
            // 
            student_input.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            student_input.Location = new Point(131, 142);
            student_input.Name = "student_input";
            student_input.PlaceholderText = "firstname or lastname";
            student_input.Size = new Size(260, 35);
            student_input.TabIndex = 1;
            student_input.TextChanged += student_input_TextChanged;
            // 
            // book_input
            // 
            book_input.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            book_input.Location = new Point(131, 240);
            book_input.Name = "book_input";
            book_input.PlaceholderText = "any information about book";
            book_input.Size = new Size(260, 32);
            book_input.TabIndex = 1;
            book_input.TextChanged += book_input_TextChanged;
            // 
            // issue_btn
            // 
            issue_btn.Location = new Point(152, 341);
            issue_btn.Name = "issue_btn";
            issue_btn.Size = new Size(151, 55);
            issue_btn.TabIndex = 2;
            issue_btn.Text = "Issue book";
            issue_btn.UseVisualStyleBackColor = true;
            issue_btn.Click += issue_btn_Click;
            // 
            // studentdataview
            // 
            studentdataview.AllowUserToAddRows = false;
            studentdataview.AllowUserToDeleteRows = false;
            studentdataview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentdataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentdataview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentdataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentdataview.Location = new Point(574, 64);
            studentdataview.Name = "studentdataview";
            studentdataview.ReadOnly = true;
            studentdataview.RowHeadersWidth = 62;
            studentdataview.RowTemplate.Height = 33;
            studentdataview.Size = new Size(792, 257);
            studentdataview.TabIndex = 3;
            studentdataview.CellFormatting += studentdataGridView_CellFormatting;
            // 
            // bookdataview
            // 
            bookdataview.AllowUserToAddRows = false;
            bookdataview.AllowUserToDeleteRows = false;
            bookdataview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bookdataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookdataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookdataview.Location = new Point(574, 423);
            bookdataview.Name = "bookdataview";
            bookdataview.ReadOnly = true;
            bookdataview.RowHeadersWidth = 62;
            bookdataview.RowTemplate.Height = 33;
            bookdataview.Size = new Size(792, 309);
            bookdataview.TabIndex = 3;
            bookdataview.CellFormatting += bookdataGridView_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(919, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 38);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(936, 358);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 0;
            label2.Text = "Books";
            // 
            // IssueBookForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 744);
            Controls.Add(bookdataview);
            Controls.Add(studentdataview);
            Controls.Add(issue_btn);
            Controls.Add(book_input);
            Controls.Add(student_input);
            Controls.Add(book_lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(student_lbl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "IssueBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue book";
            ((System.ComponentModel.ISupportInitialize)studentdataview).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookdataview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label student_lbl;
        private Label book_lbl;
        private TextBox student_input;
        private TextBox book_input;
        private Button issue_btn;
        private DataGridView studentdataview;
        private DataGridView bookdataview;
        private Label label1;
        private Label label2;
    }
}