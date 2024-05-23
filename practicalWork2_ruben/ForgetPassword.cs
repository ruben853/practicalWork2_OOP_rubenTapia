using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace practicalWork2_ruben
{
    public partial class ForgetPassword : Form
    {

        private string username;
        private string password;
        private string password_repeat;
        private bool passwordChanged;
        private bool exito;

        
        public ForgetPassword()
        {
            this.passwordChanged = false;
            this.exito = false;
            InitializeComponent();
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox_username.Text;
            string contra = textBox_newpassword.Text;
            string contraRep = textBox_confirmpassword.Text;
            string filepath = @"users.txt";

            List<string> cuentas = new List<string>();

            if(nombreUsuario == "" || contra == "" || contraRep == "")
            {
                MessageBox.Show("Please don't leave any camps empty");
            }
            else
            {
                if(contra != contraRep)
                {
                    MessageBox.Show("The passwords don't match, please type them again");
                }
                else
                {
                    if(IsValidPassword(contra) == false)
                    {
                        MessageBox.Show("The format of the password you typed isn't correct, please do it again");
                    }
                    else
                    {
                        using (StreamReader sr = new StreamReader(filepath))
                        {
                            string line = "";

                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] words = line.Split(',');

                                if (words[1] == nombreUsuario)
                                {
                                    words[3] = contra;
                                    this.exito = true;
                                    line = string.Join(",", words);
                                }
                                cuentas.Add(line);
                            }
                            sr.Close();
                        }
                        if(this.exito == true)
                        {
                            using(StreamWriter sw = new StreamWriter(filepath))
                            {
                                foreach(string acc in cuentas)
                                {
                                    sw.WriteLine(acc);
                                }
                            }
                            MessageBox.Show("Password succesfully changed");
                            this.Close();
                            Form1 login = new Form1();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unable to find user, please try again");
                        }
                    }
                }
            }


            //if(textBox_username.Text == "" || textBox_newpassword.Text == "" || textBox_confirmpassword.Text == "")
            //{
            //    MessageBox.Show("Error campos vacios");
            //    return;
            //}
            //else
            //{
            //    if(this.password == this.password_repeat)
            //    {
            //        this.exito = IsValidPassword(this.password);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error contraseñas no coinciden.");
            //        return;
            //    }

            //    if(this.exito == true)
            //    {
            //        foreach(Usuario usuario in cuentas) 
            //        {
            //            if(textBox_username.Text == usuario.GetUName())
            //            {
            //                this.passwordChanged = true;
            //                usuario.SetPassword(this.password);
            //                MessageBox.Show(" Usuario cambiado -> " + usuario.Print());
            //            }
            //        }

            //        if(this.passwordChanged == true)
            //        {
            //            this.Close();
            //            Form1 loginuser = new Form1();
            //            loginuser.Show();
            //        }

            //    }
            //}
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

            if(hasUpperChar == true && hasLowerChar == true && hasDigit == true && hasSpecialChar == true)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
