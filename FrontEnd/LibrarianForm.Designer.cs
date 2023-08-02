namespace FrontEnd
{
    partial class LibrarianForm
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
            phone_input = new TextBox();
            phone_lbl = new Label();
            lastname_input = new TextBox();
            lastname_lbl = new Label();
            firstname_input = new TextBox();
            firstname_lbl = new Label();
            dataview = new DataGridView();
            username_lbl = new Label();
            username_input = new TextBox();
            password_lbl = new Label();
            password_input = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            SuspendLayout();
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.Transparent;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.ForeColor = Color.Lime;
            save_btn.Location = new Point(955, 232);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(145, 70);
            save_btn.TabIndex = 14;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Transparent;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.ForeColor = Color.Red;
            delete_btn.Location = new Point(792, 232);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(145, 70);
            delete_btn.TabIndex = 15;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // new_btn
            // 
            new_btn.BackColor = Color.Transparent;
            new_btn.FlatStyle = FlatStyle.Flat;
            new_btn.ForeColor = Color.White;
            new_btn.Location = new Point(792, 134);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(145, 70);
            new_btn.TabIndex = 16;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = false;
            new_btn.Click += new_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.Transparent;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.ForeColor = Color.Cyan;
            edit_btn.Location = new Point(955, 134);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(145, 70);
            edit_btn.TabIndex = 17;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // phone_input
            // 
            phone_input.Location = new Point(206, 181);
            phone_input.Name = "phone_input";
            phone_input.Size = new Size(248, 39);
            phone_input.TabIndex = 10;
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.ForeColor = Color.Cyan;
            phone_lbl.Location = new Point(33, 181);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(173, 32);
            phone_lbl.TabIndex = 7;
            phone_lbl.Text = "Phone number";
            // 
            // lastname_input
            // 
            lastname_input.Location = new Point(206, 136);
            lastname_input.Name = "lastname_input";
            lastname_input.Size = new Size(248, 39);
            lastname_input.TabIndex = 11;
            // 
            // lastname_lbl
            // 
            lastname_lbl.AutoSize = true;
            lastname_lbl.ForeColor = Color.Cyan;
            lastname_lbl.Location = new Point(33, 136);
            lastname_lbl.Name = "lastname_lbl";
            lastname_lbl.Size = new Size(122, 32);
            lastname_lbl.TabIndex = 8;
            lastname_lbl.Text = "Last name";
            // 
            // firstname_input
            // 
            firstname_input.Location = new Point(206, 91);
            firstname_input.Name = "firstname_input";
            firstname_input.Size = new Size(248, 39);
            firstname_input.TabIndex = 12;
            // 
            // firstname_lbl
            // 
            firstname_lbl.AutoSize = true;
            firstname_lbl.ForeColor = Color.Cyan;
            firstname_lbl.Location = new Point(33, 91);
            firstname_lbl.Name = "firstname_lbl";
            firstname_lbl.Size = new Size(125, 32);
            firstname_lbl.TabIndex = 9;
            firstname_lbl.Text = "First name";
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
            dataview.TabIndex = 5;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.ForeColor = Color.Cyan;
            username_lbl.Location = new Point(33, 226);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(121, 32);
            username_lbl.TabIndex = 9;
            username_lbl.Text = "Username";
            // 
            // username_input
            // 
            username_input.Location = new Point(206, 226);
            username_input.Name = "username_input";
            username_input.Size = new Size(248, 39);
            username_input.TabIndex = 12;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.ForeColor = Color.Cyan;
            password_lbl.Location = new Point(33, 271);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(111, 32);
            password_lbl.TabIndex = 9;
            password_lbl.Text = "Password";
            // 
            // password_input
            // 
            password_input.Location = new Point(206, 271);
            password_input.Name = "password_input";
            password_input.Size = new Size(248, 39);
            password_input.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(544, 34);
            label1.Name = "label1";
            label1.Size = new Size(196, 48);
            label1.TabIndex = 18;
            label1.Text = "Librarians";
            // 
            // LibrarianForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1378, 820);
            Controls.Add(label1);
            Controls.Add(save_btn);
            Controls.Add(delete_btn);
            Controls.Add(new_btn);
            Controls.Add(edit_btn);
            Controls.Add(phone_input);
            Controls.Add(phone_lbl);
            Controls.Add(lastname_input);
            Controls.Add(lastname_lbl);
            Controls.Add(password_input);
            Controls.Add(password_lbl);
            Controls.Add(username_input);
            Controls.Add(username_lbl);
            Controls.Add(firstname_input);
            Controls.Add(firstname_lbl);
            Controls.Add(dataview);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LibrarianForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librarian management";
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_btn;
        private Button delete_btn;
        private Button new_btn;
        private Button edit_btn;
        private TextBox phone_input;
        private Label phone_lbl;
        private TextBox lastname_input;
        private Label lastname_lbl;
        private TextBox firstname_input;
        private Label firstname_lbl;
        private DataGridView dataview;
        private Label username_lbl;
        private TextBox username_input;
        private Label password_lbl;
        private TextBox password_input;
        private Label label1;
    }
}