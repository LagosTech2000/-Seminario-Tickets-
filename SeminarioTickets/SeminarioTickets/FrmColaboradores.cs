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
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
        }

        private void FrmColaboradores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seminarioTicketsDataSet.Puestos' table. You can move, or remove it, as needed.
            this.puestosTableAdapter.Fill(this.seminarioTicketsDataSet.Puestos);
            conexion.Grids("SELECT * FROM Colaboradores", dgvColaboradores);

        }

        Conexion conexion = new Conexion();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int genero;
            if(cbxGenero.Text == "Femenino")
            {
                genero = 1;
            }
            else
            {
                genero = 0;
            }
            conexion.Modificaciones("exec InsercionColaboradores " + txtId.Text + ", '" + txtNombre.Text + "','" + dtpFechaContratacion.Value.ToString("yyyy-MM-dd") + "', '" + txtEmail.Text + "', '" + txtDireccion.Text + "', " + txtTelefono.Text + ", " + genero + ", " + cbxPuesto.SelectedValue );

            MessageBox.Show("Datos fueron guardados correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();

            txtId.Focus();

            conexion.Grids("SELECT * FROM Colaboradores", dgvColaboradores);
        }
    }
}
