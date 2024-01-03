using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_automation
{
    public partial class users_managment : Form
    {
        public users_managment()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "sys" && textBox2.Text == "sys")
            {
                users_managment2 form6 = new users_managment2();
                form6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya Kullanıcı Adı Yanlış");
            }
        }
    }
}
