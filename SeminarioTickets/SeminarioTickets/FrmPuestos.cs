using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmPuestos : Form
    {
        public FrmPuestos()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec InsercionPuestos '" + txtId.Text + "', '" + txtNombre.Text + "'");
            MessageBox.Show("Datos guardados correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();

            txtId.Focus();

            conexion.Grids("SELECT IdPst as ID, NomPst as Puesto FROM Puestos", dgvPuestos);

        }

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT * FROM Puestos", dgvPuestos);
        }
    }
}
