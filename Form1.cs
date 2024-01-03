namespace hospital_automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
<<<<<<< HEAD
            textBox1.Text = "sys";
            textBox2.Text = "sys";

=======
            textBox2.Text = "sys";
            textBox1.Text = "sys";
>>>>>>> 5107ebe6f11d2ea41d170f23592df35c41dbcba5
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
                Form2 frm = new Form2();
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
            Form5 frm = new Form5();
            frm.Show();
        }
    }
}
