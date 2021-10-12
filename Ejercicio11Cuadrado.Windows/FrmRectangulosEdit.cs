using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio11Rectangulo.Entidades;

namespace Ejercicio11Cuadrado.Windows
{
    public partial class FrmRectangulosEdit : Form
    {
        public FrmRectangulosEdit()
        {
            InitializeComponent();
        }

        private Rectangulo rectangulo;
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (rectangulo==null)
                {
                    rectangulo = new Rectangulo();
                }

                rectangulo.LadoMayor = int.Parse(LadoMayorTextBox.Text);
                rectangulo.LadoMenor = int.Parse(LadoMenorTextBox.Text);
                if (!rectangulo.Validar())
                {
                    MessageBox.Show("El objeto no puede ser validado!!!");
                    LadoMayorTextBox.Focus();
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(LadoMayorTextBox.Text,out int ladoMayor))
            {
                valido = false;
                errorProvider1.SetError(LadoMayorTextBox,"Lado mayor mal ingresado");
            }
            if (!int.TryParse(LadoMenorTextBox.Text, out int ladoMenor))
            {
                valido = false;
                errorProvider1.SetError(LadoMenorTextBox, "Lado menor mal ingresado");
            }

            return valido;
        }

        public Rectangulo GetRectangulo()
        {
            return rectangulo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (rectangulo!=null)
            {
                LadoMayorTextBox.Text = rectangulo.LadoMayor.ToString();
                LadoMenorTextBox.Text = rectangulo.LadoMenor.ToString();
            }
        }

        public void SetRectangulo(Rectangulo copiaRectangulo)
        {
            this.rectangulo = copiaRectangulo;
        }
    }
}
