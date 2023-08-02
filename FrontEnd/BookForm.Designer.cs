namespace FrontEnd
{
    partial class BookForm
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
            save_btn = new Button();
            delete_btn = new Button();
            new_btn = new Button();
            edit_btn = new Button();
            author_input = new TextBox();
            author_lbl = new Label();
            description_input = new TextBox();
            description_lbl = new Label();
            price_input = new TextBox();
            quantity_lbl = new Label();
            price_lbl = new Label();
            title_input = new TextBox();
            title_lbl = new Label();
            dataview = new DataGridView();
            quantity_updown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantity_updown).BeginInit();
            SuspendLayout();
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.Transparent;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.ForeColor = Color.Lime;
            save_btn.Location = new Point(955, 187);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(145, 70);
            save_btn.TabIndex = 29;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Transparent;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.ForeColor = Color.Red;
            delete_btn.Location = new Point(792, 187);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(145, 70);
            delete_btn.TabIndex = 30;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // new_btn
            // 
            new_btn.BackColor = Color.Transparent;
            new_btn.FlatStyle = FlatStyle.Flat;
            new_btn.ForeColor = Color.White;
            new_btn.Location = new Point(792, 89);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(145, 70);
            new_btn.TabIndex = 31;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = false;
            new_btn.Click += new_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.Transparent;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.ForeColor = Color.Cyan;
            edit_btn.Location = new Point(955, 89);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(145, 70);
            edit_btn.TabIndex = 32;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // author_input
            // 
            author_input.Location = new Point(206, 136);
            author_input.Name = "author_input";
            author_input.Size = new Size(248, 39);
            author_input.TabIndex = 24;
            // 
            // author_lbl
            // 
            author_lbl.AutoSize = true;
            author_lbl.ForeColor = Color.Cyan;
            author_lbl.Location = new Point(33, 136);
            author_lbl.Name = "author_lbl";
            author_lbl.Size = new Size(87, 32);
            author_lbl.TabIndex = 19;
            author_lbl.Text = "Author";
            // 
            // description_input
            // 
            description_input.Location = new Point(206, 91);
            description_input.Name = "description_input";
            description_input.Size = new Size(248, 39);
            description_input.TabIndex = 25;
            // 
            // description_lbl
            // 
            description_lbl.AutoSize = true;
            description_lbl.ForeColor = Color.Cyan;
            description_lbl.Location = new Point(33, 91);
            description_lbl.Name = "description_lbl";
            description_lbl.Size = new Size(135, 32);
            description_lbl.TabIndex = 20;
            description_lbl.Text = "Description";
            // 
            // price_input
            // 
            price_input.Location = new Point(206, 181);
            price_input.Name = "price_input";
            price_input.Size = new Size(248, 39);
            price_input.TabIndex = 26;
            // 
            // quantity_lbl
            // 
            quantity_lbl.AutoSize = true;
            quantity_lbl.ForeColor = Color.Cyan;
            quantity_lbl.Location = new Point(33, 226);
            quantity_lbl.Name = "quantity_lbl";
            quantity_lbl.Size = new Size(106, 32);
            quantity_lbl.TabIndex = 21;
            quantity_lbl.Text = "Quantity";
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.ForeColor = Color.Cyan;
            price_lbl.Location = new Point(33, 181);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(65, 32);
            price_lbl.TabIndex = 22;
            price_lbl.Text = "Price";
            // 
            // title_input
            // 
            title_input.Location = new Point(206, 46);
            title_input.Name = "title_input";
            title_input.Size = new Size(248, 39);
            title_input.TabIndex = 28;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.ForeColor = Color.Cyan;
            title_lbl.Location = new Point(33, 46);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(60, 32);
            title_lbl.TabIndex = 23;
            title_lbl.Text = "Title";
            // 
            // dataview
            // 
            dataview.AllowUserToAddRows = false;
            dataview.AllowUserToDeleteRows = false;
            dataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataview.Dock = DockStyle.Bottom;
            dataview.Location = new Point(0, 327);
            dataview.Name = "dataview";
            dataview.ReadOnly = true;
            dataview.RowHeadersWidth = 62;
            dataview.RowTemplate.Height = 33;
            dataview.Size = new Size(1378, 493);
            dataview.TabIndex = 18;
            dataview.CellFormatting += dataGridView_CellFormatting;
            // 
            // quantity_updown
            // 
            quantity_updown.Location = new Point(206, 226);
            quantity_updown.Name = "quantity_updown";
            quantity_updown.Size = new Size(180, 39);
            quantity_updown.TabIndex = 33;
            // 
            // BookForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1378, 820);
            Controls.Add(quantity_updown);
            Controls.Add(save_btn);
            Controls.Add(delete_btn);
            Controls.Add(new_btn);
            Controls.Add(edit_btn);
            Controls.Add(author_input);
            Controls.Add(author_lbl);
            Controls.Add(description_input);
            Controls.Add(description_lbl);
            Controls.Add(price_input);
            Controls.Add(quantity_lbl);
            Controls.Add(price_lbl);
            Controls.Add(title_input);
            Controls.Add(title_lbl);
            Controls.Add(dataview);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantity_updown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_btn;
        private Button delete_btn;
        private Button new_btn;
        private Button edit_btn;
        private TextBox author_input;
        private Label author_lbl;
        private TextBox description_input;
        private Label description_lbl;
        private TextBox price_input;
        private Label quantity_lbl;
        private Label price_lbl;
        private TextBox title_input;
        private Label title_lbl;
        private DataGridView dataview;
        private NumericUpDown quantity_updown;
    }
}