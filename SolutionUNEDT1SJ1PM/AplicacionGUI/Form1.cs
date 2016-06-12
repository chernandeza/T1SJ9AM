using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoUNEDT1SJ1PM;

namespace AplicacionGUI
{
    public partial class frmPersonaFisica : Form
    {
        PersonaFisica miPerFis;

        public frmPersonaFisica()
        {
            InitializeComponent();
            miPerFis = new PersonaFisica();
        }

        private void frmPersonaFisica_Load(object sender, EventArgs e)
        {
            rbNA.Checked = true;
            cmbEstadoCiv.DataSource = Enum.GetNames(typeof(EstadosCiviles));
            cmbEstadoCiv.SelectedIndex = 5;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "" || txtNombre.Text == "" || mtbCedula.Text == "" || cmbEstadoCiv.SelectedIndex == 5)
            {
                MessageBox.Show("Debe llenar todos los datos", "UNED San Jose", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                miPerFis.Cedula = mtbCedula.Text;
                miPerFis.Nombre = txtNombre.Text;
                miPerFis.Direccion = txtDireccion.Text;
                miPerFis.Sexo = rbMasc.Checked ? 0 : rbFem.Checked ? 1 : 2;
                miPerFis.EstadoCivil = (EstadosCiviles)Enum.Parse(typeof(EstadosCiviles), cmbEstadoCiv.SelectedValue.ToString());
                miPerFis.FechaNacConst = dtpFechaNac.Value;
                frmPJ formPJ = new frmPJ(miPerFis);
                formPJ.Show();
                this.Hide();
            }
        }
    }
}
