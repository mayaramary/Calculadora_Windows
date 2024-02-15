using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Windows
{
    public partial class Form1 : Form
    {

        double acumula = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void bzero_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void bum_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void bdois_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void btres_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void bquatro_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void bcinco_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void bseis_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void bsete_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void boito_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void bnove_Click(object sender, EventArgs e)
        {
           display.Text += "9";
        }

        private void bsoma_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "+";
            }
        }

        private void bsubtracao_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }
        }

        private void bmultiplicacao_Click(object sender, EventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "*";
            }

        }

        private void bdivisao_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "/";
            }

        }

        private void braiz_Click(object sender, EventArgs e)
        {
            double x = double.Parse(display.Text);
            if (x < 0)
            {
                display.Text = "Este valor não é valido.";
            }
            else
            {
                x = Math.Sqrt(x);
                display.Text = x.ToString();
            }

        }
        
        private void bvirgula_Click(object sender, EventArgs e)
        {
            {
                display.Text += ",";
            }

        }

        private void blimpa_Click(object sender, EventArgs e)
        {
            acumula = 0;
            display.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bigual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
        }
    }
}
