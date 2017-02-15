using JMVMedica.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMVMedica.App.Formularios
{
    public partial class FrmTipoFarmaco : Form
    {
        private int _idActual = 0;
        public Dispensario dispensario;
        public FrmTipoFarmaco()
        {
            InitializeComponent();
        }

        private void FrmTipoFarmaco_Load(object sender, EventArgs e)
        {
            this.dispensario = new Dispensario();
            Cargar();
        }

        private void Cargar()
        {
            var tipoFarmacos = this.dispensario.CargarTipoFarmacos()
                .Select(x => new {
                    TipoFarmacoId = x.TipoFarmacoId,
                    Descripcion = x.Descripcion
                });
            dgvTipoFarmacos.DataSource = tipoFarmacos.ToArray();
            dgvTipoFarmacos.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (this.dispensario.CargarTipoFarmacos().Any(x => x.TipoFarmacoId == _idActual))
            {
                this.dispensario.EditarTipoFarmaco(_idActual, txtDescripcion.Text);
            }
            else
                this.dispensario.InsertarTipoFarmaco(txtDescripcion.Text);
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.dispensario.BorrarTipoFarmaco(_idActual);
            Cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = string.Empty;
            _idActual = 0;
        }

        private void dgvTipoFarmacos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var celdas = dgvTipoFarmacos.Rows[e.RowIndex].Cells;
            txtDescripcion.Text = celdas["Descripcion"].Value.ToString();
            _idActual = (int)celdas["TipoFarmacoId"].Value;

        }
    }
}
