using P2Circunferencia.Datos;
using P2Circunferencia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2Circunferencia.Windows
{
    public partial class FrmListaCircunferencias : Form
    {
        public FrmListaCircunferencias()
        {
            InitializeComponent();
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private RepositorioDeCircunferencias repositorio; 
        private List<Circunferencia> lista;
        private int cantidadDeRegistros;
        private void FrmListaCircunferencias_Load(object sender, EventArgs e)
        {
            CargarDatosComboFiltroRelleno();
            CargarDatosComboFiltroBorde();
            repositorio = new RepositorioDeCircunferencias();
            cantidadDeRegistros = repositorio.GetCantidad();
            if (cantidadDeRegistros>0)
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros(cantidadDeRegistros);
            }
        }

        private void CargarDatosComboFiltroRelleno()
        {
            var lista = Enum.GetValues(typeof(ColoresDispiblesRelleno)).Cast<ColoresDispiblesRelleno>().ToList();
            foreach (var circunferencia in lista)
            {
                ColorRellenoToolStripComboBox.Items.Add(circunferencia);
            }
        }

        private void CargarDatosComboFiltroBorde()
        {
            var lista = Enum.GetValues(typeof(ColoresDisponiblesBorde)).Cast<ColoresDisponiblesBorde>().ToList();
            foreach (var circunferencia in lista)
            {
                ColorBordeToolStripComboBox.Items.Add(circunferencia);
            }
        }
        private void ActualizarCantidadDeRegistros(int i)
        {
            CantidadDeRegistrosLabel.Text = i.ToString();
        }

        private void ActualizarCantidadDeRegistros()
        {
            CantidadDeRegistrosLabel.Text = repositorio.GetCantidad().ToString();
        }
        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var circunferencia in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, circunferencia);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Circunferencia circunferencia)
        {
            r.Cells[colRadio.Index].Value = circunferencia.Radio;
            r.Cells[colPerimetro.Index].Value = circunferencia.GetPerimetro();
            r.Cells[colArea.Index].Value = circunferencia.GetArea();
            r.Cells[colColorBorde.Index].Value = circunferencia.ColoresDisponiblesBorde;
            r.Cells[colColorRelleno.Index].Value = circunferencia.ColoresDispiblesRelleno;

            r.Tag = circunferencia; 
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmCircunferenciaEdit frm = new FrmCircunferenciaEdit() { Text = "Nueva Circunferencia" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            Circunferencia circunferencia = frm.GetCircunferencia();
            if (repositorio.Existe(circunferencia))
            {
                MessageBox.Show("Circunferencia Repetida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            repositorio.Agregar(circunferencia);
            var r = ConstruirFila();
            SetearFila(r, circunferencia);
            AgregarFila(r);
            MessageBox.Show("Circunferencia Agregada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Circunferencia circunferencia = (Circunferencia)r.Tag;

            DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar Baja", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr==DialogResult.Yes)
            {
                bool borrado = repositorio.Borrar(circunferencia);
                if (borrado)
                {
                    DatosDataGridView.Rows.Remove(r);
                    ActualizarCantidadDeRegistros();
                    MessageBox.Show("Registro Borrado!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede dar de baja el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros(repositorio.GetCantidad());
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Circunferencia circunferenciaSeleccionada = (Circunferencia)r.Tag;
            Circunferencia copiaCircunferencia = (Circunferencia)circunferenciaSeleccionada.Clone();
            FrmCircunferenciaEdit frm = new FrmCircunferenciaEdit();
            frm.SetCircunferencia(copiaCircunferencia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            copiaCircunferencia = frm.GetCircunferencia();
            if (repositorio.Existe(copiaCircunferencia))
            {
                MessageBox.Show("La Circunferencia ya extiste!!");
                return;
            }
            else
            {
                repositorio.Editar(circunferenciaSeleccionada, copiaCircunferencia);
                SetearFila(r, copiaCircunferencia);
                MessageBox.Show("Registro Modificado");
            }
        }

        private void AscendenteRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenAscendentePorRadio();
            MostrarDatosEnGrilla();
        }

        private void DescendenteRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenDescendentePorRadio();
            MostrarDatosEnGrilla();
        }

        private void ColorRellenoToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorRellenoToolStripComboBox.SelectedIndex>=-1)
            {
                var index = ColorRellenoToolStripComboBox.SelectedIndex;
                Func<Circunferencia, bool> predicado = p => p.ColoresDispiblesRelleno == (ColoresDispiblesRelleno)index;
                lista = RepositorioDeCircunferencias.GetInstancia().GetListaFiltrada(predicado);
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros(repositorio.GetCantidad(predicado));
            }
        }

        private void ColorBordeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorBordeToolStripComboBox.SelectedIndex >= -1)
            {
                var index = ColorBordeToolStripComboBox.SelectedIndex;
                Func<Circunferencia, bool> predicado = p => p.ColoresDisponiblesBorde == (ColoresDisponiblesBorde)index;
                lista = RepositorioDeCircunferencias.GetInstancia().GetListaFiltrada(predicado);
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros(repositorio.GetCantidad(predicado));
            }
        }
    }
}
