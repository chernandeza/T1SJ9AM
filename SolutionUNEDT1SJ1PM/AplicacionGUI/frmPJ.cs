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
    public partial class frmPJ : Form
    {
        PersonaJuridica miperJ;
        public frmPJ()
        {
            InitializeComponent();
        }
        public frmPJ(PersonaFisica pf)
        {
            InitializeComponent();
            miperJ = new PersonaJuridica();
            miperJ.RepresentanteLegal = pf;
        }

        private void frmPJ_Load(object sender, EventArgs e)
        {
            cmbTipoPJ.DataSource = Enum.GetNames(typeof(TipoPJ));
            txtRepresentante.Text = miperJ.RepresentanteLegal.Cedula +
                Environment.NewLine + miperJ.RepresentanteLegal.Nombre + Environment.NewLine +
                miperJ.RepresentanteLegal.FechaNacConst.ToShortDateString();
        }

        private void btnGuardarInfo_Click(object sender, EventArgs e)
        {
            miperJ.Cedula = mtbCedula.Text;
            miperJ.Nombre = txtNombre.Text;
            miperJ.Direccion = txtDireccion.Text;
            miperJ.FechaNacConst = dtpFechaNac.Value;
            miperJ.Tipo = (TipoPJ)Enum.Parse(typeof(TipoPJ), cmbTipoPJ.SelectedValue.ToString());
        }
    }
}
