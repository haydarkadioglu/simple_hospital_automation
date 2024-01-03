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

namespace hospital_automation
{
    public partial class patient_info : Form
    {
        private string[] datas, datas1;
        public patient_info()
        {
            InitializeComponent();
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string dosya_yolu = "taburcu.txt";

                datas = File.ReadAllLines(dosya_yolu);
            }
            else if (radioButton2.Checked)
            {
                string dosya_yolu = "non_taburcu.txt";

                datas = File.ReadAllLines(dosya_yolu);
            }
            else if (radioButton3.Checked)
            {
                string dosya = "taburcu.txt";
                string dosya1 = "non_taburcu.txt";

                datas = File.ReadAllLines(dosya);
                datas1 = File.ReadAllLines(dosya1);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            main_page form2 = new main_page();
            form2.Show();
            this.Close();
        }

        private void button_sorgula_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (radioButton1.Checked)
            {
                string dosya_yolu = "taburcu.txt";

                datas = File.ReadAllLines(dosya_yolu);
                foreach (string data in datas)
                {
                    string[] strings = data.Split(";");
                    dataGridView1.Rows.Add(strings);


                }
            }
            else if (radioButton2.Checked)
            {
                string dosya_yolu = "non_taburcu.txt";

                datas = File.ReadAllLines(dosya_yolu);
                foreach (string data in datas)
                {
                    string[] strings = data.Split(";");
                    dataGridView1.Rows.Add(strings);


                }
            }
            else if (radioButton3.Checked)
            {
                string dosya = "taburcu.txt";
                string dosya1 = "non_taburcu.txt";

                datas = File.ReadAllLines(dosya);
                datas1 = File.ReadAllLines(dosya1);
                foreach (string data in datas)
                {
                    string[] strings = data.Split(";");
                    dataGridView1.Rows.Add(strings);


                }
                foreach (string data in datas1)
                {
                    string[] strings = data.Split(";");
                    dataGridView1.Rows.Add(strings);


                }
            }
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private static void YazdirmaSayfasiOlustur(DataGridView dataGridView, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bm, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
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
    }
}
