using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Operacao OperacaoSelecionada { get; set; }

        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        public enum Operacao
        { 
            Adicao,
            Subtracao,
            Mulltiplicacao,
            Divisao
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
            // ou textBox1.Text = textBox1.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";

        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains(","))
                txtresultado.Text += ",";
        }
        private void btnadicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            // Tenho que usar o (Convert.ToDecimal) pois, a nossa variável Valor é decimal
            // e o textBox1 é um texto.
            txtresultado.Text = "";
            lbloperacao.Text = "+";
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbloperacao.Text = "-";
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbloperacao.Text = "/";
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Mulltiplicacao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbloperacao.Text = "x";
        }

        private void buttonlimparc_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            lbloperacao.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Subtracao:
                     Resultado = Valor - Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Mulltiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtresultado.Text);
                    break;
                    lbloperacao.Text = "=";
            }

            txtresultado.Text = Convert.ToString(Resultado);

        }
    }
}
