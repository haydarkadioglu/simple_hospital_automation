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
    public partial class patient_regist : Form
    {
        public patient_regist()
        {
            InitializeComponent();
        }


        private bool controlNumber()
        {
            string dosya = "taburcu.txt";
            string dosya1 = "non_taburcu.txt";

            string[] datas = File.ReadAllLines(dosya)
                              .Concat(File.ReadAllLines(dosya1))
                              .ToArray();

            foreach (string data in datas)
            {
                string[] data2 = data.Split(';');
                if (textBox1.Text == data2[0])
                {

                    return true;
                }
            }
            return false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool control = controlNumber();
            if (control)
            {
                MessageBox.Show("Dosya numarası kayıtlıdır. Tekrar deneyin.");
                return;
            }
            string file = "";
            if (comboBox3.Text == "Taburcu")
            {
                file = "taburcu.txt";
            }
            else if (comboBox3.Text == "Taburcu Değil")
            {
                file = "non_taburcu.txt";
            }
            else
            {
                MessageBox.Show("Durum kısmı boş bırakılmıştır.");
                return;
            }

            using (StreamWriter sw = new StreamWriter($"{file}", true))
            {
                sw.WriteLine($"{textBox1.Text};{textBox2.Text};{textBox3.Text};{dateTimePicker1.Text};{comboBox1.Text};{comboBox2.Text};Konya Devlet Hastanesi");
            }
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
