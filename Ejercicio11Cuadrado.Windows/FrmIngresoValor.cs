using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11Cuadrado.Windows
{
    public partial class FrmIngresoValor : Form
    {
        public FrmIngresoValor()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private int valor;
        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!int.TryParse(ValorTextBox.Text,out valor))
            {
                esValido = false;
                errorProvider1.SetError(ValorTextBox,"Valor mal ingresado");
            }

            return esValido;
        }

        public int GetValor()
        {
            return valor;
        }
    }
}
