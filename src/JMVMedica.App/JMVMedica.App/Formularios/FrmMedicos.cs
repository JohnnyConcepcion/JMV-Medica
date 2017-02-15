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
    public partial class FrmMedicos : Form
    {
        int _idActual = -1;

        Dispensario dispensario;

        public FrmMedicos()
        {
            InitializeComponent();
            dispensario = new Dispensario();
            Cargar();
        }

        private void Cargar()
        {
            //TODO:Cargar medicos
        }

        //Metodo para validar la cedula

        public Boolean validarCedulaMedico() {

            try
            {
                String cedulaMedico = txtCedula.Text;
                int cedula = int.Parse(cedulaMedico);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se a producido un error");
                MessageBox.Show(ex.ToString());
                return false;

            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_idActual < 0) {
                //TODO:Agregar medcio
            }

            Limpiar();
        }

        private void Limpiar()
        {
            _idActual = -1;
            txtNombreDoctor.Text = string.Empty;
            txtEspecialidad.Text = string.Empty;
            txtCedula.Text = string.Empty;
            comboTanda.SelectedIndex = -1;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
