using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor1.Focus();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int valor1, valor2;

            if (int.TryParse(txtValor1.Text, out valor1) && int.TryParse(txtValor2.Text, out valor2))
            {
                lsbResultado.Items.Clear();

                if (valor1 > valor2)
                {
                    int temp = valor1;
                    valor1 = valor2;
                    valor2 = temp;
                }

                for (int i = valor1 + 1; i < valor2; i++)
                {
                    lsbResultado.Items.Add(i);
                }

                if (valor1 == valor2)
                {
                    MessageBox.Show("Os valores são iguais, tente com outros valores","Ops, Tente novamente!");
                }
            }  

            else
                {
                    MessageBox.Show("Por favor, insira valores numéricos!", "Error!!!!");
                }

        }
    }
}
