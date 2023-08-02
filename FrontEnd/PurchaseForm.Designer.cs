namespace FrontEnd
{
    partial class PurchaseForm
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
            bookdataview = new DataGridView();
            studentdataview = new DataGridView();
            buy_btn = new Button();
            book_input = new TextBox();
            student_input = new TextBox();
            book_lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            student_lbl = new Label();
            quantity_lbl = new Label();
            quantity_input = new NumericUpDown();
            price_lbl = new Label();
            price_input = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bookdataview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentdataview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantity_input).BeginInit();
            SuspendLayout();
            // 
            // bookdataview
            // 
            bookdataview.AllowUserToAddRows = false;
            bookdataview.AllowUserToDeleteRows = false;
            bookdataview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bookdataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookdataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookdataview.Location = new Point(574, 463);
            bookdataview.Name = "bookdataview";
            bookdataview.ReadOnly = true;
            bookdataview.RowHeadersWidth = 62;
            bookdataview.RowTemplate.Height = 33;
            bookdataview.Size = new Size(792, 309);
            bookdataview.TabIndex = 11;
            // 
            // studentdataview
            // 
            studentdataview.AllowUserToAddRows = false;
            studentdataview.AllowUserToDeleteRows = false;
            studentdataview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentdataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentdataview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentdataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentdataview.Location = new Point(574, 104);
            studentdataview.Name = "studentdataview";
            studentdataview.ReadOnly = true;
            studentdataview.RowHeadersWidth = 62;
            studentdataview.RowTemplate.Height = 33;
            studentdataview.Size = new Size(792, 257);
            studentdataview.TabIndex = 12;
            studentdataview.CellFormatting += studentdataGridView_CellFormatting;
            // 
            // buy_btn
            // 
            buy_btn.Location = new Point(152, 381);
            buy_btn.Name = "buy_btn";
            buy_btn.Size = new Size(151, 55);
            buy_btn.TabIndex = 10;
            buy_btn.Text = "Buy book";
            buy_btn.UseVisualStyleBackColor = true;
            buy_btn.Click += buy_btn_Click;
            // 
            // book_input
            // 
            book_input.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            book_input.Location = new Point(161, 223);
            book_input.Name = "book_input";
            book_input.PlaceholderText = "any information about book";
            book_input.Size = new Size(260, 32);
            book_input.TabIndex = 8;
            book_input.TextChanged += book_input_TextChanged;
            // 
            // student_input
            // 
            student_input.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            student_input.Location = new Point(161, 182);
            student_input.Name = "student_input";
            student_input.PlaceholderText = "firstname or lastname";
            student_input.Size = new Size(260, 35);
            student_input.TabIndex = 9;
            student_input.TextChanged += student_input_TextChanged;
            // 
            // book_lbl
            // 
            book_lbl.AutoSize = true;
            book_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            book_lbl.Location = new Point(12, 222);
            book_lbl.Name = "book_lbl";
            book_lbl.Size = new Size(79, 32);
            book_lbl.TabIndex = 4;
            book_lbl.Text = "Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(936, 398);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 5;
            label2.Text = "Books";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(919, 49);
            label1.Name = "label1";
            label1.Size = new Size(124, 38);
            label1.TabIndex = 6;
            label1.Text = "Students";
            // 
            // student_lbl
            // 
            student_lbl.AutoSize = true;
            student_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            student_lbl.Location = new Point(12, 183);
            student_lbl.Name = "student_lbl";
            student_lbl.Size = new Size(113, 32);
            student_lbl.TabIndex = 7;
            student_lbl.Text = "Student";
            // 
            // quantity_lbl
            // 
            quantity_lbl.AutoSize = true;
            quantity_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            quantity_lbl.Location = new Point(4, 263);
            quantity_lbl.Name = "quantity_lbl";
            quantity_lbl.Size = new Size(121, 32);
            quantity_lbl.TabIndex = 4;
            quantity_lbl.Text = "Quantity";
            // 
            // quantity_input
            // 
            quantity_input.Location = new Point(161, 261);
            quantity_input.Name = "quantity_input";
            quantity_input.Size = new Size(154, 39);
            quantity_input.TabIndex = 13;
            quantity_input.ValueChanged += quantity_input_ValueChanged;
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            price_lbl.Location = new Point(4, 308);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(147, 32);
            price_lbl.TabIndex = 4;
            price_lbl.Text = "Total price";
            // 
            // price_input
            // 
            price_input.Enabled = false;
            price_input.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            price_input.Location = new Point(161, 310);
            price_input.Name = "price_input";
            price_input.PlaceholderText = "price";
            price_input.Size = new Size(260, 32);
            price_input.TabIndex = 8;
            price_input.Text = "0";
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 820);
            Controls.Add(quantity_input);
            Controls.Add(bookdataview);
            Controls.Add(studentdataview);
            Controls.Add(buy_btn);
            Controls.Add(price_input);
            Controls.Add(book_input);
            Controls.Add(price_lbl);
            Controls.Add(student_input);
            Controls.Add(quantity_lbl);
            Controls.Add(book_lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(student_lbl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "PurchaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase book";
            ((System.ComponentModel.ISupportInitialize)bookdataview).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentdataview).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantity_input).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView bookdataview;
        private DataGridView studentdataview;
        private Button buy_btn;
        private TextBox book_input;
        private TextBox student_input;
        private Label book_lbl;
        private Label label2;
        private Label label1;
        private Label student_lbl;
        private Label quantity_lbl;
        private NumericUpDown quantity_input;
        private Label price_lbl;
        private TextBox price_input;
    }
}