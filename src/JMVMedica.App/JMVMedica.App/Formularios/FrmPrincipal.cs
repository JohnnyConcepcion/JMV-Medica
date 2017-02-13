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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tipoDeFarmacosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoFarmaco frmTipoFarmaco = new FrmTipoFarmaco();
            frmTipoFarmaco.MdiParent = this;
            frmTipoFarmaco.Show();
        }
    }
}
