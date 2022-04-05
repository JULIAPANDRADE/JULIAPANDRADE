using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLadoA_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(txtLadoA.Text, out ladoA))
                MessageBox.Show("Numero do ladoA e invalido!");

        }

        private void txtLadoB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoB.Text, out ladoB))
                MessageBox.Show("Numero do ladoB e invalido!");
        }

        private void txtLadoC_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoC.Text, out ladoC))
                MessageBox.Show("Numero do ladoC e invalido!");
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtLadoA.Text, out ladoA) && (double.TryParse(txtLadoB.Text, out ladoB) && (double.TryParse(txtLadoC.Text, out ladoC))))
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
        }

        

        



    }
}
