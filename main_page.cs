using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace hospital_automation
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
            read_file();
            textBox_sira.Text = siraVer().ToString();
            read_policlinic_file();
        }

        private void read_policlinic_file()
        {
            string dosya_yolu = "poliklinik.txt";

            string[] datas = File.ReadAllLines(dosya_yolu);
            foreach (string data in datas)
            {
                string[] strings = data.Split(";");
                comboBox_klinik.Items.Add(strings[0]);
                for (int i = 1; i < strings.Length; i++)
                {
                    comboBox_kod.Items.Add(strings[i]);
                }
            }
        }

        private void read_file()
        {
            string dosya_yolu = "yapilan_islem.txt";

            string[] datas = File.ReadAllLines(dosya_yolu);
            foreach (string data in datas)
            {
                string[] strings = data.Split(";");
                dataGridView1.Rows.Add(strings);


            }

        }
        public void erase_from_file(int silinecekSatir)
        {
            string dosya_yolu = @"yapilan_islem.txt";
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
        private void bul_Click(object sender, EventArgs e)
        {
            string dosya = "taburcu.txt";
            string dosya1 = "non_taburcu.txt";

            string[] datas = File.ReadAllLines(dosya)
                              .Concat(File.ReadAllLines(dosya1))
                              .ToArray();

            foreach (string data in datas)
            {
                string[] data2 = data.Split(';');
                if (dosya_no.Text == data2[0])
                {
                    hasta_adi.Text = data2[1];
                    soyadi.Text = data2[2];
                    sevk_tarihi.Text = data2[3];
                    kurum_adi.Text = data2[6];
                    return;
                }
            }
            MessageBox.Show("Hasta Bulunamadı.");





        }

        private int siraVer()
        {
            string[] strings = File.ReadAllLines("yapilan_islem.txt");

            string[] lastLine = strings.LastOrDefault().Split(";");

            if (lastLine != null)
            {
                return (int.Parse(lastLine[1]) + 1);
            }
            return 1;


        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;


            string currentDateTime1 = currentDateTime.ToString("HH:mm");
            string currentDateTime2 = currentDateTime.ToString("dd.MM.yyyy");
            dataGridView1.Rows.Add(comboBox_klinik.Text, textBox_sira.Text, currentDateTime1, comboBox_islem.Text, comboBox_kod.Text, numericUpDown1.Value, textBox_fiyat.Text);

            using (StreamWriter writer = new StreamWriter("yapilan_islem.txt", true))
            {
                writer.WriteLine($"{comboBox_klinik.Text};{textBox_sira.Text};{currentDateTime1};{comboBox_islem.Text};{comboBox_kod.Text};{numericUpDown1.Value};{textBox_fiyat.Text}");
            }
            textBox_sira.Text = siraVer().ToString();
        }

        private void hasta_bilgi_Click(object sender, EventArgs e)
        {
            patient_info frm = new patient_info();
            frm.Show();
            this.Hide();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            int SelectedIndex = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);


            erase_from_file(SelectedIndex + 1);

        }

        private void button_yazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) => YazdirmaSayfasiOlustur(dataGridView1, e);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        private static void YazdirmaSayfasiOlustur(DataGridView dataGridView, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bm, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void button_baski_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) => YazdirmaSayfasiOlustur(dataGridView1, e);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;

            printPreviewDialog.ShowDialog();
        }

        private void button_yeni_Click(object sender, EventArgs e)
        {
            patient_regist form4 = new patient_regist();
            form4.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            policlinic_regist form = new policlinic_regist();
            form.Show();
            this.Close();
        }
    }
}
