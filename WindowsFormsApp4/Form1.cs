using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;

            double n = double.Parse(k_box.Text);
            n = Math.Pow(10, n);
            int z = int.Parse(z_box.Text);
            Random rnd = new Random();
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = double.Parse(x1_box.Text);
            single.X2 = double.Parse(x2_box.Text);
            single.Area = (Math.Pow(single.X1,4)/4) - (Math.Pow(single.X2, 4) / 4);
            while (true)
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i * i) * (i - old_i);

                    old_i = i;
                };

                double kwadrat_f = f;
                f = 0.0F;

                old_i = 0;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i * i) + (old_i * old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };
                bool czy = false;
                bool czy2 = false;
                if (Math.Floor(f) % z == 0 )
                {
                    string napis = "     kwadrat: X1 = " + single.X1.ToString() + "  X2 = " + single.X2.ToString();
                    wynik_box.Text += napis;
                    czy = true;
                }
                if (Math.Floor(kwadrat_f) % z == 0) 
                {
                    string napis = "     trapez: X1 = " + single.X1.ToString() + "  X2 = " + single.X2.ToString();
                    wynik_box.Text += napis;
                    czy2 = true;
                }
                if (czy && czy2) 
                {
                    break;
                }

                Console.Out.WriteLine(Math.Floor(kwadrat_f) % z);
                single.X2 += 0.1;

            };
        }

    }
}
