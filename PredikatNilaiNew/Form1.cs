using System;

namespace PredikatNilaiNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox1.Text, out int nilai) && nilai >= 0 && nilai <= 100)
            {
                string predikat = "";

                
                if (nilai >= 91 && nilai <= 100)
                {
                    predikat = "Amat Baik";
                }
                else if (nilai >= 81 && nilai <= 90)
                {
                    predikat = "Baik";
                }
                else if (nilai >= 71 && nilai <= 80)
                {
                    predikat = "Cukup Baik";
                }
                else if (nilai >= 61 && nilai <= 70)
                {
                    predikat = "Cukup";
                }
                else if (nilai >= 0  && nilai <= 60)
                {
                    predikat = "Kurang";
                }
                else
                {
                    predikat = "Kurang";
                }

                
                lblPredikat.Text = $"{predikat}";
            }
            else
            {
                lblPredikat.Text = "invalid";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPredikat_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}