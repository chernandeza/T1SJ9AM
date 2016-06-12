using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPrincipal;

namespace InfoPersonasGUI
{
    public partial class InfoPersonasGUI : Form
    {
        PersonaFisica perfis;

        public InfoPersonasGUI()
        {
            InitializeComponent();
            perfis = new PersonaFisica();
        }

        private void btnSalvarPF_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && mtbID.Text != "" && cmbEstadoCivil.SelectedIndex != 0)
            {
                perfis.Identificacion = mtbID.Text;
                perfis.Nombre = txtNombre.Text;
                perfis.Sexo = rbFem.Checked ? Genero.Femenino : rbMasc.Checked ? Genero.Masculino : Genero.NoEspecifica;
                perfis.EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), cmbEstadoCivil.SelectedValue.ToString());
                perfis.Fecha = dtpFechaNac.Value;
            }
            else
            {
                MessageBox.Show("Debe llenar todos los datos", "Mi aplicacion grafica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InfoPersonasGUI_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido, usuario", "Mi aplicacion grafica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rbNA.Checked = true;
            cmbEstadoCivil.DataSource = Enum.GetNames(typeof(EstadoCivil));
            cmbEstadoCivil.SelectedIndex = 0;
        }
    }
}
