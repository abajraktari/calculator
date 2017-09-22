using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string islem = "";
        double sayi1 = 0;
        bool isOperationStarted = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        // numbers
        private void button_Click(object sender, EventArgs e)
        {
            if (isOperationStarted)
                sonuc.Clear();

            isOperationStarted = false;

            Button b = (Button)sender;
            sonuc.Text += b.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sonuc.Clear();
        }

        // sum
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            islem = b.Text;
            sayi1 = double.Parse(sonuc.Text);
            // sonuc.Clear();
            isOperationStarted = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch(islem)
            {
                case "+":
                    sonuc.Text = (sayi1 + double.Parse(sonuc.Text)).ToString();
                    break;
                case "-":
                    sonuc.Text = (sayi1 - double.Parse(sonuc.Text)).ToString();
                    break;
                case "*":
                    sonuc.Text = (sayi1 * double.Parse(sonuc.Text)).ToString();
                    break;
                case "/":
                    sonuc.Text = (sayi1 / double.Parse(sonuc.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
