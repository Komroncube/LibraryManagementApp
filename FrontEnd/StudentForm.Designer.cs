namespace FrontEnd
{
    partial class StudentForm
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
            dataview = new DataGridView();
            first_lbl = new Label();
            firstname_input = new TextBox();
            last_lbl = new Label();
            lastname_input = new TextBox();
            phone_lbl = new Label();
            phone_input = new TextBox();
            fac_lbl = new Label();
            faculty = new ComboBox();
            edit_btn = new Button();
            new_btn = new Button();
            delete_btn = new Button();
            save_btn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            SuspendLayout();
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
            dataview.TabIndex = 0;
            // 
            // first_lbl
            // 
            first_lbl.AutoSize = true;
            first_lbl.ForeColor = Color.Cyan;
            first_lbl.Location = new Point(43, 82);
            first_lbl.Name = "first_lbl";
            first_lbl.Size = new Size(125, 32);
            first_lbl.TabIndex = 1;
            first_lbl.Text = "First name";
            // 
            // firstname_input
            // 
            firstname_input.Location = new Point(216, 82);
            firstname_input.Name = "firstname_input";
            firstname_input.Size = new Size(248, 39);
            firstname_input.TabIndex = 2;
            // 
            // last_lbl
            // 
            last_lbl.AutoSize = true;
            last_lbl.ForeColor = Color.Cyan;
            last_lbl.Location = new Point(43, 144);
            last_lbl.Name = "last_lbl";
            last_lbl.Size = new Size(122, 32);
            last_lbl.TabIndex = 1;
            last_lbl.Text = "Last name";
            // 
            // lastname_input
            // 
            lastname_input.Location = new Point(216, 138);
            lastname_input.Name = "lastname_input";
            lastname_input.Size = new Size(248, 39);
            lastname_input.TabIndex = 2;
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.ForeColor = Color.Cyan;
            phone_lbl.Location = new Point(43, 206);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(173, 32);
            phone_lbl.TabIndex = 1;
            phone_lbl.Text = "Phone number";
            // 
            // phone_input
            // 
            phone_input.Location = new Point(216, 202);
            phone_input.Name = "phone_input";
            phone_input.Size = new Size(248, 39);
            phone_input.TabIndex = 2;
            // 
            // fac_lbl
            // 
            fac_lbl.AutoSize = true;
            fac_lbl.ForeColor = Color.Cyan;
            fac_lbl.Location = new Point(43, 268);
            fac_lbl.Name = "fac_lbl";
            fac_lbl.Size = new Size(88, 32);
            fac_lbl.TabIndex = 1;
            fac_lbl.Text = "Faculty";
            // 
            // faculty
            // 
            faculty.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            faculty.FormattingEnabled = true;
            faculty.Location = new Point(216, 266);
            faculty.Name = "faculty";
            faculty.Size = new Size(329, 36);
            faculty.TabIndex = 3;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.Transparent;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            edit_btn.ForeColor = Color.Cyan;
            edit_btn.Location = new Point(965, 114);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(145, 70);
            edit_btn.TabIndex = 4;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // new_btn
            // 
            new_btn.BackColor = Color.Transparent;
            new_btn.FlatStyle = FlatStyle.Flat;
            new_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            new_btn.ForeColor = Color.White;
            new_btn.Location = new Point(802, 114);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(145, 70);
            new_btn.TabIndex = 4;
            new_btn.Text = "Clear";
            new_btn.UseVisualStyleBackColor = false;
            new_btn.Click += new_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Transparent;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delete_btn.ForeColor = Color.Red;
            delete_btn.Location = new Point(802, 212);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(145, 70);
            delete_btn.TabIndex = 4;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.Transparent;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            save_btn.ForeColor = Color.Lime;
            save_btn.Location = new Point(965, 212);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(145, 70);
            save_btn.TabIndex = 4;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(538, 22);
            label1.Name = "label1";
            label1.Size = new Size(158, 45);
            label1.TabIndex = 5;
            label1.Text = "Students";
            // 
            // StudentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1378, 820);
            Controls.Add(label1);
            Controls.Add(save_btn);
            Controls.Add(delete_btn);
            Controls.Add(new_btn);
            Controls.Add(edit_btn);
            Controls.Add(faculty);
            Controls.Add(fac_lbl);
            Controls.Add(phone_input);
            Controls.Add(phone_lbl);
            Controls.Add(lastname_input);
            Controls.Add(last_lbl);
            Controls.Add(firstname_input);
            Controls.Add(first_lbl);
            Controls.Add(dataview);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student management";
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataview;
        private Label first_lbl;
        private TextBox firstname_input;
        private Label last_lbl;
        private TextBox lastname_input;
        private Label phone_lbl;
        private TextBox phone_input;
        private Label fac_lbl;
        private ComboBox faculty;
        private Button edit_btn;
        private Button new_btn;
        private Button delete_btn;
        private Button save_btn;
        private Label label1;
    }
}