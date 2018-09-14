using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        Numero num1;
        Numero num2;
        Calculadora calculadora;
        bool chequeo = false;

        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void LaCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            chequeo = false;
            this.calculadora = new Calculadora();
            this.num1 = new Numero(this.txtNumero1.Text);
            this.num2 = new Numero(this.txtNumero2.Text);
            this.lblResultado.Text = ""+ calculadora.Operar(num1, num2, this.cmbOperator.Text);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is ComboBox || item is Label)
                {
                    item.Text = "";
                }
            }
            chequeo = false;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.num1 = new Numero();
            if (chequeo == false && lblResultado.Text != "Valor invalido")
            {
                lblResultado.Text = this.num1.DecimalBinario(lblResultado.Text);
                chequeo = true;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.num1 = new Numero();
            if (chequeo == true && lblResultado.Text != "Valor invalido")
            {
                lblResultado.Text = this.num1.BinarioDecimal(lblResultado.Text);
                chequeo = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
