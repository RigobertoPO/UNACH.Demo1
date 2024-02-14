using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNACH.Demo1.CalculadoraWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Calcular calcular = new Calcular();
            int resultado =
                calcular.
                Sumar(int.Parse(txtNumero1.Text),
                Convert.ToInt32(txtNumero2.Text));
            lblResultado.Text = 
                resultado.ToString();
        }
    }
}
