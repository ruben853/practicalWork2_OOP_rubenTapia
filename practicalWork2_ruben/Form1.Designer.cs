namespace practicalWork2_ruben
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_signin = new System.Windows.Forms.Button();
            this.linkLabel_forgotPassword = new System.Windows.Forms.LinkLabel();
            this.label_title = new System.Windows.Forms.Label();
            this.linkLabel_createUser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(342, 107);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(82, 20);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "User Name";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(342, 210);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 20);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 27);
            this.textBox2.TabIndex = 2;
            // 
            // button_signin
            // 
            this.button_signin.Location = new System.Drawing.Point(318, 363);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(130, 46);
            this.button_signin.TabIndex = 4;
            this.button_signin.Text = "SIGN IN";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // linkLabel_forgotPassword
            // 
            this.linkLabel_forgotPassword.AutoSize = true;
            this.linkLabel_forgotPassword.Location = new System.Drawing.Point(388, 314);
            this.linkLabel_forgotPassword.Name = "linkLabel_forgotPassword";
            this.linkLabel_forgotPassword.Size = new System.Drawing.Size(125, 20);
            this.linkLabel_forgotPassword.TabIndex = 5;
            this.linkLabel_forgotPassword.TabStop = true;
            this.linkLabel_forgotPassword.Text = "Forgot Password?";
            this.linkLabel_forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forgotPassword_LinkClicked);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(289, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(176, 32);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "OOP Calculator";
            // 
            // linkLabel_createUser
            // 
            this.linkLabel_createUser.AutoSize = true;
            this.linkLabel_createUser.Location = new System.Drawing.Point(216, 314);
            this.linkLabel_createUser.Name = "linkLabel_createUser";
            this.linkLabel_createUser.Size = new System.Drawing.Size(139, 20);
            this.linkLabel_createUser.TabIndex = 7;
            this.linkLabel_createUser.TabStop = true;
            this.linkLabel_createUser.Text = "Create new account";
            this.linkLabel_createUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel_createUser);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.linkLabel_forgotPassword);
            this.Controls.Add(this.button_signin);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label_username;
        private Label label_password;
        private TextBox textBox2;
        private Button button_signin;
        private LinkLabel linkLabel_forgotPassword;
        private Label label_title;
        private LinkLabel linkLabel_createUser;
    }
}