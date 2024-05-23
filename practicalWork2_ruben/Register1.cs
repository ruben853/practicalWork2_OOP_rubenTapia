using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicalWork2_ruben
{
    public partial class Register1 : Form
    {
        private string Name;
        private string Username;
        private string Password;
        private string Email;
        private string RepeatPassword;

        List<Usuario> cuentas = new List<Usuario>();

        public Register1(string name, string username, string email, string password)
        {
            this.Name = name;
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }


        public bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpperChar = false, hasLowerChar = false, hasDigit = false, hasSpecialChar = false;
            foreach (var c in password)
            {
                if (char.IsUpper(c)) hasUpperChar = true;
                else if (char.IsLower(c)) hasLowerChar = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else hasSpecialChar = true;
            }

            return hasUpperChar && hasLowerChar && hasDigit && hasSpecialChar;
        }


        public string GetName()
        {
            return this.Name;
        }

        public string GetUsername()
        {
            return this.Username;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public string GetPassword()
        {
            return this.Password;
        }

        public string GetRepeatPassword()
        {
            return this.RepeatPassword;
        }

        public Register1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_repeatPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_register_Click_1(object sender, EventArgs e)
        {
            this.Name = textBox_name.Text;
            this.Username = textBox_username.Text;
            this.Email = textBox_email.Text;
            this.Password = textBox_password.Text;
            this.RepeatPassword = textBox_repeatPassword.Text;

            if (this.Password != this.RepeatPassword)
            {
                MessageBox.Show("The passwords aren't the same, please verify you type the same password");
                return;
            }

            if (!IsValidPassword(this.Password))
            {
                MessageBox.Show("The password you selected doesn't match the requirements, please type another one");
                return;
            }

            if (!checkBox_accept.Checked)
            {
                MessageBox.Show("Debe aceptar la política de protección para registrarse.");
                return;
            }

            Usuario us = new Usuario(this.Name, this.Username, this.Email, this.Password);
            cuentas.Add(us);

            CargarFile(us);

            MessageBox.Show("User created succesfully");
            this.Close();

            Form1 f1 = new Form1();
            f1.Show();


        }

        private void checkBox_accept_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void CargarFile( Usuario us)
        {
            string path = "users.txt";
            StreamWriter sw = File.AppendText(path);

            sw.WriteLine(us.Print());

            sw.Close();
        }
    }
}
