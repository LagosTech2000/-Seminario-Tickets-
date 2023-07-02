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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
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

            conexion.Modificaciones("exec InsercionClientes '"+ txtId.Text + "', '" + txtNombre.Text + "', "+  txtTelefono.Text + ", '" + txtCorreo.Text + "', '" + txtDireccion.Text + "', '" + txtRTN.Text + "', " + "'" + genero + "'");
            MessageBox.Show("Datos guardados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtRTN.Clear();

            txtId.Focus();

            conexion.Grids("SELECT IdCli as Identidad, NomCli as Nombre,  TelCli as Telefono, EmlCli as Correo, DirCli as Direccion, RtnCli  as RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero FROM Clientes", dgvClientes);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT IdCli as Identidad, NomCli as Nombre,  TelCli as Telefono, EmlCli as Correo, DirCli as Direccion, RtnCli  as RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END as Genero FROM Clientes", dgvClientes);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
