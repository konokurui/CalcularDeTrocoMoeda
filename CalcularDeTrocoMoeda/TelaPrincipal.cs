using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularDeTrocoMoeda
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            
            //declaramos as variaveis para o tipo decimal
            decimal valorcompra;
            decimal valorpago;
            decimal resto;

            //Receber os valores nas variaveis declaradas e converter para o decimal

            valorcompra = Convert.ToDecimal(tbtValorCompra.Text);
            valorpago = Convert.ToDecimal(tbtValorPago.Text);

            resto = valorpago - valorcompra;


            lblResultadoTroco.Text = resto.ToString();

            int moedas100 = (int)(resto / 1);

            resto = resto % 1m;

            //resto = resto %1;

            lblqtdMoeda100.Text = moedas100.ToString();

            int moedas050 = (int)(resto / 0.50m);

            resto = resto % 0.50m;

            lblqtdMoeda050.Text = moedas050.ToString();

            int moedas025 = (int)(resto / 0.25m);

            resto = resto % 0.25m;

            lblqtdMoeda025.Text = moedas025.ToString();

            int moedas010 = (int)(resto / 0.10m);

            resto = resto % 0.10m;

            lblqtdMoeda010.Text = moedas010.ToString();

            int moedas005 = (int)(resto / 0.05m);

            resto = resto % 0.05m;

            lblqtdMoeda005.Text = moedas005.ToString();

            int moedas001 = (int)(resto / 0.01m);

            resto = resto % 0.01m;

            lblqtdMoeda001.Text = moedas001.ToString();



            if (tbtValorCompra.Text == "")
            {

                MessageBox.Show("Digite numero");

            }
            else 
            {
                MessageBox.Show("digite numero");
            }



        }
    }
}
