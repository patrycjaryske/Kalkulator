using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private double pierwszaLiczba = 0; // Przechowuje pierwsz¹ liczbê
        private string operacja = ""; // Przechowuje operator (+, -, *, /)
        private bool nowaLiczba = false; // Flaga do czyszczenia ekranu
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void buttonplus_Click(object sender, EventArgs e)
        {

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {

        }

        private void buttonmnozenie_Click(object sender, EventArgs e)
        {

        }

        private void buttondzielenie_Click(object sender, EventArgs e)
        {

        }

       

        private void textWynik_TextChanged(object sender, EventArgs e)
        {

        }

      





        // Obs³uga cyfr (0-9)
        private void Cyfra_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (nowaLiczba)
            {
                textWynik.Text = ""; // Czyœcimy pole po operacji
                nowaLiczba = false;
            }

            textWynik.Text += btn.Text; // Dodajemy cyfrê do ekranu
        }

        // Obs³uga operatorów (+, -, *, /)
        private void Operacja_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textWynik.Text != "")
            {
                pierwszaLiczba = double.Parse(textWynik.Text);
                operacja = btn.Text;
                nowaLiczba = true;
            }
        }

        // Obliczanie wyniku
        private void buttonrowne_Click(object sender, EventArgs e)
        {
            if (textWynik.Text != "")
            {
                double drugaLiczba = double.Parse(textWynik.Text);
                double wynik = 0;

                switch (operacja)
                {
                    case "+": wynik = pierwszaLiczba + drugaLiczba; break;
                    case "-": wynik = pierwszaLiczba - drugaLiczba; break;
                    case "*": wynik = pierwszaLiczba * drugaLiczba; break;
                    case "/":
                        if (drugaLiczba != 0)
                            wynik = pierwszaLiczba / drugaLiczba;
                        else
                        {
                            MessageBox.Show("Nie mo¿na dzieliæ przez zero!");
                            return;
                        }
                        break;
                }

                textWynik.Text = wynik.ToString();
                nowaLiczba = true;
            }
        }

        // Reset kalkulatora (jeœli dodasz przycisk "C")
        private void buttonC_Click(object sender, EventArgs e)
        {
            textWynik.Text = "";
            pierwszaLiczba = 0;
            operacja = "";
        }
    }
}
