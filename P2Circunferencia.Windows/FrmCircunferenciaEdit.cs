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
    public partial class FrmCircunferenciaEdit : Form
    {
        public FrmCircunferenciaEdit()
        {
            InitializeComponent();
        }

        private Circunferencia circunferencia;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboColoresRelleno(ref ColorRellenoComboBox);
            CargarDatosComboColoresBorde(ref ColorBordeComboBox);
        }

        private void CargarDatosComboColoresBorde(ref ComboBox borde)
        {
            borde.DataSource = Enum.GetValues(typeof(ColoresDisponiblesBorde));
        }

        private void CargarDatosComboColoresRelleno(ref ComboBox relleno)
        {
            relleno.DataSource = Enum.GetValues(typeof(ColoresDispiblesRelleno));
        }

        internal Circunferencia GetCircunferencia()
        {
            return circunferencia;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                circunferencia = new Circunferencia();
                circunferencia.Radio = int.Parse(RadioTextBox.Text);
                circunferencia.ColoresDispiblesRelleno = (ColoresDispiblesRelleno)ColorRellenoComboBox.SelectedItem;
                circunferencia.ColoresDisponiblesBorde = ((ColoresDisponiblesBorde)ColorBordeComboBox.SelectedItem);
                if (circunferencia.Validar())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(RadioTextBox, "El valor del Radio debe ser mayor a 0");
                    RadioTextBox.Focus();
                }
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(RadioTextBox.Text, out int radio))
            {
                valido = false;
                errorProvider1.SetError(RadioTextBox, "Radio no valido");
                RadioTextBox.Focus();

            }
            return valido;
        }

        private void FrmCircunferenciaEdit_Load(object sender, EventArgs e)
        {

        }

        internal void SetCircunferencia(Circunferencia copiaCircunferencia)
        {
            this.circunferencia = copiaCircunferencia;
        }
    }
}
