using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave2._2LommeregnerAndenSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variabler
        double a, b, result;
        bool plus = false, minus = false, multiply = false, divide = false;

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            plus = false; minus = false; multiply = false; divide = false;
            a = 0; b = 0; result = 0;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            minus = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            multiply = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            divide = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            plus = true;
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (plus == true || minus == true || multiply == true || divide == true)
            {
                try
                {
                    a = Convert.ToDouble(textBox1.Text); // Konvertere textbox1 til en double, så der kan regnes på det, da det jo er en string
                    b = Convert.ToDouble(textBox2.Text); // --------- || ---------
                }
                catch
                {
                    labelResult.Text = "Indtast kun tal";
                }
            }
            else
            {
                labelResult.Text = "Klik på et tegn for at udregne.";
            }

            if (plus == true)
            {
                result = a + b; // Lægger a og b sammen og konvertere til tekst
                labelResult.Text = Convert.ToString(result); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'
            }

            else if (minus == true)
            {
                result = a - b; // Lægger a og b sammen og konvertere til tekst
                labelResult.Text = Convert.ToString(result); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'
            }

            else if (multiply == true)
            {
                result = a * b; // Lægger a og b sammen og konvertere til tekst
                labelResult.Text = Convert.ToString(result); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'
            }
            else if (divide == true)
            {
                result = a / b; // Lægger a og b sammen og konvertere til tekst
                labelResult.Text = Convert.ToString(result); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'
            }
        }

        
    }
}
