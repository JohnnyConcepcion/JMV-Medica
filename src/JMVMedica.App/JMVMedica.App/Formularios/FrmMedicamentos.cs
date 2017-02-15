using JMVMedica.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMVMedica.App.Formularios
{
    public partial class FrmMedicamentos : Form
    {
        int _idActual = -1;
        Dispensario dispensario;
        public FrmMedicamentos()
        {
            InitializeComponent();
            dispensario = new Dispensario();
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {
            Cargar();
            CargarCb();
        }

        private void CargarCb()
        {
            //TODO:Cargar los ComboBox
        }

        private void Cargar()
        {
            var medicamentos = dispensario.CargarMedicamentos()
                .Select(x => new
                {
                    x.MedicamentoId,
                    x.Descripcion
                });
            dgvMedicamentos.DataSource = medicamentos.ToArray();
            dgvMedicamentos.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idActual < 0)
                {
                    dispensario.InsertarMedicamento(txtDescripcion.Text,
                            (int)cbTipoFarmaco.SelectedValue, (int)cbMarca.SelectedValue,
                            (int)cbUbicacion.SelectedValue, txtDosis.Text);
                }
                else
                    dispensario.EditarMedicamento(_idActual, txtDescripcion.Text,
                            (int)cbTipoFarmaco.SelectedValue, (int)cbMarca.SelectedValue,
                            (int)cbUbicacion.SelectedValue, txtDosis.Text);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo guardar el medicamento");
            }
        }

        private void Limpiar()
        {
            txtDescripcion.Text = string.Empty;
            txtDosis.Text = string.Empty;
            cbUbicacion.SelectedIndex = -1;
            cbTipoFarmaco.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            _idActual = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idActual > -1)
                {
                    dispensario.BorrarMedicamento(_idActual);
                }
                else
                    MessageBox.Show(this, "Debe elegir un registro");
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ocurrio un error al eliminar");
                throw;
            }
        }
    }
}
