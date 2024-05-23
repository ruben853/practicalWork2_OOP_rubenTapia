namespace practicalWork2_ruben
{
    public partial class Form1 : Form
    {

        private string username;
        private string password;
        List<Usuario> cuentas = new List<Usuario>(); 

        public Form1(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool Verify()
        {
            
            foreach(Usuario u in cuentas)
            {
                if(u.GetUName() == textBox1.Text && u.GetPassword() == textBox2.Text)
                {
                    return true;
                }
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text;
            string contrasena = textBox2.Text;

            string filepath = @"users.txt";

            StreamReader sr = new StreamReader(filepath);

            string line = "";

            while((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(',');

                this.username = words[1];
                this.password = words[3];

                if(nombreUsuario == this.username && contrasena == this.password)
                {
                    this.Hide();
                    Calculator c = new Calculator();
                    c.Show();

                }
            }

        }

        private void linkLabel_forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword forget = new ForgetPassword();
            forget.Show();
        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register1 registerUser = new Register1();
            registerUser.Show();
        }

        public void ReadFile()
        {
            StreamReader sr = new StreamReader("users.txt");

            string linea = "";

            while((linea = sr.ReadLine()) != null) 
            {
                string[] palabras = linea.Split(',');

                Usuario usr = new Usuario(palabras[0], palabras[1], palabras[2], palabras[3]);

                cuentas.Add(usr);
            }
        }
    }
}