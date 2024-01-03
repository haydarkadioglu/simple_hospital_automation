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
    public partial class policlinic_regist : Form
    {


        public policlinic_regist()
        {
            InitializeComponent();
            read_policlinic_file();
            read_for_combobox();
        }
        private void read_for_combobox()
        {
            string dosya_yolu = "poliklinik.txt";

            string[] datas = File.ReadAllLines(dosya_yolu);
            foreach (string data in datas)
            {
                string[] strings = data.Split(";");
                comboBox1.Items.Add(strings[0]);


            }
        }
        private void read_policlinic_file()
        {
            string dosya_yolu = "poliklinik.txt";

            string[] datas = File.ReadAllLines(dosya_yolu);
            foreach (string data in datas)
            {
                string[] strings = data.Split(";");
                listBox1.Items.Add($"{strings[0]}:");
                for (int i = 1; i < strings.Length; i++)
                {
                    listBox1.Items.Add($"   {strings[i]}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_clinic(textBox1.Text);
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            read_policlinic_file();
            read_for_combobox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_doctor(comboBox1.Text, textBox2.Text);
            listBox1.Items.Clear();
            read_policlinic_file();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            remove_doctor(comboBox1.Text, textBox2.Text);
            listBox1.Items.Clear();
            read_policlinic_file();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            remove_klinik(textBox1.Text);
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            read_policlinic_file();
            read_for_combobox();
        }

        private void remove_doctor(string clinic, string value)
        {
            string dosyaYolu = "poliklinik.txt";

            string poliklinikAdi = clinic;
            string silinecekDeger = value;

            string[] satirlar = File.ReadAllLines(dosyaYolu);

            int index = Array.FindIndex(satirlar, satir => satir.StartsWith(poliklinikAdi));

            if (index != -1)
            {
                string[] parcalar = satirlar[index].Split(';');
                parcalar = parcalar.Where(deger => deger != silinecekDeger).ToArray();
                satirlar[index] = string.Join(";", parcalar);


                File.WriteAllLines(dosyaYolu, satirlar);

            }
        }

        private void add_doctor(string clinic_name, string value)
        {
            string dosyaYolu = "poliklinik.txt";

            string poliklinikAdi = clinic_name;
            string yeniDeger = value;

            string[] satirlar = File.ReadAllLines(dosyaYolu);


            int index = Array.FindIndex(satirlar, satir => satir.StartsWith(poliklinikAdi));

            if (index != -1)
            {
                satirlar[index] += ";" + yeniDeger;


                File.WriteAllLines(dosyaYolu, satirlar);

            }

        }

        private void add_clinic(string clinic_name)
        {
            string dosyaYolu = "poliklinik.txt";

            string yeniPoliklinikAdi = clinic_name;
            ;

            string yeniSatir = $"{yeniPoliklinikAdi}";

            File.AppendAllLines(dosyaYolu, new[] { yeniSatir });

            Console.WriteLine($"{yeniPoliklinikAdi} polikliniği eklendi.");
        }
        private void remove_klinik(string clinic_name)
        {
            string dosyaYolu = "poliklinik.txt";

            string silinecekPoliklinikAdi = clinic_name;

            string[] satirlar = File.ReadAllLines(dosyaYolu);

            var silinecekSatirlar = satirlar
                .Where(satir => satir.StartsWith(silinecekPoliklinikAdi))
                .ToList();

            if (silinecekSatirlar.Any())
            {
                satirlar = satirlar.Except(silinecekSatirlar).ToArray();

                File.WriteAllLines(dosyaYolu, satirlar);

                Console.WriteLine($"{silinecekPoliklinikAdi} polikliniği ve ilgili satırlar silindi.");
            }
            else
            {
                Console.WriteLine($"{silinecekPoliklinikAdi} polikliniği bulunamadı.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            main_page form = new main_page();
            form.Show();
            this.Close();
        }
    }
}
