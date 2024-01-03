namespace hospital_automation
{
    public partial class login_screen : Form
    {
        public login_screen()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox1.Text = "haydar";
            textBox2.Text = "haydar";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*using (StreamWriter writer = new StreamWriter("users.txt", true))
            {
                writer.WriteLine($"{textBox1.Text};{textBox2.Text}");
            }*/
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernameToCheck = textBox1.Text;
            string passwordToCheck = textBox2.Text;
            bool credentialsMatch = false;

            using (StreamReader reader = new StreamReader("users.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] userInfo = line.Split(';');
                    string usernameFromFile = userInfo[0];
                    string passwordFromFile = userInfo[1];

                    if (usernameToCheck == usernameFromFile && passwordToCheck == passwordFromFile)
                    {
                        credentialsMatch = true;
                        break;
                    }
                }
            }

            if (!credentialsMatch)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
            else
            {
                main_page frm = new main_page();
                frm.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            users_managment frm = new users_managment();
            frm.Show();
        }
    }
}
