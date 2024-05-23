namespace practicalWork2_ruben
{
    partial class ForgetPassword
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
            this.label_newPassword = new System.Windows.Forms.Label();
            this.textBox_newpassword = new System.Windows.Forms.TextBox();
            this.textBox_confirmpassword = new System.Windows.Forms.TextBox();
            this.label_confirmpassword = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.Location = new System.Drawing.Point(343, 141);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(106, 20);
            this.label_newPassword.TabIndex = 0;
            this.label_newPassword.Text = "New password";
            // 
            // textBox_newpassword
            // 
            this.textBox_newpassword.Location = new System.Drawing.Point(333, 175);
            this.textBox_newpassword.Name = "textBox_newpassword";
            this.textBox_newpassword.PasswordChar = '*';
            this.textBox_newpassword.Size = new System.Drawing.Size(125, 27);
            this.textBox_newpassword.TabIndex = 1;
            // 
            // textBox_confirmpassword
            // 
            this.textBox_confirmpassword.Location = new System.Drawing.Point(333, 273);
            this.textBox_confirmpassword.Name = "textBox_confirmpassword";
            this.textBox_confirmpassword.PasswordChar = '*';
            this.textBox_confirmpassword.Size = new System.Drawing.Size(125, 27);
            this.textBox_confirmpassword.TabIndex = 3;
            // 
            // label_confirmpassword
            // 
            this.label_confirmpassword.AutoSize = true;
            this.label_confirmpassword.Location = new System.Drawing.Point(329, 239);
            this.label_confirmpassword.Name = "label_confirmpassword";
            this.label_confirmpassword.Size = new System.Drawing.Size(129, 20);
            this.label_confirmpassword.TabIndex = 2;
            this.label_confirmpassword.Text = "Confirm password";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(313, 21);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(176, 32);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "OOP Calculator";
            // 
            // button_changePassword
            // 
            this.button_changePassword.Location = new System.Drawing.Point(325, 365);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(155, 29);
            this.button_changePassword.TabIndex = 8;
            this.button_changePassword.Text = "Change Password";
            this.button_changePassword.UseVisualStyleBackColor = true;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(333, 94);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(125, 27);
            this.textBox_username.TabIndex = 10;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_confirmpassword);
            this.Controls.Add(this.label_confirmpassword);
            this.Controls.Add(this.textBox_newpassword);
            this.Controls.Add(this.label_newPassword);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_newPassword;
        private TextBox textBox_newpassword;
        private TextBox textBox_confirmpassword;
        private Label label_confirmpassword;
        private Label label_title;
        private Button button_changePassword;
        private TextBox textBox_username;
        private Label label1;
    }
}