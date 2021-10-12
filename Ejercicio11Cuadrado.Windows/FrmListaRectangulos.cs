using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio11Rectangulo.Datos;
using Ejercicio11Rectangulo.Entidades;

namespace Ejercicio11Cuadrado.Windows
{
    public partial class FrmListaRectangulos : Form
    {
        public FrmListaRectangulos()
        {
            InitializeComponent();
        }

        private List<Rectangulo> lista;
        private int cantidadRegistros = 0;
        private RepositorioDeRectangulos repositorio;
        private void FrmListaRectangulos_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioDeRectangulos();
            cantidadRegistros = repositorio.GetCantidad();
            if (cantidadRegistros>0)
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros(cantidadRegistros);
            }
        }

        private void ActualizarCantidadDeRegistros(int i)
        {
            CantidadRegistrosLabel.Text = i.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var rectangulo in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, rectangulo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Rectangulo rectangulo)
        {
            r.Cells[colLadoMayor.Index].Value = rectangulo.LadoMayor;
            r.Cells[colLadoMenor.Index].Value = rectangulo.LadoMenor;
            r.Cells[colPerimetro.Index].Value = rectangulo.GetPerimetro();
            r.Cells[colSuperficie.Index].Value = rectangulo.GetSuperficie();

            r.Tag = rectangulo;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmRectangulosEdit frm = new FrmRectangulosEdit();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Rectangulo rectangulo = frm.GetRectangulo();
            if (repositorio.Existe(rectangulo))
            {
                MessageBox.Show("Rectángulo existente!!!");
                return;
            }
            repositorio.Agregar(rectangulo);
            var r = ConstruirFila();
            SetearFila(r,rectangulo);
            AgregarFila(r);
            MessageBox.Show("Registro agregado");
            ActualizarCantidadDeRegistros(repositorio.GetCantidad());
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Rectangulo rectanguloSeleccionado = (Rectangulo) r.Tag;
            Rectangulo copiaRectangulo = (Rectangulo) rectanguloSeleccionado.Clone();
            FrmRectangulosEdit frm = new FrmRectangulosEdit();
            frm.SetRectangulo(copiaRectangulo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            copiaRectangulo = frm.GetRectangulo();
            if (repositorio.Existe(copiaRectangulo))
            {
                MessageBox.Show("Rectángulo existente!!!");
                return;
                
            }
            else
            {
                repositorio.Editar(rectanguloSeleccionado, copiaRectangulo);
                SetearFila(r,copiaRectangulo);
                MessageBox.Show("Registro agregado");
            }
        }
    }
}
