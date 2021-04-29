using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Calculadora : Form {
        public Calculadora() {
            InitializeComponent();
        }

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        private void btn0_Click(object sender, EventArgs e) {
            txtResultado.Text += "0";
        }
        private void btn1_Click_1(object sender, EventArgs e) {
            txtResultado.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e) {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e) {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e) {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e) {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e) {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e) {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e) {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e) {
            txtResultado.Text += "9";
        }
        private void btnPonto_Click(object sender, EventArgs e) {
            txtResultado.Text += ".";
        }

        private void btnMais_Click_1(object sender, EventArgs e) {
            if (txtResultado.Text != "") {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            } else {
                MessageBox.Show("-- INFORME UM VALOR PARA EFETUAR A SOMA --");
            }
        }

        private void btnMenos_Click_1(object sender, EventArgs e) {
            if (txtResultado.Text != "") {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            } else {
                MessageBox.Show("-- INFORME UM VALOR PARA EFETUAR A SOMA --");
            }
        }

        private void btnMultiplicacao_Click_1(object sender, EventArgs e) {
            if (txtResultado.Text != "") {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "*";
            } else {
                MessageBox.Show("-- INFORME UM VALOR PARA EFETUAR A SOMA --");
            }
        }

        private void btnDivisao_Click_1(object sender, EventArgs e) {
            if (txtResultado.Text != "") {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "/";
            } else {
                MessageBox.Show("-- INFORME UM VALOR PARA EFETUAR A SOMA --");
            }
        }

        private void btnC_Click_1(object sender, EventArgs e) {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void btnCE_Click_1(object sender, EventArgs e) {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }


        private void btnIgual_Click(object sender, EventArgs e) {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA") {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "SUBTRACAO") {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao == "MULTIPLICACAO") {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            } else {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

    }
}
