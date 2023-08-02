namespace FrontEnd
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            returneddataview = new DataGridView();
            issueddataview = new DataGridView();
            return_btn = new Button();
            book_input = new TextBox();
            student_input = new TextBox();
            book_lbl = new Label();
            return_lbl = new Label();
            issued_lbl = new Label();
            student_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)returneddataview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)issueddataview).BeginInit();
            SuspendLayout();
            // 
            // returneddataview
            // 
            returneddataview.AllowUserToAddRows = false;
            returneddataview.AllowUserToDeleteRows = false;
            returneddataview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            returneddataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            returneddataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returneddataview.Location = new Point(574, 425);
            returneddataview.Name = "returneddataview";
            returneddataview.ReadOnly = true;
            returneddataview.RowHeadersWidth = 62;
            returneddataview.RowTemplate.Height = 33;
            returneddataview.Size = new Size(792, 309);
            returneddataview.TabIndex = 11;
            // 
            // issueddataview
            // 
            issueddataview.AllowUserToAddRows = false;
            issueddataview.AllowUserToDeleteRows = false;
            issueddataview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            issueddataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            issueddataview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            issueddataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            issueddataview.Location = new Point(574, 66);
            issueddataview.Name = "issueddataview";
            issueddataview.ReadOnly = true;
            issueddataview.RowHeadersWidth = 62;
            issueddataview.RowTemplate.Height = 33;
            issueddataview.Size = new Size(792, 257);
            issueddataview.TabIndex = 12;
            issueddataview.CellFormatting += issuedataGridView_CellFormatting;
            // 
            // return_btn
            // 
            return_btn.BackColor = Color.Transparent;
            return_btn.FlatStyle = FlatStyle.Flat;
            return_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            return_btn.ForeColor = Color.Cyan;
            return_btn.Location = new Point(147, 280);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(199, 64);
            return_btn.TabIndex = 10;
            return_btn.Text = "Return book";
            return_btn.UseVisualStyleBackColor = false;
            return_btn.Click += return_btn_Click;
            // 
            // book_input
            // 
            book_input.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            book_input.Location = new Point(131, 242);
            book_input.Name = "book_input";
            book_input.PlaceholderText = "any information about book";
            book_input.Size = new Size(260, 32);
            book_input.TabIndex = 8;
            book_input.TextChanged += book_input_TextChanged;
            // 
            // student_input
            // 
            student_input.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            student_input.Location = new Point(131, 144);
            student_input.Name = "student_input";
            student_input.PlaceholderText = "firstname or lastname";
            student_input.Size = new Size(260, 35);
            student_input.TabIndex = 9;
            student_input.TextChanged += student_input_TextChanged;
            // 
            // book_lbl
            // 
            book_lbl.AutoSize = true;
            book_lbl.BackColor = Color.Transparent;
            book_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            book_lbl.ForeColor = Color.White;
            book_lbl.Location = new Point(12, 241);
            book_lbl.Name = "book_lbl";
            book_lbl.Size = new Size(79, 32);
            book_lbl.TabIndex = 4;
            book_lbl.Text = "Book";
            // 
            // return_lbl
            // 
            return_lbl.AutoSize = true;
            return_lbl.BackColor = Color.Transparent;
            return_lbl.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            return_lbl.ForeColor = Color.White;
            return_lbl.Location = new Point(901, 360);
            return_lbl.Name = "return_lbl";
            return_lbl.Size = new Size(270, 45);
            return_lbl.TabIndex = 5;
            return_lbl.Text = "Returned books";
            // 
            // issued_lbl
            // 
            issued_lbl.AutoSize = true;
            issued_lbl.BackColor = Color.Transparent;
            issued_lbl.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            issued_lbl.ForeColor = Color.White;
            issued_lbl.Location = new Point(919, 11);
            issued_lbl.Name = "issued_lbl";
            issued_lbl.Size = new Size(224, 45);
            issued_lbl.TabIndex = 6;
            issued_lbl.Text = "Issued books";
            // 
            // student_lbl
            // 
            student_lbl.AutoSize = true;
            student_lbl.BackColor = Color.Transparent;
            student_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            student_lbl.ForeColor = Color.White;
            student_lbl.Location = new Point(12, 145);
            student_lbl.Name = "student_lbl";
            student_lbl.Size = new Size(113, 32);
            student_lbl.TabIndex = 7;
            student_lbl.Text = "Student";
            // 
            // ReturnBookForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 744);
            Controls.Add(returneddataview);
            Controls.Add(issueddataview);
            Controls.Add(return_btn);
            Controls.Add(book_input);
            Controls.Add(student_input);
            Controls.Add(book_lbl);
            Controls.Add(return_lbl);
            Controls.Add(issued_lbl);
            Controls.Add(student_lbl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReturnBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBookForm";
            ((System.ComponentModel.ISupportInitialize)returneddataview).EndInit();
            ((System.ComponentModel.ISupportInitialize)issueddataview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView returneddataview;
        private DataGridView issueddataview;
        private Button return_btn;
        private TextBox book_input;
        private TextBox student_input;
        private Label book_lbl;
        private Label return_lbl;
        private Label issued_lbl;
        private Label student_lbl;
    }
}