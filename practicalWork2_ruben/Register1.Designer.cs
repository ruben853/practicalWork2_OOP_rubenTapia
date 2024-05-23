namespace practicalWork2_ruben
{
    partial class Register1
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_repeatPassword = new System.Windows.Forms.TextBox();
            this.label_repeatPassword = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.checkBox_accept = new System.Windows.Forms.CheckBox();
            this.label_policy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(306, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(176, 32);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "OOP Calculator";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(128, 127);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 20);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(95, 161);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(125, 27);
            this.textBox_name.TabIndex = 9;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(95, 257);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(125, 27);
            this.textBox_username.TabIndex = 11;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(116, 223);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(75, 20);
            this.label_username.TabIndex = 10;
            this.label_username.Text = "Username";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(273, 161);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(125, 27);
            this.textBox_email.TabIndex = 13;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(306, 127);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(46, 20);
            this.label_email.TabIndex = 12;
            this.label_email.Text = "Email";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(273, 257);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(125, 27);
            this.textBox_password.TabIndex = 15;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(306, 223);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 20);
            this.label_password.TabIndex = 14;
            this.label_password.Text = "Password";
            // 
            // textBox_repeatPassword
            // 
            this.textBox_repeatPassword.Location = new System.Drawing.Point(273, 352);
            this.textBox_repeatPassword.Name = "textBox_repeatPassword";
            this.textBox_repeatPassword.Size = new System.Drawing.Size(125, 27);
            this.textBox_repeatPassword.TabIndex = 17;
            this.textBox_repeatPassword.TextChanged += new System.EventHandler(this.textBox_repeatPassword_TextChanged);
            // 
            // label_repeatPassword
            // 
            this.label_repeatPassword.AutoSize = true;
            this.label_repeatPassword.Location = new System.Drawing.Point(277, 318);
            this.label_repeatPassword.Name = "label_repeatPassword";
            this.label_repeatPassword.Size = new System.Drawing.Size(121, 20);
            this.label_repeatPassword.TabIndex = 16;
            this.label_repeatPassword.Text = "Repeat Password";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(116, 350);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(94, 29);
            this.button_register.TabIndex = 18;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click_1);
            // 
            // checkBox_accept
            // 
            this.checkBox_accept.AutoSize = true;
            this.checkBox_accept.Location = new System.Drawing.Point(514, 275);
            this.checkBox_accept.Name = "checkBox_accept";
            this.checkBox_accept.Size = new System.Drawing.Size(77, 24);
            this.checkBox_accept.TabIndex = 19;
            this.checkBox_accept.Text = "Accept";
            this.checkBox_accept.UseVisualStyleBackColor = true;
            this.checkBox_accept.CheckedChanged += new System.EventHandler(this.checkBox_accept_CheckedChanged);
            // 
            // label_policy
            // 
            this.label_policy.AutoSize = true;
            this.label_policy.Location = new System.Drawing.Point(501, 233);
            this.label_policy.Name = "label_policy";
            this.label_policy.Size = new System.Drawing.Size(90, 20);
            this.label_policy.TabIndex = 20;
            this.label_policy.Text = "Policy Terms";
            // 
            // Register1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_policy);
            this.Controls.Add(this.checkBox_accept);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_repeatPassword);
            this.Controls.Add(this.label_repeatPassword);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_title);
            this.Name = "Register1";
            this.Text = "Register1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_title;
        private Label label_name;
        private TextBox textBox_name;
        private TextBox textBox_username;
        private Label label_username;
        private TextBox textBox_email;
        private Label label_email;
        private TextBox textBox_password;
        private Label label_password;
        private TextBox textBox_repeatPassword;
        private Label label_repeatPassword;
        private Button button_register;
        private CheckBox checkBox_accept;
        private Label label_policy;
    }
}