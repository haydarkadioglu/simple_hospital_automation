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
    public partial class users_managment2 : Form
    {
        public users_managment2()
        {
            InitializeComponent();
            dosya_oku();
        }

        private void dosya_oku()
        {
            listBox1.Items.Clear();
            string dosya_yolu = "users.txt";

            string[] datas = File.ReadAllLines(dosya_yolu);
            foreach (string data in datas)
            {
                string[] strings = data.Split(";");
                listBox1.Items.Add($"{strings[0]} // {strings[1]}");


            }

        }

        public void erase_from_file(int silinecekSatir)
        {
            string dosya_yolu = @"users.txt";
            List<string> satirlar = new List<string>();
            using (StreamReader sr = new StreamReader(dosya_yolu))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    satirlar.Add(satir);
                }
            }
            int silinecek_indeks = silinecekSatir;
            satirlar.RemoveAt(silinecek_indeks - 1);
            using (StreamWriter sw = new StreamWriter(dosya_yolu))
            {
                foreach (string satir in satirlar)
                {
                    sw.WriteLine(satir);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("users.txt", true))
            {
                writer.WriteLine($"{textBox1.Text};{textBox2.Text}");
            }
            dosya_oku();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            erase_from_file(listBox1.SelectedIndex+1);
            dosya_oku();
        }
    }
}
