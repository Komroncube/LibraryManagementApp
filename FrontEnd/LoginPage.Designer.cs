﻿namespace FrontEnd
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            showcb = new CheckBox();
            pass_input = new TextBox();
            username_input = new TextBox();
            label1 = new Label();
            sign_btn = new Button();
            SuspendLayout();
            // 
            // showcb
            // 
            showcb.AutoSize = true;
            showcb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            showcb.Location = new Point(493, 208);
            showcb.Name = "showcb";
            showcb.Size = new Size(130, 32);
            showcb.TabIndex = 7;
            showcb.Text = "checkBox1";
            showcb.UseVisualStyleBackColor = true;
            showcb.CheckedChanged += showcb_CheckedChanged;
            // 
            // pass_input
            // 
            pass_input.Location = new Point(154, 193);
            pass_input.Name = "pass_input";
            pass_input.PlaceholderText = "Password";
            pass_input.Size = new Size(328, 50);
            pass_input.TabIndex = 6;
            pass_input.UseSystemPasswordChar = true;
            // 
            // username_input
            // 
            username_input.Location = new Point(153, 116);
            username_input.Name = "username_input";
            username_input.PlaceholderText = "Username";
            username_input.Size = new Size(329, 50);
            username_input.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(261, 57);
            label1.Name = "label1";
            label1.Size = new Size(99, 45);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // sign_btn
            // 
            sign_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sign_btn.Location = new Point(261, 276);
            sign_btn.Name = "sign_btn";
            sign_btn.Size = new Size(122, 52);
            sign_btn.TabIndex = 8;
            sign_btn.Text = "SIGN IN";
            sign_btn.UseVisualStyleBackColor = true;
            sign_btn.Click += sign_btn_Click;
            // 
            // LoginPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(665, 416);
            Controls.Add(sign_btn);
            Controls.Add(showcb);
            Controls.Add(pass_input);
            Controls.Add(username_input);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox showcb;
        private TextBox pass_input;
        private TextBox username_input;
        private Label label1;
        private Button sign_btn;
    }
}